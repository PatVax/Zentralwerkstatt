namespace Zentralwerkstatt
{
    partial class Prueflistebearbeiten
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
            this.Gerätetypen = new System.Windows.Forms.DataGridView();
            this.Prüfliste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).BeginInit();
            this.SuspendLayout();
            // 
            // Gerätetypen
            // 
            this.Gerätetypen.AllowUserToAddRows = false;
            this.Gerätetypen.AllowUserToDeleteRows = false;
            this.Gerätetypen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gerätetypen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerätetypen.Location = new System.Drawing.Point(8, 12);
            this.Gerätetypen.Name = "Gerätetypen";
            this.Gerätetypen.ReadOnly = true;
            this.Gerätetypen.RowHeadersVisible = false;
            this.Gerätetypen.Size = new System.Drawing.Size(173, 557);
            this.Gerätetypen.TabIndex = 3;
            // 
            // Prüfliste
            // 
            this.Prüfliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prüfliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prüfliste.Location = new System.Drawing.Point(187, 12);
            this.Prüfliste.Name = "Prüfliste";
            this.Prüfliste.RowHeadersVisible = false;
            this.Prüfliste.Size = new System.Drawing.Size(1048, 557);
            this.Prüfliste.TabIndex = 2;
            // 
            // Prueflistebearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 581);
            this.Controls.Add(this.Gerätetypen);
            this.Controls.Add(this.Prüfliste);
            this.Name = "Prueflistebearbeiten";
            this.Text = "Prueflistebearbeiten";
            this.Load += new System.EventHandler(this.Prueflistebearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gerätetypen;
        private System.Windows.Forms.DataGridView Prüfliste;
    }
}