namespace DevHelper
{
    partial class FormConfiguracoes
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
            this.gbPasta = new System.Windows.Forms.GroupBox();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblDev = new System.Windows.Forms.Label();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.lblHomolog = new System.Windows.Forms.Label();
            this.txtHomolog = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbIis = new System.Windows.Forms.GroupBox();
            this.txtIis = new System.Windows.Forms.TextBox();
            this.gbMSBuild = new System.Windows.Forms.GroupBox();
            this.txtMSBuild = new System.Windows.Forms.TextBox();
            this.gbPasta.SuspendLayout();
            this.gbConnection.SuspendLayout();
            this.gbIis.SuspendLayout();
            this.gbMSBuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPasta
            // 
            this.gbPasta.Controls.Add(this.txtPasta);
            this.gbPasta.Location = new System.Drawing.Point(13, 12);
            this.gbPasta.Name = "gbPasta";
            this.gbPasta.Size = new System.Drawing.Size(493, 50);
            this.gbPasta.TabIndex = 0;
            this.gbPasta.TabStop = false;
            this.gbPasta.Text = "Pasta Projeto";
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(10, 19);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(477, 20);
            this.txtPasta.TabIndex = 0;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblDev);
            this.gbConnection.Controls.Add(this.txtDev);
            this.gbConnection.Controls.Add(this.lblHomolog);
            this.gbConnection.Controls.Add(this.txtHomolog);
            this.gbConnection.Location = new System.Drawing.Point(13, 188);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(493, 202);
            this.gbConnection.TabIndex = 1;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "ConnectionString";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(7, 111);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(89, 13);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Desenvolvimento";
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(7, 127);
            this.txtDev.Multiline = true;
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(480, 69);
            this.txtDev.TabIndex = 2;
            // 
            // lblHomolog
            // 
            this.lblHomolog.AutoSize = true;
            this.lblHomolog.Location = new System.Drawing.Point(7, 20);
            this.lblHomolog.Name = "lblHomolog";
            this.lblHomolog.Size = new System.Drawing.Size(73, 13);
            this.lblHomolog.TabIndex = 1;
            this.lblHomolog.Text = "Homologação";
            // 
            // txtHomolog
            // 
            this.txtHomolog.Location = new System.Drawing.Point(7, 36);
            this.txtHomolog.Multiline = true;
            this.txtHomolog.Name = "txtHomolog";
            this.txtHomolog.Size = new System.Drawing.Size(480, 72);
            this.txtHomolog.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(209, 396);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbIis
            // 
            this.gbIis.Controls.Add(this.txtIis);
            this.gbIis.Location = new System.Drawing.Point(13, 68);
            this.gbIis.Name = "gbIis";
            this.gbIis.Size = new System.Drawing.Size(493, 54);
            this.gbIis.TabIndex = 1;
            this.gbIis.TabStop = false;
            this.gbIis.Text = "Pasta IIS";
            // 
            // txtIis
            // 
            this.txtIis.Location = new System.Drawing.Point(10, 21);
            this.txtIis.Name = "txtIis";
            this.txtIis.Size = new System.Drawing.Size(477, 20);
            this.txtIis.TabIndex = 0;
            // 
            // gbMSBuild
            // 
            this.gbMSBuild.Controls.Add(this.txtMSBuild);
            this.gbMSBuild.Location = new System.Drawing.Point(13, 128);
            this.gbMSBuild.Name = "gbMSBuild";
            this.gbMSBuild.Size = new System.Drawing.Size(493, 54);
            this.gbMSBuild.TabIndex = 2;
            this.gbMSBuild.TabStop = false;
            this.gbMSBuild.Text = "Pasta MSBuild";
            // 
            // txtMSBuild
            // 
            this.txtMSBuild.Location = new System.Drawing.Point(10, 21);
            this.txtMSBuild.Name = "txtMSBuild";
            this.txtMSBuild.Size = new System.Drawing.Size(477, 20);
            this.txtMSBuild.TabIndex = 0;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 434);
            this.Controls.Add(this.gbMSBuild);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.gbIis);
            this.Controls.Add(this.gbPasta);
            this.Name = "FormConfiguracoes";
            this.Text = "Configurações";
            this.gbPasta.ResumeLayout(false);
            this.gbPasta.PerformLayout();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbIis.ResumeLayout(false);
            this.gbIis.PerformLayout();
            this.gbMSBuild.ResumeLayout(false);
            this.gbMSBuild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPasta;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Label lblHomolog;
        private System.Windows.Forms.TextBox txtHomolog;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbIis;
        private System.Windows.Forms.TextBox txtIis;
        private System.Windows.Forms.GroupBox gbMSBuild;
        private System.Windows.Forms.TextBox txtMSBuild;
    }
}