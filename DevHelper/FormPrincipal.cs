using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DevHelper
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            InicializaComboProjetos();
            rbHml.Checked = true;
            cbCompProjeto.Checked = true;
        }

        private void tbLogs_DoubleClick(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes frmConfiguracoes = new FormConfiguracoes();
            frmConfiguracoes.Show();
        }

        private void InicializaComboProjetos()
        {
            this.cbProjeto.Items.Clear();

            var pastaProjetos = Properties.Settings.Default["PastaRaiz"].ToString();
            if (string.IsNullOrEmpty(pastaProjetos)) return;

            var diretorios = Directory.GetDirectories(pastaProjetos)
                .Where(e => e.ToString().ToUpper().Contains("PORTO.SAUDE"));

            foreach (var item in diretorios)
                this.cbProjeto.Items.Add(new DirectoryInfo(item.ToString()).Name);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarExecucao();
                AlterarConnectionString();
                CompilarProjeto();
                PublicarServices();
                CopiarJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }
        }

        private void ValidarExecucao()
        {
            if (cbProjeto.SelectedIndex <= 0)
                throw new ArgumentException("Informe o projeto que deseja executar as ações.");
        }

        private void AlterarConnectionString()
        {
            AdicionarCabecalhoLog("Alterando a Connectionstring");

            var pastaProjeto = string.Format("{0}\\{1}", Properties.Settings.Default["PastaRaiz"].ToString(), cbProjeto.SelectedItem);

            var listaConfigs = new List<string>();
            listaConfigs.Add(string.Format("{0}\\{1}.Portal\\Web.config", pastaProjeto, cbProjeto.SelectedItem));
            listaConfigs.Add(string.Format("{0}\\{1}.Services\\Web.config", pastaProjeto, cbProjeto.SelectedItem));
            listaConfigs.Add(string.Format("{0}\\{1}.Jobs\\App.config", pastaProjeto, cbProjeto.SelectedItem));

            var connectionString = rbDev.Checked 
                ? Properties.Settings.Default["CSdev"].ToString()
                : Properties.Settings.Default["CShml"].ToString();

            foreach (var item in listaConfigs)
            {
                var webConfig = new XmlDocument();
                webConfig.Load(item);
                var nodes = webConfig.SelectNodes("/configuration/connectionStrings");
                if (nodes.Count <= 0) continue;
                nodes[0].InnerXml = connectionString;
                webConfig.Save(item);
            }

            AdicionarLog("Connectionstring alterada com sucesso");
        }

        private void CompilarProjeto()
        {
            if (!this.cbCompProjeto.Checked) return;
            var solucao = string.Format("{0}\\{1}.sln", GetPastaProjeto(), cbProjeto.SelectedItem.ToString());
            var comando = string.Format("\"{0}\\MSBuild.exe\" {1} /p:Configuration=\"Debug\" /p:BuildProjectReferences=false", Properties.Settings.Default["PastaMSBuild"], solucao);
            ExecutarComando(comando);
        }

        private void PublicarServices()
        {
            if (!this.cbPubServices.Checked) return;
            var solucao = string.Format("{0}\\{1}.Services\\{2}.Services.csproj", GetPastaProjeto(), cbProjeto.SelectedItem.ToString(), cbProjeto.SelectedItem.ToString());
            var iis = string.Format("{0}\\{1}.Services", Properties.Settings.Default["PastaIIS"], cbProjeto.SelectedItem.ToString());
            var comando = string.Format("\"{0}\\MSBuild.exe\" {1} /t:PublishToFileSystem /P:Configuration=Debug /p:Platform=\"Any CPU\" /p:PublishDestination=\"{2}\" /p:OutputPath=\"bin\\\" /p:AutoParameterizationWebConfigConnectionStrings=false /p:MvcBuildViews=false", Properties.Settings.Default["PastaMSBuild"], solucao, iis);
            ExecutarComando(comando);
        }

        private void CopiarJobs()
        {
            if (!this.cbCopJobs.Checked) return;

            var projeto = cbProjeto.SelectedItem.ToString();
            var pastaIis = Properties.Settings.Default["PastaIIS"];
            var pastaPublicacao = pastaIis + projeto + ".Services\\Jobs";

            var pastaRaiz = Properties.Settings.Default["PastaRaiz"];
            var pastaJobs = pastaRaiz + "\\Porto.Saude.Jobs\\Porto.Saude.Jobs.Executer\\bin\\Debug";

            if (!Directory.Exists(pastaPublicacao))
                Directory.CreateDirectory(pastaPublicacao);

            // Copiar arquivos gerados pelo Jobs
            foreach (string dirPath in Directory.GetDirectories(pastaJobs, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(pastaJobs, pastaPublicacao));

            foreach (string newPath in Directory.GetFiles(pastaJobs, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(pastaJobs, pastaPublicacao), true);

            // Copiar arquivos gerados pela aplicação
            var pastaProjeto = GetPastaProjeto();
            var pastaBinProjeto = String.Format("{0}\\{1}.Jobs\\bin\\Debug", pastaProjeto, projeto);
            foreach (string dirPath in Directory.GetDirectories(pastaBinProjeto, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(pastaBinProjeto, pastaPublicacao));

            foreach (string newPath in Directory.GetFiles(pastaBinProjeto, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(pastaBinProjeto, pastaPublicacao), true);

            // Corrigir arquivo de configuração
            var novoConfig = pastaPublicacao + "\\jobsexecuter.exe.config";
            if (File.Exists(novoConfig))
                System.IO.File.Delete(novoConfig);

            File.Move(String.Format("{0}\\{1}.Jobs.dll.config", pastaPublicacao, projeto), novoConfig);
        }

        private void AdicionarLog(string text)
        {
            tbLogs.Text += "\n" + text;
        }

        private void AdicionarCabecalhoLog(string titulo)
        {
            tbLogs.Text += "********************************************************************************************************\n";
            tbLogs.Text += "                ######   " + titulo + "   ######\n";
            tbLogs.Text += "********************************************************************************************************\n";
        }

        private void LimparLog()
        {
            tbLogs.Text = string.Empty;
        }

        private void ExecutarComando(string comando)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler);
            p.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = "cmd.exe",
                Arguments = comando,
            };
            p.Start();
            p.BeginOutputReadLine();
        }

        private void OutputHandler(object sender, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                tbLogs.AppendText(outLine.Data + "\r\n");
            }
        }

        private string GetPastaProjeto()
        {
            return string.Format("{0}\\{1}", Properties.Settings.Default["PastaRaiz"], cbProjeto.SelectedItem.ToString());
        }

        private void cbProjeto_Enter(object sender, EventArgs e)
        {
            InicializaComboProjetos();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.Show();
        }
    }
}
