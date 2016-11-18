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
            this.IDBenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benutzernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.benutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectZDatabase = new Zentralwerkstatt.projektzDataSet();
            this.DatabaseConnection = new System.Windows.Forms.BindingSource(this.components);
            this.benutzerTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.benutzerTableAdapter();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectZDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBenutzer,
            this.benutzernameDataGridViewTextBoxColumn,
            this.administratorDataGridViewCheckBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.benutzerBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(206, 392);
            this.dataGridView1.TabIndex = 2;
            // 
            // IDBenutzer
            // 
            this.IDBenutzer.DataPropertyName = "IDBenutzer";
            this.IDBenutzer.HeaderText = "IDBenutzer";
            this.IDBenutzer.Name = "IDBenutzer";
            this.IDBenutzer.Visible = false;
            // 
            // benutzernameDataGridViewTextBoxColumn
            // 
            this.benutzernameDataGridViewTextBoxColumn.DataPropertyName = "Benutzername";
            this.benutzernameDataGridViewTextBoxColumn.HeaderText = "Benutzername";
            this.benutzernameDataGridViewTextBoxColumn.Name = "benutzernameDataGridViewTextBoxColumn";
            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "Administrator";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "Administrator";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            // 
            // benutzerBindingSource
            // 
            this.benutzerBindingSource.DataMember = "benutzer";
            this.benutzerBindingSource.DataSource = this.ProjectZDatabase;
            // 
            // ProjectZDatabase
            // 
            this.ProjectZDatabase.CaseSensitive = true;
            this.ProjectZDatabase.DataSetName = "projektzDataSet";
            this.ProjectZDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatabaseConnection
            // 
            this.DatabaseConnection.DataMember = "benutzer";
            this.DatabaseConnection.DataSource = this.ProjectZDatabase;
            // 
            // benutzerTableAdapter
            // 
            this.benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(9, 410);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 23);
            this.AddUserButton.TabIndex = 3;
            this.AddUserButton.Text = "Neuer Benutzer";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(115, 410);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(100, 23);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "Passwort ändern";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Location = new System.Drawing.Point(221, 410);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveUserButton.TabIndex = 5;
            this.RemoveUserButton.Text = "Benutzer löschen";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            // 
            // Zentralverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 439);
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zentralverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectZDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DatabaseConnection;
        private projektzDataSet ProjectZDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource benutzerBindingSource;
        private projektzDataSetTableAdapters.benutzerTableAdapter benutzerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBenutzer;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button RemoveUserButton;
    }
}

