namespace DevHelper
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpProjeto = new System.Windows.Forms.GroupBox();
            this.cbProjeto = new System.Windows.Forms.ComboBox();
            this.gpBase = new System.Windows.Forms.GroupBox();
            this.rbHml = new System.Windows.Forms.RadioButton();
            this.rbDev = new System.Windows.Forms.RadioButton();
            this.gpOpcoes = new System.Windows.Forms.GroupBox();
            this.cbCopJobs = new System.Windows.Forms.CheckBox();
            this.cbPubServices = new System.Windows.Forms.CheckBox();
            this.cbCompProjeto = new System.Windows.Forms.CheckBox();
            this.gpLogs = new System.Windows.Forms.GroupBox();
            this.tbLogs = new System.Windows.Forms.RichTextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gpProjeto.SuspendLayout();
            this.gpBase.SuspendLayout();
            this.gpOpcoes.SuspendLayout();
            this.gpLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.howtoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // howtoToolStripMenuItem
            // 
            this.howtoToolStripMenuItem.Name = "howtoToolStripMenuItem";
            this.howtoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.howtoToolStripMenuItem.Text = "Howto";
            // 
            // gpProjeto
            // 
            this.gpProjeto.Controls.Add(this.cbProjeto);
            this.gpProjeto.Location = new System.Drawing.Point(13, 28);
            this.gpProjeto.Name = "gpProjeto";
            this.gpProjeto.Size = new System.Drawing.Size(293, 54);
            this.gpProjeto.TabIndex = 2;
            this.gpProjeto.TabStop = false;
            this.gpProjeto.Text = "Projeto";
            // 
            // cbProjeto
            // 
            this.cbProjeto.FormattingEnabled = true;
            this.cbProjeto.Location = new System.Drawing.Point(7, 20);
            this.cbProjeto.Name = "cbProjeto";
            this.cbProjeto.Size = new System.Drawing.Size(280, 21);
            this.cbProjeto.TabIndex = 0;
            this.cbProjeto.Enter += new System.EventHandler(this.cbProjeto_Enter);
            // 
            // gpBase
            // 
            this.gpBase.Controls.Add(this.rbHml);
            this.gpBase.Controls.Add(this.rbDev);
            this.gpBase.Location = new System.Drawing.Point(13, 88);
            this.gpBase.Name = "gpBase";
            this.gpBase.Size = new System.Drawing.Size(149, 115);
            this.gpBase.TabIndex = 3;
            this.gpBase.TabStop = false;
            this.gpBase.Text = "Base";
            // 
            // rbHml
            // 
            this.rbHml.AutoSize = true;
            this.rbHml.Location = new System.Drawing.Point(15, 69);
            this.rbHml.Name = "rbHml";
            this.rbHml.Size = new System.Drawing.Size(91, 17);
            this.rbHml.TabIndex = 1;
            this.rbHml.TabStop = true;
            this.rbHml.Text = "Homologação";
            this.rbHml.UseVisualStyleBackColor = true;
            // 
            // rbDev
            // 
            this.rbDev.AutoSize = true;
            this.rbDev.Location = new System.Drawing.Point(16, 35);
            this.rbDev.Name = "rbDev";
            this.rbDev.Size = new System.Drawing.Size(107, 17);
            this.rbDev.TabIndex = 0;
            this.rbDev.TabStop = true;
            this.rbDev.Text = "Desenvolvimento";
            this.rbDev.UseVisualStyleBackColor = true;
            // 
            // gpOpcoes
            // 
            this.gpOpcoes.Controls.Add(this.cbCopJobs);
            this.gpOpcoes.Controls.Add(this.cbPubServices);
            this.gpOpcoes.Controls.Add(this.cbCompProjeto);
            this.gpOpcoes.Location = new System.Drawing.Point(174, 88);
            this.gpOpcoes.Name = "gpOpcoes";
            this.gpOpcoes.Size = new System.Drawing.Size(132, 115);
            this.gpOpcoes.TabIndex = 4;
            this.gpOpcoes.TabStop = false;
            this.gpOpcoes.Text = "Opções";
            // 
            // cbCopJobs
            // 
            this.cbCopJobs.AutoSize = true;
            this.cbCopJobs.Location = new System.Drawing.Point(13, 91);
            this.cbCopJobs.Name = "cbCopJobs";
            this.cbCopJobs.Size = new System.Drawing.Size(81, 17);
            this.cbCopJobs.TabIndex = 2;
            this.cbCopJobs.Text = "Copiar Jobs";
            this.cbCopJobs.UseVisualStyleBackColor = true;
            // 
            // cbPubServices
            // 
            this.cbPubServices.AutoSize = true;
            this.cbPubServices.Location = new System.Drawing.Point(12, 58);
            this.cbPubServices.Name = "cbPubServices";
            this.cbPubServices.Size = new System.Drawing.Size(108, 17);
            this.cbPubServices.TabIndex = 1;
            this.cbPubServices.Text = "Publicar Services";
            this.cbPubServices.UseVisualStyleBackColor = true;
            // 
            // cbCompProjeto
            // 
            this.cbCompProjeto.AutoSize = true;
            this.cbCompProjeto.Location = new System.Drawing.Point(13, 25);
            this.cbCompProjeto.Name = "cbCompProjeto";
            this.cbCompProjeto.Size = new System.Drawing.Size(101, 17);
            this.cbCompProjeto.TabIndex = 0;
            this.cbCompProjeto.Text = "Compilar projeto";
            this.cbCompProjeto.UseVisualStyleBackColor = true;
            // 
            // gpLogs
            // 
            this.gpLogs.Controls.Add(this.tbLogs);
            this.gpLogs.Location = new System.Drawing.Point(312, 28);
            this.gpLogs.Name = "gpLogs";
            this.gpLogs.Size = new System.Drawing.Size(568, 224);
            this.gpLogs.TabIndex = 5;
            this.gpLogs.TabStop = false;
            this.gpLogs.Text = "Logs";
            // 
            // tbLogs
            // 
            this.tbLogs.Enabled = false;
            this.tbLogs.Location = new System.Drawing.Point(7, 20);
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(555, 194);
            this.tbLogs.TabIndex = 0;
            this.tbLogs.Text = "";
            this.tbLogs.DoubleClick += new System.EventHandler(this.tbLogs_DoubleClick);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(214, 207);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(87, 43);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar!";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 279);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.gpLogs);
            this.Controls.Add(this.gpOpcoes);
            this.Controls.Add(this.gpBase);
            this.Controls.Add(this.gpProjeto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Ferramenta Auxiliar - Apollo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpProjeto.ResumeLayout(false);
            this.gpBase.ResumeLayout(false);
            this.gpBase.PerformLayout();
            this.gpOpcoes.ResumeLayout(false);
            this.gpOpcoes.PerformLayout();
            this.gpLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpProjeto;
        private System.Windows.Forms.ComboBox cbProjeto;
        private System.Windows.Forms.GroupBox gpBase;
        private System.Windows.Forms.RadioButton rbHml;
        private System.Windows.Forms.RadioButton rbDev;
        private System.Windows.Forms.GroupBox gpOpcoes;
        private System.Windows.Forms.GroupBox gpLogs;
        private System.Windows.Forms.CheckBox cbCopJobs;
        private System.Windows.Forms.CheckBox cbPubServices;
        private System.Windows.Forms.CheckBox cbCompProjeto;
        private System.Windows.Forms.RichTextBox tbLogs;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howtoToolStripMenuItem;
        private System.Windows.Forms.Button btnExecutar;
    }
}