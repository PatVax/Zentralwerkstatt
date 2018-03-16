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
            this.benutzerDataGridView = new System.Windows.Forms.DataGridView();
            this.benutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnChangeUserData = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.benutzerTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.benutzerTableAdapter();
            this.btnAktivShow = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.benutzernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aktivDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idbenutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // benutzerDataGridView
            // 
            this.benutzerDataGridView.AllowUserToAddRows = false;
            this.benutzerDataGridView.AllowUserToDeleteRows = false;
            this.benutzerDataGridView.AllowUserToResizeColumns = false;
            this.benutzerDataGridView.AllowUserToResizeRows = false;
            this.benutzerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.benutzerDataGridView.AutoGenerateColumns = false;
            this.benutzerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benutzerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.benutzernameDataGridViewTextBoxColumn,
            this.name,
            this.administratorDataGridViewCheckBoxColumn,
            this.aktivDataGridViewCheckBoxColumn,
            this.idbenutzer});
            this.benutzerDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.benutzerDataGridView.DataSource = this.benutzerBindingSource;
            this.benutzerDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.benutzerDataGridView.Location = new System.Drawing.Point(12, 12);
            this.benutzerDataGridView.MultiSelect = false;
            this.benutzerDataGridView.Name = "benutzerDataGridView";
            this.benutzerDataGridView.RowHeadersVisible = false;
            this.benutzerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.benutzerDataGridView.Size = new System.Drawing.Size(289, 392);
            this.benutzerDataGridView.TabIndex = 2;
            this.benutzerDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.BenutzerDataGridView_DataError);
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
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(307, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(126, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Neuer Benutzer";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnChangeUserData
            // 
            this.btnChangeUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeUserData.Location = new System.Drawing.Point(307, 41);
            this.btnChangeUserData.Name = "btnChangeUserData";
            this.btnChangeUserData.Size = new System.Drawing.Size(126, 23);
            this.btnChangeUserData.TabIndex = 4;
            this.btnChangeUserData.Text = "Benutzerdaten ändern";
            this.btnChangeUserData.UseVisualStyleBackColor = true;
            this.btnChangeUserData.Click += new System.EventHandler(this.BtnChangeUserData_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUser.Location = new System.Drawing.Point(307, 100);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveUser.TabIndex = 6;
            this.btnRemoveUser.Text = "Benutzer löschen";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.Location = new System.Drawing.Point(308, 71);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(125, 23);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Passwort ändern";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // benutzerTableAdapter
            // 
            this.benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // btnAktivShow
            // 
            this.btnAktivShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktivShow.Location = new System.Drawing.Point(307, 158);
            this.btnAktivShow.Name = "btnAktivShow";
            this.btnAktivShow.Size = new System.Drawing.Size(125, 23);
            this.btnAktivShow.TabIndex = 8;
            this.btnAktivShow.Text = "Alle Benutzer anzeigen";
            this.btnAktivShow.UseVisualStyleBackColor = true;
            this.btnAktivShow.Click += new System.EventHandler(this.BtnAktivShow_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshData.Location = new System.Drawing.Point(308, 129);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(124, 23);
            this.btnRefreshData.TabIndex = 9;
            this.btnRefreshData.Text = "Aktualisieren";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.BtnRefreshData_Click);
            // 
            // benutzernameDataGridViewTextBoxColumn
            // 
            this.benutzernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.benutzernameDataGridViewTextBoxColumn.DataPropertyName = "benutzername";
            this.benutzernameDataGridViewTextBoxColumn.HeaderText = "Benutzer";
            this.benutzernameDataGridViewTextBoxColumn.Name = "benutzernameDataGridViewTextBoxColumn";
            this.benutzernameDataGridViewTextBoxColumn.Width = 74;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "administrator";
            this.administratorDataGridViewCheckBoxColumn.FalseValue = "false";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            this.administratorDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.administratorDataGridViewCheckBoxColumn.TrueValue = "true";
            this.administratorDataGridViewCheckBoxColumn.Width = 42;
            // 
            // aktivDataGridViewCheckBoxColumn
            // 
            this.aktivDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aktivDataGridViewCheckBoxColumn.DataPropertyName = "aktiv";
            this.aktivDataGridViewCheckBoxColumn.FalseValue = "false";
            this.aktivDataGridViewCheckBoxColumn.HeaderText = "Aktiv";
            this.aktivDataGridViewCheckBoxColumn.Name = "aktivDataGridViewCheckBoxColumn";
            this.aktivDataGridViewCheckBoxColumn.TrueValue = "true";
            this.aktivDataGridViewCheckBoxColumn.Width = 37;
            // 
            // idbenutzer
            // 
            this.idbenutzer.DataPropertyName = "idbenutzer";
            this.idbenutzer.HeaderText = "idbenutzer";
            this.idbenutzer.Name = "idbenutzer";
            this.idbenutzer.Visible = false;
            // 
            // Zentralverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 412);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.btnAktivShow);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnChangeUserData);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.benutzerDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zentralverwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Zentralverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benutzerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView benutzerDataGridView;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnChangeUserData;
        private System.Windows.Forms.Button btnRemoveUser;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource benutzerBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.benutzerTableAdapter benutzerTableAdapter;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAktivShow;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbenutzer;
    }
}

