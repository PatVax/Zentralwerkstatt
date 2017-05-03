using Zentralwerkstatt.DataSets;

namespace Zentralwerkstatt
{
    partial class HerstellerAdd
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
            this.dataGridViewHersteller = new System.Windows.Forms.DataGridView();
            this.idherstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.herstellerTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewUp = new System.Windows.Forms.DataGridView();
            this.bezeichnungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetebarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgeraetetyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodesUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpToDown = new System.Windows.Forms.Button();
            this.comboBoxUp = new System.Windows.Forms.ComboBox();
            this.herstellerBindingSourceUp = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewDown = new System.Windows.Forms.DataGridView();
            this.bezeichnungDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetebarcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeugDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodesDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDownToUp = new System.Windows.Forms.Button();
            this.comboBoxDown = new System.Windows.Forms.ComboBox();
            this.herstellerBindingSourceDown = new System.Windows.Forms.BindingSource(this.components);
            this.barcodesTableAdapterUp = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterUp();
            this.barcodesTableAdapterDown = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHersteller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSourceUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesDownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSourceDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHersteller
            // 
            this.dataGridViewHersteller.AllowUserToResizeColumns = false;
            this.dataGridViewHersteller.AutoGenerateColumns = false;
            this.dataGridViewHersteller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHersteller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idherstellerDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn});
            this.dataGridViewHersteller.DataSource = this.herstellerBindingSource;
            this.dataGridViewHersteller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHersteller.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHersteller.MultiSelect = false;
            this.dataGridViewHersteller.Name = "dataGridViewHersteller";
            this.dataGridViewHersteller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHersteller.Size = new System.Drawing.Size(177, 521);
            this.dataGridViewHersteller.TabIndex = 0;
            this.dataGridViewHersteller.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView_CancelRowEdit);
            this.dataGridViewHersteller.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHersteller_CellEndEdit);
            this.dataGridViewHersteller.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewHersteller_UserDeletedRow);
            this.dataGridViewHersteller.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHersteller_UserDeletingRow);
            // 
            // idherstellerDataGridViewTextBoxColumn
            // 
            this.idherstellerDataGridViewTextBoxColumn.DataPropertyName = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn.HeaderText = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn.Name = "idherstellerDataGridViewTextBoxColumn";
            this.idherstellerDataGridViewTextBoxColumn.Visible = false;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.Width = 76;
            // 
            // herstellerBindingSource
            // 
            this.herstellerBindingSource.DataMember = "Hersteller";
            this.herstellerBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herstellerTableAdapter
            // 
            this.herstellerTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewHersteller);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(886, 521);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewUp);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpToDown);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxUp);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewDown);
            this.splitContainer2.Panel2.Controls.Add(this.btnDownToUp);
            this.splitContainer2.Panel2.Controls.Add(this.comboBoxDown);
            this.splitContainer2.Size = new System.Drawing.Size(705, 521);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewUp
            // 
            this.dataGridViewUp.AllowUserToAddRows = false;
            this.dataGridViewUp.AllowUserToDeleteRows = false;
            this.dataGridViewUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUp.AutoGenerateColumns = false;
            this.dataGridViewUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn1,
            this.geraetebarcodeDataGridViewTextBoxColumn,
            this.seriennummerDataGridViewTextBoxColumn,
            this.anschaffungsdatumDataGridViewTextBoxColumn,
            this.fahrzeugDataGridViewTextBoxColumn,
            this.kennzeichenDataGridViewTextBoxColumn,
            this.idgeraetetyp});
            this.dataGridViewUp.DataSource = this.barcodesUpBindingSource;
            this.dataGridViewUp.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewUp.MultiSelect = false;
            this.dataGridViewUp.Name = "dataGridViewUp";
            this.dataGridViewUp.ReadOnly = true;
            this.dataGridViewUp.RowHeadersVisible = false;
            this.dataGridViewUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUp.Size = new System.Drawing.Size(705, 230);
            this.dataGridViewUp.TabIndex = 3;
            this.dataGridViewUp.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView_CancelRowEdit);
            this.dataGridViewUp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUp_CellDoubleClick);
            // 
            // bezeichnungDataGridViewTextBoxColumn1
            // 
            this.bezeichnungDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.Name = "bezeichnungDataGridViewTextBoxColumn1";
            this.bezeichnungDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bezeichnungDataGridViewTextBoxColumn1.Width = 94;
            // 
            // geraetebarcodeDataGridViewTextBoxColumn
            // 
            this.geraetebarcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.geraetebarcodeDataGridViewTextBoxColumn.DataPropertyName = "geraete_barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn.Name = "geraetebarcodeDataGridViewTextBoxColumn";
            this.geraetebarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.geraetebarcodeDataGridViewTextBoxColumn.Width = 72;
            // 
            // seriennummerDataGridViewTextBoxColumn
            // 
            this.seriennummerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.seriennummerDataGridViewTextBoxColumn.DataPropertyName = "seriennummer";
            this.seriennummerDataGridViewTextBoxColumn.HeaderText = "Seriennummer";
            this.seriennummerDataGridViewTextBoxColumn.Name = "seriennummerDataGridViewTextBoxColumn";
            this.seriennummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriennummerDataGridViewTextBoxColumn.Width = 99;
            // 
            // anschaffungsdatumDataGridViewTextBoxColumn
            // 
            this.anschaffungsdatumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anschaffungsdatumDataGridViewTextBoxColumn.DataPropertyName = "anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn.HeaderText = "Anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn.Name = "anschaffungsdatumDataGridViewTextBoxColumn";
            this.anschaffungsdatumDataGridViewTextBoxColumn.ReadOnly = true;
            this.anschaffungsdatumDataGridViewTextBoxColumn.Width = 126;
            // 
            // fahrzeugDataGridViewTextBoxColumn
            // 
            this.fahrzeugDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fahrzeugDataGridViewTextBoxColumn.DataPropertyName = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn.HeaderText = "Fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn.Name = "fahrzeugDataGridViewTextBoxColumn";
            this.fahrzeugDataGridViewTextBoxColumn.ReadOnly = true;
            this.fahrzeugDataGridViewTextBoxColumn.Width = 76;
            // 
            // kennzeichenDataGridViewTextBoxColumn
            // 
            this.kennzeichenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kennzeichenDataGridViewTextBoxColumn.DataPropertyName = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn.HeaderText = "Kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn.Name = "kennzeichenDataGridViewTextBoxColumn";
            this.kennzeichenDataGridViewTextBoxColumn.ReadOnly = true;
            this.kennzeichenDataGridViewTextBoxColumn.Width = 94;
            // 
            // idgeraetetyp
            // 
            this.idgeraetetyp.DataPropertyName = "idgeraetetyp";
            this.idgeraetetyp.HeaderText = "idgeraetetyp";
            this.idgeraetetyp.Name = "idgeraetetyp";
            this.idgeraetetyp.ReadOnly = true;
            this.idgeraetetyp.Visible = false;
            // 
            // barcodesUpBindingSource
            // 
            this.barcodesUpBindingSource.DataMember = "barcodesUp";
            this.barcodesUpBindingSource.DataSource = this.projektZDataSet;
            // 
            // btnUpToDown
            // 
            this.btnUpToDown.Location = new System.Drawing.Point(206, 4);
            this.btnUpToDown.Name = "btnUpToDown";
            this.btnUpToDown.Size = new System.Drawing.Size(136, 21);
            this.btnUpToDown.TabIndex = 3;
            this.btnUpToDown.Text = "Nach unten verschieben";
            this.btnUpToDown.UseVisualStyleBackColor = true;
            this.btnUpToDown.Click += new System.EventHandler(this.move);
            // 
            // comboBoxUp
            // 
            this.comboBoxUp.DataSource = this.herstellerBindingSourceUp;
            this.comboBoxUp.DisplayMember = "bezeichnung";
            this.comboBoxUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUp.FormattingEnabled = true;
            this.comboBoxUp.Location = new System.Drawing.Point(3, 4);
            this.comboBoxUp.Name = "comboBoxUp";
            this.comboBoxUp.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUp.TabIndex = 0;
            this.comboBoxUp.ValueMember = "idhersteller";
            this.comboBoxUp.SelectedIndexChanged += new System.EventHandler(this.refreshBarcodeTables);
            // 
            // herstellerBindingSourceUp
            // 
            this.herstellerBindingSourceUp.DataMember = "hersteller";
            this.herstellerBindingSourceUp.DataSource = this.projektZDataSet;
            // 
            // dataGridViewDown
            // 
            this.dataGridViewDown.AllowUserToAddRows = false;
            this.dataGridViewDown.AllowUserToDeleteRows = false;
            this.dataGridViewDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDown.AutoGenerateColumns = false;
            this.dataGridViewDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn2,
            this.geraetebarcodeDataGridViewTextBoxColumn1,
            this.seriennummerDataGridViewTextBoxColumn1,
            this.anschaffungsdatumDataGridViewTextBoxColumn1,
            this.fahrzeugDataGridViewTextBoxColumn1,
            this.kennzeichenDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewDown.DataSource = this.barcodesDownBindingSource;
            this.dataGridViewDown.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewDown.MultiSelect = false;
            this.dataGridViewDown.Name = "dataGridViewDown";
            this.dataGridViewDown.ReadOnly = true;
            this.dataGridViewDown.RowHeadersVisible = false;
            this.dataGridViewDown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDown.Size = new System.Drawing.Size(705, 231);
            this.dataGridViewDown.TabIndex = 4;
            this.dataGridViewDown.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView_CancelRowEdit);
            this.dataGridViewDown.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDown_CellDoubleClick);
            // 
            // bezeichnungDataGridViewTextBoxColumn2
            // 
            this.bezeichnungDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bezeichnungDataGridViewTextBoxColumn2.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn2.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn2.Name = "bezeichnungDataGridViewTextBoxColumn2";
            this.bezeichnungDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bezeichnungDataGridViewTextBoxColumn2.Width = 94;
            // 
            // geraetebarcodeDataGridViewTextBoxColumn1
            // 
            this.geraetebarcodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.geraetebarcodeDataGridViewTextBoxColumn1.DataPropertyName = "geraete_barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.geraetebarcodeDataGridViewTextBoxColumn1.Name = "geraetebarcodeDataGridViewTextBoxColumn1";
            this.geraetebarcodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.geraetebarcodeDataGridViewTextBoxColumn1.Width = 72;
            // 
            // seriennummerDataGridViewTextBoxColumn1
            // 
            this.seriennummerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.seriennummerDataGridViewTextBoxColumn1.DataPropertyName = "seriennummer";
            this.seriennummerDataGridViewTextBoxColumn1.HeaderText = "Seriennummer";
            this.seriennummerDataGridViewTextBoxColumn1.Name = "seriennummerDataGridViewTextBoxColumn1";
            this.seriennummerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.seriennummerDataGridViewTextBoxColumn1.Width = 99;
            // 
            // anschaffungsdatumDataGridViewTextBoxColumn1
            // 
            this.anschaffungsdatumDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anschaffungsdatumDataGridViewTextBoxColumn1.DataPropertyName = "anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn1.HeaderText = "Anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn1.Name = "anschaffungsdatumDataGridViewTextBoxColumn1";
            this.anschaffungsdatumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.anschaffungsdatumDataGridViewTextBoxColumn1.Width = 126;
            // 
            // fahrzeugDataGridViewTextBoxColumn1
            // 
            this.fahrzeugDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fahrzeugDataGridViewTextBoxColumn1.DataPropertyName = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn1.HeaderText = "Fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn1.Name = "fahrzeugDataGridViewTextBoxColumn1";
            this.fahrzeugDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fahrzeugDataGridViewTextBoxColumn1.Width = 76;
            // 
            // kennzeichenDataGridViewTextBoxColumn1
            // 
            this.kennzeichenDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kennzeichenDataGridViewTextBoxColumn1.DataPropertyName = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn1.HeaderText = "Kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn1.Name = "kennzeichenDataGridViewTextBoxColumn1";
            this.kennzeichenDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kennzeichenDataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idgeraetetyp";
            this.dataGridViewTextBoxColumn1.HeaderText = "idgeraetetyp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // barcodesDownBindingSource
            // 
            this.barcodesDownBindingSource.DataMember = "barcodesDown";
            this.barcodesDownBindingSource.DataSource = this.projektZDataSet;
            // 
            // btnDownToUp
            // 
            this.btnDownToUp.Location = new System.Drawing.Point(206, 3);
            this.btnDownToUp.Name = "btnDownToUp";
            this.btnDownToUp.Size = new System.Drawing.Size(136, 21);
            this.btnDownToUp.TabIndex = 4;
            this.btnDownToUp.Text = "Nach oben verschieben";
            this.btnDownToUp.UseVisualStyleBackColor = true;
            this.btnDownToUp.Click += new System.EventHandler(this.move);
            // 
            // comboBoxDown
            // 
            this.comboBoxDown.DataSource = this.herstellerBindingSourceDown;
            this.comboBoxDown.DisplayMember = "bezeichnung";
            this.comboBoxDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDown.FormattingEnabled = true;
            this.comboBoxDown.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDown.Name = "comboBoxDown";
            this.comboBoxDown.Size = new System.Drawing.Size(197, 21);
            this.comboBoxDown.TabIndex = 0;
            this.comboBoxDown.ValueMember = "idhersteller";
            this.comboBoxDown.SelectedIndexChanged += new System.EventHandler(this.refreshBarcodeTables);
            // 
            // herstellerBindingSourceDown
            // 
            this.herstellerBindingSourceDown.DataMember = "hersteller";
            this.herstellerBindingSourceDown.DataSource = this.projektZDataSet;
            // 
            // barcodesTableAdapterUp
            // 
            this.barcodesTableAdapterUp.ClearBeforeFill = true;
            // 
            // barcodesTableAdapterDown
            // 
            this.barcodesTableAdapterDown.ClearBeforeFill = true;
            // 
            // HerstellerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 521);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HerstellerAdd";
            this.Text = "Hersteller bearbeiten";
            this.Load += new System.EventHandler(this.HerstellerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHersteller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSourceUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesDownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSourceDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHersteller;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource herstellerBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter herstellerTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox comboBoxUp;
        private System.Windows.Forms.ComboBox comboBoxDown;
        private System.Windows.Forms.Button btnUpToDown;
        private System.Windows.Forms.Button btnDownToUp;
        private System.Windows.Forms.DataGridView dataGridViewUp;
        private System.Windows.Forms.DataGridView dataGridViewDown;
        private System.Windows.Forms.BindingSource herstellerBindingSourceUp;
        private System.Windows.Forms.BindingSource herstellerBindingSourceDown;
        private System.Windows.Forms.BindingSource barcodesUpBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterUp barcodesTableAdapterUp;
        private System.Windows.Forms.BindingSource barcodesDownBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterDown barcodesTableAdapterDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn idherstellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn geraetebarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeraetetyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn geraetebarcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeugDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}