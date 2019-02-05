using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevHelper
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
            InicializaCampos();
        }

        private void InicializaCampos()
        {
            txtIis.Text = Properties.Settings.Default["PastaIIS"].ToString();
            txtPasta.Text = Properties.Settings.Default["PastaRaiz"].ToString();
            txtMSBuild.Text = Properties.Settings.Default["PastaMSBuild"].ToString();
            txtHomolog.Text = Properties.Settings.Default["CShml"].ToString();
            txtDev.Text = Properties.Settings.Default["CSdev"].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["PastaIIS"] = txtIis.Text;
            Properties.Settings.Default["PastaRaiz"] = txtPasta.Text;
            Properties.Settings.Default["PastaMSBuild"] = txtMSBuild.Text;
            Properties.Settings.Default["CShml"] = txtHomolog.Text;
            Properties.Settings.Default["CSdev"] = txtDev.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
