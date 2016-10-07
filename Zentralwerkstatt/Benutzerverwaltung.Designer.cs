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
            this.Übernehmen = new System.Windows.Forms.Button();
            this.ProjectZDatabase = new Zentralwerkstatt.projektzDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDBenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benutzernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatabaseConnection = new System.Windows.Forms.BindingSource(this.components);
            this.benutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benutzerTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.benutzerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectZDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Übernehmen
            // 
            this.Übernehmen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Übernehmen.Location = new System.Drawing.Point(219, 410);
            this.Übernehmen.Name = "Übernehmen";
            this.Übernehmen.Size = new System.Drawing.Size(96, 23);
            this.Übernehmen.TabIndex = 1;
            this.Übernehmen.Text = "Übernehmen";
            this.Übernehmen.UseVisualStyleBackColor = true;
            this.Übernehmen.Click += new System.EventHandler(this.Übernehmen_Click);
            // 
            // ProjectZDatabase
            // 
            this.ProjectZDatabase.CaseSensitive = true;
            this.ProjectZDatabase.DataSetName = "projektzDataSet";
            this.ProjectZDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBenutzer,
            this.benutzernameDataGridViewTextBoxColumn,
            this.passwortDataGridViewTextBoxColumn,
            this.administratorDataGridViewCheckBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.benutzerBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(303, 392);
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
            // passwortDataGridViewTextBoxColumn
            // 
            this.passwortDataGridViewTextBoxColumn.DataPropertyName = "Passwort";
            this.passwortDataGridViewTextBoxColumn.HeaderText = "Passwort";
            this.passwortDataGridViewTextBoxColumn.Name = "passwortDataGridViewTextBoxColumn";
            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "Administrator";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "Administrator";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            // 
            // DatabaseConnection
            // 
            this.DatabaseConnection.DataMember = "benutzer";
            this.DatabaseConnection.DataSource = this.ProjectZDatabase;
            // 
            // benutzerBindingSource
            // 
            this.benutzerBindingSource.DataMember = "benutzer";
            this.benutzerBindingSource.DataSource = this.ProjectZDatabase;
            // 
            // benutzerTableAdapter
            // 
            this.benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // Zentralverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Übernehmen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zentralverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectZDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Übernehmen;
        private System.Windows.Forms.BindingSource DatabaseConnection;
        private projektzDataSet ProjectZDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBenutzer;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource benutzerBindingSource;
        private projektzDataSetTableAdapters.benutzerTableAdapter benutzerTableAdapter;
    }
}

