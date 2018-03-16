namespace Zentralwerkstatt
{
    partial class Anmeldung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anmeldung));
            this.lblBenutzer = new System.Windows.Forms.Label();
            this.txtBenutzer = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.lblWrongPasswordText = new System.Windows.Forms.Label();
            this.lblAdminErrorText = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBenutzer
            // 
            this.lblBenutzer.AutoSize = true;
            this.lblBenutzer.Location = new System.Drawing.Point(42, 62);
            this.lblBenutzer.Name = "lblBenutzer";
            this.lblBenutzer.Size = new System.Drawing.Size(49, 13);
            this.lblBenutzer.TabIndex = 0;
            this.lblBenutzer.Text = "Benutzer";
            // 
            // txtBenutzer
            // 
            this.txtBenutzer.Location = new System.Drawing.Point(97, 59);
            this.txtBenutzer.Name = "txtBenutzer";
            this.txtBenutzer.Size = new System.Drawing.Size(192, 20);
            this.txtBenutzer.TabIndex = 1;
            this.txtBenutzer.TextChanged += new System.EventHandler(this.TxtPasswort_TextChanged);
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(42, 115);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(50, 13);
            this.lblPasswort.TabIndex = 2;
            this.lblPasswort.Text = "Passwort";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(97, 112);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '●';
            this.txtPasswort.Size = new System.Drawing.Size(192, 20);
            this.txtPasswort.TabIndex = 3;
            this.txtPasswort.TextChanged += new System.EventHandler(this.TxtPasswort_TextChanged);
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(45, 154);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(99, 23);
            this.btnAnmelden.TabIndex = 4;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.BtnAnmelden_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(195, 154);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(94, 23);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // lblWrongPasswordText
            // 
            this.lblWrongPasswordText.AutoSize = true;
            this.lblWrongPasswordText.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPasswordText.Location = new System.Drawing.Point(94, 27);
            this.lblWrongPasswordText.Name = "lblWrongPasswordText";
            this.lblWrongPasswordText.Size = new System.Drawing.Size(179, 13);
            this.lblWrongPasswordText.TabIndex = 6;
            this.lblWrongPasswordText.Text = "Benutzername oder Passwort falsch!";
            this.lblWrongPasswordText.Visible = false;
            // 
            // lblAdminErrorText
            // 
            this.lblAdminErrorText.AutoSize = true;
            this.lblAdminErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblAdminErrorText.Location = new System.Drawing.Point(94, 27);
            this.lblAdminErrorText.Name = "lblAdminErrorText";
            this.lblAdminErrorText.Size = new System.Drawing.Size(132, 13);
            this.lblAdminErrorText.TabIndex = 7;
            this.lblAdminErrorText.Text = "Fehlende Berechtigungen!";
            this.lblAdminErrorText.Visible = false;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(248, 189);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 34);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.Text = "Verbindung ändern";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // Anmeldung
            // 
            this.AcceptButton = this.btnAnmelden;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbrechen;
            this.ClientSize = new System.Drawing.Size(335, 235);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lblAdminErrorText);
            this.Controls.Add(this.lblWrongPasswordText);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.txtBenutzer);
            this.Controls.Add(this.lblBenutzer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anmeldung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.Shown += new System.EventHandler(this.Anmeldung_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBenutzer;
        private System.Windows.Forms.TextBox txtBenutzer;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label lblWrongPasswordText;
        private System.Windows.Forms.Label lblAdminErrorText;
        private System.Windows.Forms.Button btnConnection;
    }
}