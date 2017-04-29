using Zentralwerkstatt.DataSets;

namespace Zentralwerkstatt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenüLeiste = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übergabephpErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geräteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusStripText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBemerkungen = new System.Windows.Forms.TextBox();
            this.bemerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruefausgabeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetebarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpruefungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruefausgabeTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.pruefausgabeTableAdapter();
            this.testTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.testTableAdapter();
            this.lblBemerkungen = new System.Windows.Forms.Label();
            this.MenüLeiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruefausgabeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenüLeiste
            // 
            this.MenüLeiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.MenüLeiste.Location = new System.Drawing.Point(0, 0);
            this.MenüLeiste.Name = "MenüLeiste";
            this.MenüLeiste.Size = new System.Drawing.Size(1002, 24);
            this.MenüLeiste.TabIndex = 1;
            this.MenüLeiste.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übergabephpErstellenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // übergabephpErstellenToolStripMenuItem
            // 
            this.übergabephpErstellenToolStripMenuItem.Name = "übergabephpErstellenToolStripMenuItem";
            this.übergabephpErstellenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.übergabephpErstellenToolStripMenuItem.Text = "Übergabe.php erstellen";
            this.übergabephpErstellenToolStripMenuItem.Click += new System.EventHandler(this.übergabephpErstellenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem,
            this.geräteToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            this.benutzerToolStripMenuItem.Click += new System.EventHandler(this.benutzerToolStripMenuItem_Click);
            // 
            // geräteToolStripMenuItem
            // 
            this.geräteToolStripMenuItem.Name = "geräteToolStripMenuItem";
            this.geräteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.geräteToolStripMenuItem.Text = "Geräte";
            this.geräteToolStripMenuItem.Click += new System.EventHandler(this.geräteToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn,
            this.bemerkungen,
            this.geraetebarcodeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.idpruefungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(304, 619);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // StatusStripText
            // 
            this.StatusStripText.Name = "StatusStripText";
            this.StatusStripText.Size = new System.Drawing.Size(108, 17);
            this.StatusStripText.Text = "Anzahl Prüfungen: ";
            // 
            // StatusStripCount
            // 
            this.StatusStripCount.Name = "StatusStripCount";
            this.StatusStripCount.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripText,
            this.StatusStripCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.pruefausgabeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(322, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(660, 434);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            // 
            // txtBemerkungen
            // 
            this.txtBemerkungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBemerkungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBemerkungen.Location = new System.Drawing.Point(323, 483);
            this.txtBemerkungen.Multiline = true;
            this.txtBemerkungen.Name = "txtBemerkungen";
            this.txtBemerkungen.ReadOnly = true;
            this.txtBemerkungen.Size = new System.Drawing.Size(659, 163);
            this.txtBemerkungen.TabIndex = 5;
            this.txtBemerkungen.TabStop = false;
            this.txtBemerkungen.Visible = false;
            // 
            // bemerkungen
            // 
            this.bemerkungen.DataPropertyName = "bemerkungen";
            this.bemerkungen.HeaderText = "Bemerkungen";
            this.bemerkungen.Name = "bemerkungen";
            this.bemerkungen.ReadOnly = true;
            this.bemerkungen.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kriterium";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "messwert";
            this.dataGridViewTextBoxColumn2.HeaderText = "Wert";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // pruefausgabeBindingSource
            // 
            this.pruefausgabeBindingSource.DataMember = "pruefausgabe";
            this.pruefausgabeBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // geraetebarcodeDataGridViewTextBoxColumn
            // 
            this.geraetebarcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.geraetebarcodeDataGridViewTextBoxColumn.DataPropertyName = "geraete_barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn.Name = "geraetebarcodeDataGridViewTextBoxColumn";
            this.geraetebarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.geraetebarcodeDataGridViewTextBoxColumn.Width = 72;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 63;
            // 
            // idpruefungDataGridViewTextBoxColumn
            // 
            this.idpruefungDataGridViewTextBoxColumn.DataPropertyName = "idpruefung";
            this.idpruefungDataGridViewTextBoxColumn.HeaderText = "idpruefung";
            this.idpruefungDataGridViewTextBoxColumn.Name = "idpruefungDataGridViewTextBoxColumn";
            this.idpruefungDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpruefungDataGridViewTextBoxColumn.Visible = false;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.projektZDataSet;
            // 
            // pruefausgabeTableAdapter
            // 
            this.pruefausgabeTableAdapter.ClearBeforeFill = true;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // lblBemerkungen
            // 
            this.lblBemerkungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBemerkungen.AutoSize = true;
            this.lblBemerkungen.Location = new System.Drawing.Point(323, 464);
            this.lblBemerkungen.Name = "lblBemerkungen";
            this.lblBemerkungen.Size = new System.Drawing.Size(73, 13);
            this.lblBemerkungen.TabIndex = 6;
            this.lblBemerkungen.Text = "Bemerkungen";
            this.lblBemerkungen.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 688);
            this.Controls.Add(this.lblBemerkungen);
            this.Controls.Add(this.txtBemerkungen);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenüLeiste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenüLeiste;
            this.Name = "Main";
            this.Text = "Zentralwerkstatt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Close);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenüLeiste.ResumeLayout(false);
            this.MenüLeiste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruefausgabeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenüLeiste;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripText;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem übergabephpErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private DataSets.ProjektZDataSetTableAdapters.pruefausgabeTableAdapter pruefausgabeTableAdapter;
        private DataSets.ProjektZDataSetTableAdapters.testTableAdapter testTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource pruefausgabeBindingSource;
        private System.Windows.Forms.TextBox txtBemerkungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn geraetebarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpruefungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBemerkungen;
    }
}