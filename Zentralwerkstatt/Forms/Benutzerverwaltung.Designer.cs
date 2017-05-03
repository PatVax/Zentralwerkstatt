using Zentralwerkstatt.DataSets;

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
            this.idbenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangeUserDataButton = new System.Windows.Forms.Button();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.Button_aktualisieren = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.benutzernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.benutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.benutzerTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.benutzerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.benutzernameDataGridViewTextBoxColumn,
            this.administratorDataGridViewCheckBoxColumn,
            this.idbenutzer});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.benutzerBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(203, 392);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // idbenutzer
            // 
            this.idbenutzer.DataPropertyName = "idbenutzer";
            this.idbenutzer.HeaderText = "idbenutzer";
            this.idbenutzer.Name = "idbenutzer";
            this.idbenutzer.Visible = false;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserButton.Location = new System.Drawing.Point(221, 12);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(126, 23);
            this.AddUserButton.TabIndex = 3;
            this.AddUserButton.Text = "Neuer Benutzer";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangeUserDataButton
            // 
            this.ChangeUserDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeUserDataButton.Location = new System.Drawing.Point(221, 41);
            this.ChangeUserDataButton.Name = "ChangeUserDataButton";
            this.ChangeUserDataButton.Size = new System.Drawing.Size(126, 23);
            this.ChangeUserDataButton.TabIndex = 4;
            this.ChangeUserDataButton.Text = "Benutzerdaten ändern";
            this.ChangeUserDataButton.UseVisualStyleBackColor = true;
            this.ChangeUserDataButton.Click += new System.EventHandler(this.ChangeUserDataButton_Click);
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveUserButton.Location = new System.Drawing.Point(221, 100);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(126, 23);
            this.RemoveUserButton.TabIndex = 6;
            this.RemoveUserButton.Text = "Benutzer löschen";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // Button_aktualisieren
            // 
            this.Button_aktualisieren.Location = new System.Drawing.Point(125, 410);
            this.Button_aktualisieren.Name = "Button_aktualisieren";
            this.Button_aktualisieren.Size = new System.Drawing.Size(75, 23);
            this.Button_aktualisieren.TabIndex = 6;
            this.Button_aktualisieren.Text = "Aktualisieren";
            this.Button_aktualisieren.UseVisualStyleBackColor = true;
            this.Button_aktualisieren.Click += new System.EventHandler(this.Button_aktualisieren_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(222, 71);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(125, 23);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Passwort ändern";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // benutzernameDataGridViewTextBoxColumn
            // 
            this.benutzernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.benutzernameDataGridViewTextBoxColumn.DataPropertyName = "benutzername";
            this.benutzernameDataGridViewTextBoxColumn.HeaderText = "Benutzer";
            this.benutzernameDataGridViewTextBoxColumn.Name = "benutzernameDataGridViewTextBoxColumn";
            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "administrator";
            this.administratorDataGridViewCheckBoxColumn.FalseValue = "0";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            this.administratorDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.administratorDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.administratorDataGridViewCheckBoxColumn.TrueValue = "1";
            this.administratorDataGridViewCheckBoxColumn.Width = 61;
            // 
            // benutzerBindingSource
            // 
            this.benutzerBindingSource.DataMember = "Benutzer";
            this.benutzerBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benutzerTableAdapter
            // 
            this.benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // Zentralverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 412);
            this.Controls.Add(this.btnChangePassword);
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
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangeUserDataButton;
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Button Button_aktualisieren;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource benutzerBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.benutzerTableAdapter benutzerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbenutzer;
        private System.Windows.Forms.Button btnChangePassword;
    }
}

