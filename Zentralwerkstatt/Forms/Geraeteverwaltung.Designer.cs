using Zentralwerkstatt.DataSets;

namespace Zentralwerkstatt
{
    partial class Geraeteverwaltung
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
            this.components = new System.ComponentModel.Container();
            this.geraetetypenDataGridView = new System.Windows.Forms.DataGridView();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgeraetetyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetetypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.geraeteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gerätetypÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraetToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.barcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geräteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesGerätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesGerätetypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerätetypEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prueflistenansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herstelleransichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standortenansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process1 = new System.Diagnostics.Process();
            this.geraetetypenTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.geraetetypenTableAdapter();
            this.barcodesTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapter();
            this.herstellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.TableAdapterManager();
            this.herstellerTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter();
            this.fahrzeugenansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraeteDataGridView)).BeginInit();
            this.geraetContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // geraetetypenDataGridView
            // 
            this.geraetetypenDataGridView.AllowUserToAddRows = false;
            this.geraetetypenDataGridView.AllowUserToResizeColumns = false;
            this.geraetetypenDataGridView.AllowUserToResizeRows = false;
            this.geraetetypenDataGridView.AutoGenerateColumns = false;
            this.geraetetypenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.geraetetypenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn,
            this.idgeraetetyp,
            this.idhersteller});
            this.geraetetypenDataGridView.DataSource = this.geraetetypenBindingSource;
            this.geraetetypenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geraetetypenDataGridView.Location = new System.Drawing.Point(0, 0);
            this.geraetetypenDataGridView.MultiSelect = false;
            this.geraetetypenDataGridView.Name = "geraetetypenDataGridView";
            this.geraetetypenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.geraetetypenDataGridView.Size = new System.Drawing.Size(168, 702);
            this.geraetetypenDataGridView.StandardTab = true;
            this.geraetetypenDataGridView.TabIndex = 0;
            this.geraetetypenDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.geraetetypenDataGridView_CellClick);
            this.geraetetypenDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.geraetetypenDataGridView_CellEndEdit);
            this.geraetetypenDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.geraetetypenDataGridView_UserDeletedRow);
            this.geraetetypenDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.geraetetypenDataGridView_UserDeletingRow);
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // idgeraetetyp
            // 
            this.idgeraetetyp.DataPropertyName = "idgeraetetyp";
            this.idgeraetetyp.HeaderText = "idgeraetetyp";
            this.idgeraetetyp.Name = "idgeraetetyp";
            this.idgeraetetyp.Visible = false;
            // 
            // idhersteller
            // 
            this.idhersteller.DataPropertyName = "idhersteller";
            this.idhersteller.HeaderText = "idhersteller";
            this.idhersteller.Name = "idhersteller";
            this.idhersteller.Visible = false;
            // 
            // geraetetypenBindingSource
            // 
            this.geraetetypenBindingSource.DataMember = "geraetetypen";
            this.geraetetypenBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geraeteDataGridView
            // 
            this.geraeteDataGridView.AllowUserToAddRows = false;
            this.geraeteDataGridView.AllowUserToResizeColumns = false;
            this.geraeteDataGridView.AllowUserToResizeRows = false;
            this.geraeteDataGridView.AutoGenerateColumns = false;
            this.geraeteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.geraeteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.seriennummer,
            this.hersteller,
            this.anschaffungsdatum,
            this.fahrzeug,
            this.kennzeichen,
            this.oldBarcode,
            this.dataGridViewTextBoxColumn2});
            this.geraeteDataGridView.ContextMenuStrip = this.geraetContextMenuStrip;
            this.geraeteDataGridView.DataSource = this.barcodesBindingSource;
            this.geraeteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geraeteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.geraeteDataGridView.MultiSelect = false;
            this.geraeteDataGridView.Name = "geraeteDataGridView";
            this.geraeteDataGridView.RowHeadersVisible = false;
            this.geraeteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.geraeteDataGridView.Size = new System.Drawing.Size(960, 702);
            this.geraeteDataGridView.StandardTab = true;
            this.geraeteDataGridView.TabIndex = 1;
            this.geraeteDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.geraeteDataGridView_CellBeginEdit);
            this.geraeteDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.geraeteDataGridView_CellDoubleClick);
            this.geraeteDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.geraeteDataGridView_CellEndEdit);
            this.geraeteDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.geraeteDataGridView_CellMouseDown);
            this.geraeteDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.geraeteDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "geraete_barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // seriennummer
            // 
            this.seriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.seriennummer.DataPropertyName = "seriennummer";
            this.seriennummer.HeaderText = "Seriennummer";
            this.seriennummer.Name = "seriennummer";
            this.seriennummer.Width = 99;
            // 
            // hersteller
            // 
            this.hersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hersteller.DataPropertyName = "hersteller";
            this.hersteller.HeaderText = "Hersteller";
            this.hersteller.Name = "hersteller";
            this.hersteller.ReadOnly = true;
            this.hersteller.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hersteller.Width = 76;
            // 
            // anschaffungsdatum
            // 
            this.anschaffungsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anschaffungsdatum.DataPropertyName = "anschaffungsdatum";
            this.anschaffungsdatum.HeaderText = "Anschaffungsdatum";
            this.anschaffungsdatum.Name = "anschaffungsdatum";
            this.anschaffungsdatum.ReadOnly = true;
            this.anschaffungsdatum.Width = 126;
            // 
            // fahrzeug
            // 
            this.fahrzeug.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fahrzeug.DataPropertyName = "fahrzeug";
            this.fahrzeug.HeaderText = "Fahrzeug";
            this.fahrzeug.Name = "fahrzeug";
            this.fahrzeug.ReadOnly = true;
            this.fahrzeug.Width = 76;
            // 
            // kennzeichen
            // 
            this.kennzeichen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kennzeichen.DataPropertyName = "kennzeichen";
            this.kennzeichen.HeaderText = "Kennzeichen";
            this.kennzeichen.Name = "kennzeichen";
            this.kennzeichen.ReadOnly = true;
            this.kennzeichen.Width = 94;
            // 
            // oldBarcode
            // 
            this.oldBarcode.HeaderText = "oldBarcode";
            this.oldBarcode.Name = "oldBarcode";
            this.oldBarcode.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idgeraetetyp";
            this.dataGridViewTextBoxColumn2.HeaderText = "idgeraetetyp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // geraetContextMenuStrip
            // 
            this.geraetContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerätetypÄndernToolStripMenuItem});
            this.geraetContextMenuStrip.Name = "geraetContextMenuStrip";
            this.geraetContextMenuStrip.Size = new System.Drawing.Size(166, 26);
            this.geraetContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.geraetContextMenuStrip_Opening);
            // 
            // gerätetypÄndernToolStripMenuItem
            // 
            this.gerätetypÄndernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geraetToolStripComboBox});
            this.gerätetypÄndernToolStripMenuItem.Name = "gerätetypÄndernToolStripMenuItem";
            this.gerätetypÄndernToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gerätetypÄndernToolStripMenuItem.Text = "Gerätetyp ändern";
            this.gerätetypÄndernToolStripMenuItem.DropDownOpening += new System.EventHandler(this.gerätetypÄndernToolStripMenuItem_DropDownOpening);
            // 
            // geraetToolStripComboBox
            // 
            this.geraetToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geraetToolStripComboBox.Name = "geraetToolStripComboBox";
            this.geraetToolStripComboBox.Size = new System.Drawing.Size(250, 23);
            this.geraetToolStripComboBox.DropDownClosed += new System.EventHandler(this.geraetToolStripComboBox_DropDownClosed);
            // 
            // barcodesBindingSource
            // 
            this.barcodesBindingSource.DataMember = "barcodes";
            this.barcodesBindingSource.DataSource = this.projektZDataSet;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.geraetetypenDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.geraeteDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 702);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geräteToolStripMenuItem,
            this.verwaltenToolStripMenuItem,
            this.aktualisierenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // geräteToolStripMenuItem
            // 
            this.geräteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesGerätToolStripMenuItem,
            this.neuesGerätetypToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.gerätetypEntfernenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.schließenToolStripMenuItem});
            this.geräteToolStripMenuItem.Name = "geräteToolStripMenuItem";
            this.geräteToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.geräteToolStripMenuItem.Text = "Gerät";
            // 
            // neuesGerätToolStripMenuItem
            // 
            this.neuesGerätToolStripMenuItem.Name = "neuesGerätToolStripMenuItem";
            this.neuesGerätToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.neuesGerätToolStripMenuItem.Text = "Neues Gerät";
            this.neuesGerätToolStripMenuItem.Click += new System.EventHandler(this.neuesGerätToolStripMenuItem_Click);
            // 
            // neuesGerätetypToolStripMenuItem
            // 
            this.neuesGerätetypToolStripMenuItem.Name = "neuesGerätetypToolStripMenuItem";
            this.neuesGerätetypToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.neuesGerätetypToolStripMenuItem.Text = "Neues Gerätetyp";
            this.neuesGerätetypToolStripMenuItem.Click += new System.EventHandler(this.neuesGerätetypToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.entfernenToolStripMenuItem.Text = "Gerät entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // gerätetypEntfernenToolStripMenuItem
            // 
            this.gerätetypEntfernenToolStripMenuItem.Name = "gerätetypEntfernenToolStripMenuItem";
            this.gerätetypEntfernenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gerätetypEntfernenToolStripMenuItem.Text = "Gerätetyp entfernen";
            this.gerätetypEntfernenToolStripMenuItem.Click += new System.EventHandler(this.gerätetypEntfernenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // verwaltenToolStripMenuItem
            // 
            this.verwaltenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prueflistenansichtToolStripMenuItem,
            this.herstelleransichtToolStripMenuItem,
            this.fahrzeugenansichtToolStripMenuItem,
            this.standortenansichtToolStripMenuItem});
            this.verwaltenToolStripMenuItem.Name = "verwaltenToolStripMenuItem";
            this.verwaltenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.verwaltenToolStripMenuItem.Text = "Verwalten";
            // 
            // prueflistenansichtToolStripMenuItem
            // 
            this.prueflistenansichtToolStripMenuItem.Name = "prueflistenansichtToolStripMenuItem";
            this.prueflistenansichtToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.prueflistenansichtToolStripMenuItem.Text = "Prüflistenansicht";
            this.prueflistenansichtToolStripMenuItem.Click += new System.EventHandler(this.prueflistenansichtToolStripMenuItem_Click);
            // 
            // herstelleransichtToolStripMenuItem
            // 
            this.herstelleransichtToolStripMenuItem.Name = "herstelleransichtToolStripMenuItem";
            this.herstelleransichtToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.herstelleransichtToolStripMenuItem.Text = "Herstelleransicht";
            this.herstelleransichtToolStripMenuItem.Click += new System.EventHandler(this.herstelleransichtToolStripMenuItem_Click);
            // 
            // standortenansichtToolStripMenuItem
            // 
            this.standortenansichtToolStripMenuItem.Name = "standortenansichtToolStripMenuItem";
            this.standortenansichtToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.standortenansichtToolStripMenuItem.Text = "Standortenansicht";
            this.standortenansichtToolStripMenuItem.Click += new System.EventHandler(this.StandortenansichtToolStripMenuItem_Click);
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.aktualisierenToolStripMenuItem.Text = "Aktualisieren";
            this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // geraetetypenTableAdapter
            // 
            this.geraetetypenTableAdapter.ClearBeforeFill = true;
            // 
            // barcodesTableAdapter
            // 
            this.barcodesTableAdapter.ClearBeforeFill = true;
            // 
            // herstellerBindingSource
            // 
            this.herstellerBindingSource.DataMember = "hersteller";
            this.herstellerBindingSource.DataSource = this.projektZDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.benutzerTableAdapter = null;
            this.tableAdapterManager.fahrzeugeDownTableAdapter = null;
            this.tableAdapterManager.fahrzeugeTableAdapter = null;
            this.tableAdapterManager.fahrzeugeUpTableAdapter = null;
            this.tableAdapterManager.geraeteTableAdapter = null;
            this.tableAdapterManager.geraetetypenTableAdapter = this.geraetetypenTableAdapter;
            this.tableAdapterManager.herstellerTableAdapter = this.herstellerTableAdapter;
            this.tableAdapterManager.pruefergebnisseTableAdapter = null;
            this.tableAdapterManager.pruefkriterienTableAdapter = null;
            this.tableAdapterManager.pruefungenTableAdapter = null;
            this.tableAdapterManager.standorteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // herstellerTableAdapter
            // 
            this.herstellerTableAdapter.ClearBeforeFill = true;
            // 
            // fahrzeugenansichtToolStripMenuItem
            // 
            this.fahrzeugenansichtToolStripMenuItem.Name = "fahrzeugenansichtToolStripMenuItem";
            this.fahrzeugenansichtToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fahrzeugenansichtToolStripMenuItem.Text = "Fahrzeugenansicht";
            this.fahrzeugenansichtToolStripMenuItem.Click += new System.EventHandler(this.fahrzeugenansichtToolStripMenuItem_Click_1);
            // 
            // Geraeteverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 726);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Geraeteverwaltung";
            this.Text = "Geräteverwaltung";
            this.Load += new System.EventHandler(this.Geraeteverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraeteDataGridView)).EndInit();
            this.geraetContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView geraetetypenDataGridView;
        private System.Windows.Forms.DataGridView geraeteDataGridView;
        private DataSets.ProjektZDataSetTableAdapters.geraetetypenTableAdapter geraetetypenTableAdapter;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapter barcodesTableAdapter;
        private System.Windows.Forms.BindingSource geraetetypenBindingSource;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource barcodesBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesGerätToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwaltenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herstelleransichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standortenansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prueflistenansichtToolStripMenuItem;
        private System.Windows.Forms.BindingSource herstellerBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter herstellerTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem neuesGerätetypToolStripMenuItem;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerätetypEntfernenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn hersteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeug;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichen;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip geraetContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gerätetypÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox geraetToolStripComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeraetetyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhersteller;
        private System.Windows.Forms.ToolStripMenuItem fahrzeugenansichtToolStripMenuItem;
    }
}