namespace Zentralwerkstatt
{
    partial class NeuerBenutzer
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
            this.lblPasswort = new System.Windows.Forms.Label();
            this.txtBenutzer = new System.Windows.Forms.TextBox();
            this.btnBenutzerHinzufuegen = new System.Windows.Forms.Button();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.lblBenutzer = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(31, 64);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(53, 13);
            this.lblPasswort.TabIndex = 0;
            this.lblPasswort.Text = "Passwort:";
            // 
            // txtBenutzer
            // 
            this.txtBenutzer.Location = new System.Drawing.Point(90, 35);
            this.txtBenutzer.Name = "txtBenutzer";
            this.txtBenutzer.Size = new System.Drawing.Size(100, 20);
            this.txtBenutzer.TabIndex = 2;
            // 
            // btnBenutzerHinzufuegen
            // 
            this.btnBenutzerHinzufuegen.Location = new System.Drawing.Point(17, 136);
            this.btnBenutzerHinzufuegen.Name = "btnBenutzerHinzufuegen";
            this.btnBenutzerHinzufuegen.Size = new System.Drawing.Size(100, 23);
            this.btnBenutzerHinzufuegen.TabIndex = 6;
            this.btnBenutzerHinzufuegen.Text = "Hinzufügen";
            this.btnBenutzerHinzufuegen.UseVisualStyleBackColor = true;
            this.btnBenutzerHinzufuegen.Click += new System.EventHandler(this.BtnBenutzerHinzufuegen_Click);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(90, 61);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '●';
            this.txtPasswort.Size = new System.Drawing.Size(100, 20);
            this.txtPasswort.TabIndex = 3;
            // 
            // lblBenutzer
            // 
            this.lblBenutzer.AutoSize = true;
            this.lblBenutzer.Location = new System.Drawing.Point(32, 38);
            this.lblBenutzer.Name = "lblBenutzer";
            this.lblBenutzer.Size = new System.Drawing.Size(52, 13);
            this.lblBenutzer.TabIndex = 3;
            this.lblBenutzer.Text = "Benutzer:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(17, 113);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(86, 17);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "Administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(174, 136);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(100, 23);
            this.btnAbbrechen.TabIndex = 7;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(14, 90);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(70, 13);
            this.lblRepeatPassword.TabIndex = 6;
            this.lblRepeatPassword.Text = "Wiederholen:";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(90, 87);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '●';
            this.txtRepeatPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatPassword.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // NeuerBenutzer
            // 
            this.AcceptButton = this.btnBenutzerHinzufuegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbrechen;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.lblBenutzer);
            this.Controls.Add(this.btnBenutzerHinzufuegen);
            this.Controls.Add(this.txtBenutzer);
            this.Controls.Add(this.lblPasswort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NeuerBenutzer";
            this.Text = "NeuerBenutzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox txtBenutzer;
        private System.Windows.Forms.Button btnBenutzerHinzufuegen;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label lblBenutzer;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}