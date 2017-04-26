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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetetypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new ProjektZDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrueflisteBearbeiten = new System.Windows.Forms.Button();
            this.btnGeraetEntfernen = new System.Windows.Forms.Button();
            this.btnGeraetHinzufuegen = new System.Windows.Forms.Button();
            this.btnGeraetetypHinzufuegen = new System.Windows.Forms.Button();
            this.AktualisierenGeräte = new System.Windows.Forms.Button();
            this.geraetetypenTableAdapter = new DataSets.ProjektZDataSetTableAdapters.geraetetypenTableAdapter();
            this.barcodesTableAdapter = new DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).BeginInit();
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
            this.bezeichnungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.geraetetypenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(103, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.seriennummer,
            this.hersteller,
            this.anschaffungsdatum});
            this.dataGridView2.DataSource = this.barcodesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(121, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(573, 456);
            this.dataGridView2.TabIndex = 1;
            // 
            // barcodesBindingSource
            // 
            this.barcodesBindingSource.DataMember = "barcodes";
            this.barcodesBindingSource.DataSource = this.projektZDataSet;
            // 
            // btnPrueflisteBearbeiten
            // 
            this.btnPrueflisteBearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrueflisteBearbeiten.Location = new System.Drawing.Point(700, 99);
            this.btnPrueflisteBearbeiten.Name = "btnPrueflisteBearbeiten";
            this.btnPrueflisteBearbeiten.Size = new System.Drawing.Size(136, 23);
            this.btnPrueflisteBearbeiten.TabIndex = 2;
            this.btnPrueflisteBearbeiten.Text = "Prüfliste bearbeiten";
            this.btnPrueflisteBearbeiten.UseVisualStyleBackColor = true;
            this.btnPrueflisteBearbeiten.Click += new System.EventHandler(this.btnPrueflisteBearbeiten_Click);
            // 
            // btnGeraetEntfernen
            // 
            this.btnGeraetEntfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeraetEntfernen.Location = new System.Drawing.Point(700, 70);
            this.btnGeraetEntfernen.Name = "btnGeraetEntfernen";
            this.btnGeraetEntfernen.Size = new System.Drawing.Size(136, 23);
            this.btnGeraetEntfernen.TabIndex = 3;
            this.btnGeraetEntfernen.Text = "Gerät entfernen";
            this.btnGeraetEntfernen.UseVisualStyleBackColor = true;
            this.btnGeraetEntfernen.Click += new System.EventHandler(this.btnGeraetEntfernen_Click);
            // 
            // btnGeraetHinzufuegen
            // 
            this.btnGeraetHinzufuegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeraetHinzufuegen.Location = new System.Drawing.Point(700, 41);
            this.btnGeraetHinzufuegen.Name = "btnGeraetHinzufuegen";
            this.btnGeraetHinzufuegen.Size = new System.Drawing.Size(136, 23);
            this.btnGeraetHinzufuegen.TabIndex = 4;
            this.btnGeraetHinzufuegen.Text = "Gerät hinzufügen";
            this.btnGeraetHinzufuegen.UseVisualStyleBackColor = true;
            this.btnGeraetHinzufuegen.Click += new System.EventHandler(this.btnGeraeteHinzufuegen_Click);
            // 
            // btnGeraetetypHinzufuegen
            // 
            this.btnGeraetetypHinzufuegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeraetetypHinzufuegen.Location = new System.Drawing.Point(700, 12);
            this.btnGeraetetypHinzufuegen.Name = "btnGeraetetypHinzufuegen";
            this.btnGeraetetypHinzufuegen.Size = new System.Drawing.Size(136, 23);
            this.btnGeraetetypHinzufuegen.TabIndex = 5;
            this.btnGeraetetypHinzufuegen.Text = "Gerätetypen hinzufügen";
            this.btnGeraetetypHinzufuegen.UseVisualStyleBackColor = true;
            this.btnGeraetetypHinzufuegen.Click += new System.EventHandler(this.btnGeraetetypHinzufuegen_Click);
            // 
            // AktualisierenGeräte
            // 
            this.AktualisierenGeräte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AktualisierenGeräte.Location = new System.Drawing.Point(700, 128);
            this.AktualisierenGeräte.Name = "AktualisierenGeräte";
            this.AktualisierenGeräte.Size = new System.Drawing.Size(134, 23);
            this.AktualisierenGeräte.TabIndex = 6;
            this.AktualisierenGeräte.Text = "Aktualisieren";
            this.AktualisierenGeräte.UseVisualStyleBackColor = true;
            this.AktualisierenGeräte.Click += new System.EventHandler(this.AktualisierenGeraete_Click);
            // 
            // geraetetypenTableAdapter
            // 
            this.geraetetypenTableAdapter.ClearBeforeFill = true;
            // 
            // barcodesTableAdapter
            // 
            this.barcodesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "geraete_barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // seriennummer
            // 
            this.seriennummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.seriennummer.DataPropertyName = "seriennummer";
            this.seriennummer.HeaderText = "Seriennummer";
            this.seriennummer.Name = "seriennummer";
            this.seriennummer.ReadOnly = true;
            this.seriennummer.Width = 99;
            // 
            // hersteller
            // 
            this.hersteller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hersteller.DataPropertyName = "hersteller";
            this.hersteller.HeaderText = "Hersteller";
            this.hersteller.Name = "hersteller";
            this.hersteller.ReadOnly = true;
            this.hersteller.Width = 76;
            // 
            // anschaffungsdatum
            // 
            this.anschaffungsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.anschaffungsdatum.DataPropertyName = "anschaffungsdatum";
            this.anschaffungsdatum.HeaderText = "Anschaffungsdatum";
            this.anschaffungsdatum.Name = "anschaffungsdatum";
            this.anschaffungsdatum.ReadOnly = true;
            this.anschaffungsdatum.Width = 126;
            // 
            // Geraeteverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.AktualisierenGeräte);
            this.Controls.Add(this.btnGeraetetypHinzufuegen);
            this.Controls.Add(this.btnGeraetHinzufuegen);
            this.Controls.Add(this.btnGeraetEntfernen);
            this.Controls.Add(this.btnPrueflisteBearbeiten);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Geraeteverwaltung";
            this.Text = "Geräteverwaltung";
            this.Load += new System.EventHandler(this.Geraeteverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geraetetypenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPrueflisteBearbeiten;
        private System.Windows.Forms.Button btnGeraetEntfernen;
        private System.Windows.Forms.Button btnGeraetHinzufuegen;
        private System.Windows.Forms.Button btnGeraetetypHinzufuegen;
        private System.Windows.Forms.Button AktualisierenGeräte;
        private DataSets.ProjektZDataSetTableAdapters.geraetetypenTableAdapter geraetetypenTableAdapter;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapter barcodesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource geraetetypenBindingSource;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource barcodesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn hersteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatum;
    }
}