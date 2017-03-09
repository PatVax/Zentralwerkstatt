namespace Zentralwerkstatt
{
    partial class Zentralverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zentralverwaltung));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.benutzernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDB = new Zentralwerkstatt.ProjektZDB();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangeUserDataButton = new System.Windows.Forms.Button();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.benutzerTableAdapter = new Zentralwerkstatt.ProjektZDBTableAdapters.benutzerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.benutzernameDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.benutzerBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(103, 392);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // benutzernameDataGridViewTextBoxColumn
            // 
            this.benutzernameDataGridViewTextBoxColumn.DataPropertyName = "Benutzername";
            this.benutzernameDataGridViewTextBoxColumn.HeaderText = "Benutzername";
            this.benutzernameDataGridViewTextBoxColumn.Name = "benutzernameDataGridViewTextBoxColumn";
            // 
            // benutzerBindingSource
            // 
            this.benutzerBindingSource.DataMember = "benutzer";
            this.benutzerBindingSource.DataSource = this.projektZDB;
            // 
            // projektZDB
            // 
            this.projektZDB.DataSetName = "ProjektZDB";
            this.projektZDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(12, 410);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(103, 23);
            this.AddUserButton.TabIndex = 3;
            this.AddUserButton.Text = "Neuer Benutzer";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // ChangeUserDataButton
            // 
            this.ChangeUserDataButton.Location = new System.Drawing.Point(227, 410);
            this.ChangeUserDataButton.Name = "ChangeUserDataButton";
            this.ChangeUserDataButton.Size = new System.Drawing.Size(126, 23);
            this.ChangeUserDataButton.TabIndex = 4;
            this.ChangeUserDataButton.Text = "Benutzerdaten ändern";
            this.ChangeUserDataButton.UseVisualStyleBackColor = true;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Location = new System.Drawing.Point(121, 410);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveUserButton.TabIndex = 5;
            this.RemoveUserButton.Text = "Benutzer löschen";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            // 
            // benutzerTableAdapter
            // 
            this.benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // Zentralverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 439);
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.ChangeUserDataButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zentralverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Zentralverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangeUserDataButton;
        private System.Windows.Forms.Button RemoveUserButton;
        private ProjektZDB projektZDB;
        private System.Windows.Forms.BindingSource benutzerBindingSource;
        private ProjektZDBTableAdapters.benutzerTableAdapter benutzerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzernameDataGridViewTextBoxColumn;
    }
}

