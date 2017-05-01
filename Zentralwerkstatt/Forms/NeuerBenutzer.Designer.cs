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
            this.Passwort = new System.Windows.Forms.Label();
            this.BenutzertextBox = new System.Windows.Forms.TextBox();
            this.BenutzerHinzufügen = new System.Windows.Forms.Button();
            this.PassworttextBox = new System.Windows.Forms.TextBox();
            this.Benutzer = new System.Windows.Forms.Label();
            this.AdminCheckbox = new System.Windows.Forms.CheckBox();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passwort
            // 
            this.Passwort.AutoSize = true;
            this.Passwort.Location = new System.Drawing.Point(12, 35);
            this.Passwort.Name = "Passwort";
            this.Passwort.Size = new System.Drawing.Size(53, 13);
            this.Passwort.TabIndex = 0;
            this.Passwort.Text = "Passwort:";
            // 
            // BenutzertextBox
            // 
            this.BenutzertextBox.Location = new System.Drawing.Point(71, 6);
            this.BenutzertextBox.Name = "BenutzertextBox";
            this.BenutzertextBox.Size = new System.Drawing.Size(100, 20);
            this.BenutzertextBox.TabIndex = 1;
            // 
            // BenutzerHinzufügen
            // 
            this.BenutzerHinzufügen.Location = new System.Drawing.Point(15, 226);
            this.BenutzerHinzufügen.Name = "BenutzerHinzufügen";
            this.BenutzerHinzufügen.Size = new System.Drawing.Size(100, 23);
            this.BenutzerHinzufügen.TabIndex = 4;
            this.BenutzerHinzufügen.Text = "Hinzufügen";
            this.BenutzerHinzufügen.UseVisualStyleBackColor = true;
            this.BenutzerHinzufügen.Click += new System.EventHandler(this.BenutzerHinzufügen_Click);
            // 
            // PassworttextBox
            // 
            this.PassworttextBox.Location = new System.Drawing.Point(71, 32);
            this.PassworttextBox.Name = "PassworttextBox";
            this.PassworttextBox.Size = new System.Drawing.Size(100, 20);
            this.PassworttextBox.TabIndex = 2;
            // 
            // Benutzer
            // 
            this.Benutzer.AutoSize = true;
            this.Benutzer.Location = new System.Drawing.Point(13, 9);
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.Size = new System.Drawing.Size(52, 13);
            this.Benutzer.TabIndex = 3;
            this.Benutzer.Text = "Benutzer:";
            // 
            // AdminCheckbox
            // 
            this.AdminCheckbox.AutoSize = true;
            this.AdminCheckbox.Location = new System.Drawing.Point(16, 58);
            this.AdminCheckbox.Name = "AdminCheckbox";
            this.AdminCheckbox.Size = new System.Drawing.Size(86, 17);
            this.AdminCheckbox.TabIndex = 3;
            this.AdminCheckbox.Text = "Administrator";
            this.AdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbrechen.Location = new System.Drawing.Point(172, 226);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(100, 23);
            this.buttonAbbrechen.TabIndex = 5;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // NeuerBenutzer
            // 
            this.AcceptButton = this.BenutzerHinzufügen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAbbrechen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.AdminCheckbox);
            this.Controls.Add(this.PassworttextBox);
            this.Controls.Add(this.Benutzer);
            this.Controls.Add(this.BenutzerHinzufügen);
            this.Controls.Add(this.BenutzertextBox);
            this.Controls.Add(this.Passwort);
            this.Name = "NeuerBenutzer";
            this.Text = "NeuerBenutzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Passwort;
        private System.Windows.Forms.TextBox BenutzertextBox;
        private System.Windows.Forms.Button BenutzerHinzufügen;
        private System.Windows.Forms.TextBox PassworttextBox;
        private System.Windows.Forms.Label Benutzer;
        private System.Windows.Forms.CheckBox AdminCheckbox;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}