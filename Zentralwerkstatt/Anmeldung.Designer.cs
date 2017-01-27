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
            this.label1 = new System.Windows.Forms.Label();
            this.BenutzerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswortTextBox = new System.Windows.Forms.TextBox();
            this.AnmeldenButton = new System.Windows.Forms.Button();
            this.AbbrechenButton = new System.Windows.Forms.Button();
            this.PasswortText = new System.Windows.Forms.Label();
            this.AdminText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzer";
            // 
            // BenutzerTextBox
            // 
            this.BenutzerTextBox.Location = new System.Drawing.Point(97, 59);
            this.BenutzerTextBox.Name = "BenutzerTextBox";
            this.BenutzerTextBox.Size = new System.Drawing.Size(192, 20);
            this.BenutzerTextBox.TabIndex = 1;
            this.BenutzerTextBox.TextChanged += new System.EventHandler(this.PasswortTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passwort";
            // 
            // PasswortTextBox
            // 
            this.PasswortTextBox.Location = new System.Drawing.Point(97, 112);
            this.PasswortTextBox.Name = "PasswortTextBox";
            this.PasswortTextBox.PasswordChar = '●';
            this.PasswortTextBox.Size = new System.Drawing.Size(192, 20);
            this.PasswortTextBox.TabIndex = 3;
            this.PasswortTextBox.TextChanged += new System.EventHandler(this.PasswortTextBox_TextChanged);
            this.PasswortTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswortTextBox_KeyDown);
            // 
            // AnmeldenButton
            // 
            this.AnmeldenButton.Location = new System.Drawing.Point(45, 154);
            this.AnmeldenButton.Name = "AnmeldenButton";
            this.AnmeldenButton.Size = new System.Drawing.Size(99, 23);
            this.AnmeldenButton.TabIndex = 4;
            this.AnmeldenButton.Text = "Anmelden";
            this.AnmeldenButton.UseVisualStyleBackColor = true;
            this.AnmeldenButton.Click += new System.EventHandler(this.AnmeldenButton_Click);
            // 
            // AbbrechenButton
            // 
            this.AbbrechenButton.Location = new System.Drawing.Point(195, 154);
            this.AbbrechenButton.Name = "AbbrechenButton";
            this.AbbrechenButton.Size = new System.Drawing.Size(94, 23);
            this.AbbrechenButton.TabIndex = 5;
            this.AbbrechenButton.Text = "Abbrechen";
            this.AbbrechenButton.UseVisualStyleBackColor = true;
            this.AbbrechenButton.Click += new System.EventHandler(this.AbbrechenButton_Click);
            // 
            // PasswortText
            // 
            this.PasswortText.AutoSize = true;
            this.PasswortText.ForeColor = System.Drawing.Color.Red;
            this.PasswortText.Location = new System.Drawing.Point(94, 27);
            this.PasswortText.Name = "PasswortText";
            this.PasswortText.Size = new System.Drawing.Size(179, 13);
            this.PasswortText.TabIndex = 6;
            this.PasswortText.Text = "Benutzername oder Passwort falsch!";
            this.PasswortText.Visible = false;
            // 
            // AdminText
            // 
            this.AdminText.AutoSize = true;
            this.AdminText.ForeColor = System.Drawing.Color.Red;
            this.AdminText.Location = new System.Drawing.Point(94, 27);
            this.AdminText.Name = "AdminText";
            this.AdminText.Size = new System.Drawing.Size(132, 13);
            this.AdminText.TabIndex = 7;
            this.AdminText.Text = "Fehlende Berechtigungen!";
            this.AdminText.Visible = false;
            // 
            // Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 199);
            this.Controls.Add(this.AdminText);
            this.Controls.Add(this.PasswortText);
            this.Controls.Add(this.AbbrechenButton);
            this.Controls.Add(this.AnmeldenButton);
            this.Controls.Add(this.PasswortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BenutzerTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anmeldung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BenutzerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswortTextBox;
        private System.Windows.Forms.Button AnmeldenButton;
        private System.Windows.Forms.Button AbbrechenButton;
        private System.Windows.Forms.Label PasswortText;
        private System.Windows.Forms.Label AdminText;
    }
}