namespace Zentralwerkstatt.Forms
{
    partial class Fahrzeugenverwaltung
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
            this.btnDownToUp = new System.Windows.Forms.Button();
            this.comboBoxDown = new System.Windows.Forms.ComboBox();
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.dataGridViewDown = new System.Windows.Forms.DataGridView();
            this.barcodesDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpToDown = new System.Windows.Forms.Button();
            this.comboBoxUp = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnFahrzeugeAdd = new System.Windows.Forms.Button();
            this.dataGridViewUp = new System.Windows.Forms.DataGridView();
            this.barcodesUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodesTableAdapterUp = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterUp();
            this.barcodesTableAdapterDown = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterDown();
            this.bezeichnungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetebarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgeraetetypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idherstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geraetebarcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriennummerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeugDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgeraetetypDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idherstellerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeuge_standorteTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteTableAdapter();
            this.fahrzeugestandorteBindingSourceUp = new System.Windows.Forms.BindingSource(this.components);
            this.fahrzeugestandorteBindingSourceDown = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesDownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSourceUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSourceDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownToUp
            // 
            this.btnDownToUp.Location = new System.Drawing.Point(293, 3);
            this.btnDownToUp.Name = "btnDownToUp";
            this.btnDownToUp.Size = new System.Drawing.Size(136, 21);
            this.btnDownToUp.TabIndex = 4;
            this.btnDownToUp.Text = "Nach oben verschieben";
            this.btnDownToUp.UseVisualStyleBackColor = true;
            this.btnDownToUp.Click += new System.EventHandler(this.move);
            // 
            // comboBoxDown
            // 
            this.comboBoxDown.DataSource = this.fahrzeugestandorteBindingSourceDown;
            this.comboBoxDown.DisplayMember = "toString";
            this.comboBoxDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDown.FormattingEnabled = true;
            this.comboBoxDown.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDown.Name = "comboBoxDown";
            this.comboBoxDown.Size = new System.Drawing.Size(284, 21);
            this.comboBoxDown.TabIndex = 0;
            this.comboBoxDown.ValueMember = "idfahrzeug";
            this.comboBoxDown.SelectedIndexChanged += new System.EventHandler(this.refreshBarcodeTables);
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.herstellerDataGridViewTextBoxColumn1,
            this.fahrzeugDataGridViewTextBoxColumn1,
            this.kennzeichenDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.idgeraetetypDataGridViewTextBoxColumn1,
            this.idherstellerDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewDown.DataSource = this.barcodesDownBindingSource;
            this.dataGridViewDown.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewDown.MultiSelect = false;
            this.dataGridViewDown.Name = "dataGridViewDown";
            this.dataGridViewDown.ReadOnly = true;
            this.dataGridViewDown.RowHeadersVisible = false;
            this.dataGridViewDown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDown.Size = new System.Drawing.Size(676, 245);
            this.dataGridViewDown.TabIndex = 4;
            this.dataGridViewDown.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView_CancelRowEdit);
            this.dataGridViewDown.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDown_CellDoubleClick);
            // 
            // barcodesDownBindingSource
            // 
            this.barcodesDownBindingSource.DataMember = "barcodesDown";
            this.barcodesDownBindingSource.DataSource = this.projektZDataSet;
            // 
            // btnUpToDown
            // 
            this.btnUpToDown.Location = new System.Drawing.Point(293, 4);
            this.btnUpToDown.Name = "btnUpToDown";
            this.btnUpToDown.Size = new System.Drawing.Size(136, 21);
            this.btnUpToDown.TabIndex = 3;
            this.btnUpToDown.Text = "Nach unten verschieben";
            this.btnUpToDown.UseVisualStyleBackColor = true;
            this.btnUpToDown.Click += new System.EventHandler(this.move);
            // 
            // comboBoxUp
            // 
            this.comboBoxUp.DataSource = this.fahrzeugestandorteBindingSourceUp;
            this.comboBoxUp.DisplayMember = "toString";
            this.comboBoxUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUp.FormattingEnabled = true;
            this.comboBoxUp.Location = new System.Drawing.Point(3, 4);
            this.comboBoxUp.Name = "comboBoxUp";
            this.comboBoxUp.Size = new System.Drawing.Size(284, 21);
            this.comboBoxUp.TabIndex = 0;
            this.comboBoxUp.ValueMember = "idfahrzeug";
            this.comboBoxUp.SelectedIndexChanged += new System.EventHandler(this.refreshBarcodeTables);
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
            this.splitContainer2.Panel1.Controls.Add(this.btnFahrzeugeAdd);
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
            this.splitContainer2.Size = new System.Drawing.Size(676, 548);
            this.splitContainer2.SplitterDistance = 273;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnFahrzeugeAdd
            // 
            this.btnFahrzeugeAdd.Location = new System.Drawing.Point(510, 4);
            this.btnFahrzeugeAdd.Name = "btnFahrzeugeAdd";
            this.btnFahrzeugeAdd.Size = new System.Drawing.Size(154, 21);
            this.btnFahrzeugeAdd.TabIndex = 4;
            this.btnFahrzeugeAdd.Text = "Fahrzeuge Verwalten";
            this.btnFahrzeugeAdd.UseVisualStyleBackColor = true;
            this.btnFahrzeugeAdd.Click += new System.EventHandler(this.btnFahrzeugeAdd_Click);
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
            this.herstellerDataGridViewTextBoxColumn,
            this.fahrzeugDataGridViewTextBoxColumn,
            this.kennzeichenDataGridViewTextBoxColumn1,
            this.idgeraetetypDataGridViewTextBoxColumn,
            this.idherstellerDataGridViewTextBoxColumn,
            this.idfahrzeug});
            this.dataGridViewUp.DataSource = this.barcodesUpBindingSource;
            this.dataGridViewUp.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewUp.MultiSelect = false;
            this.dataGridViewUp.Name = "dataGridViewUp";
            this.dataGridViewUp.ReadOnly = true;
            this.dataGridViewUp.RowHeadersVisible = false;
            this.dataGridViewUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUp.Size = new System.Drawing.Size(676, 243);
            this.dataGridViewUp.TabIndex = 3;
            this.dataGridViewUp.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView_CancelRowEdit);
            this.dataGridViewUp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUp_CellDoubleClick);
            // 
            // barcodesUpBindingSource
            // 
            this.barcodesUpBindingSource.DataMember = "barcodesUp";
            this.barcodesUpBindingSource.DataSource = this.projektZDataSet;
            // 
            // barcodesTableAdapterUp
            // 
            this.barcodesTableAdapterUp.ClearBeforeFill = true;
            // 
            // barcodesTableAdapterDown
            // 
            this.barcodesTableAdapterDown.ClearBeforeFill = true;
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
            // herstellerDataGridViewTextBoxColumn
            // 
            this.herstellerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.herstellerDataGridViewTextBoxColumn.DataPropertyName = "hersteller";
            this.herstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.Name = "herstellerDataGridViewTextBoxColumn";
            this.herstellerDataGridViewTextBoxColumn.ReadOnly = true;
            this.herstellerDataGridViewTextBoxColumn.Width = 76;
            // 
            // fahrzeugDataGridViewTextBoxColumn
            // 
            this.fahrzeugDataGridViewTextBoxColumn.DataPropertyName = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn.HeaderText = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn.Name = "fahrzeugDataGridViewTextBoxColumn";
            this.fahrzeugDataGridViewTextBoxColumn.ReadOnly = true;
            this.fahrzeugDataGridViewTextBoxColumn.Visible = false;
            // 
            // kennzeichenDataGridViewTextBoxColumn1
            // 
            this.kennzeichenDataGridViewTextBoxColumn1.DataPropertyName = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn1.HeaderText = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn1.Name = "kennzeichenDataGridViewTextBoxColumn1";
            this.kennzeichenDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kennzeichenDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idgeraetetypDataGridViewTextBoxColumn
            // 
            this.idgeraetetypDataGridViewTextBoxColumn.DataPropertyName = "idgeraetetyp";
            this.idgeraetetypDataGridViewTextBoxColumn.HeaderText = "idgeraetetyp";
            this.idgeraetetypDataGridViewTextBoxColumn.Name = "idgeraetetypDataGridViewTextBoxColumn";
            this.idgeraetetypDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgeraetetypDataGridViewTextBoxColumn.Visible = false;
            // 
            // idherstellerDataGridViewTextBoxColumn
            // 
            this.idherstellerDataGridViewTextBoxColumn.DataPropertyName = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn.HeaderText = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn.Name = "idherstellerDataGridViewTextBoxColumn";
            this.idherstellerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idherstellerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idfahrzeug
            // 
            this.idfahrzeug.DataPropertyName = "idfahrzeug";
            this.idfahrzeug.HeaderText = "idfahrzeug";
            this.idfahrzeug.Name = "idfahrzeug";
            this.idfahrzeug.ReadOnly = true;
            this.idfahrzeug.Visible = false;
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
            // herstellerDataGridViewTextBoxColumn1
            // 
            this.herstellerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.herstellerDataGridViewTextBoxColumn1.DataPropertyName = "hersteller";
            this.herstellerDataGridViewTextBoxColumn1.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn1.Name = "herstellerDataGridViewTextBoxColumn1";
            this.herstellerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.herstellerDataGridViewTextBoxColumn1.Width = 76;
            // 
            // fahrzeugDataGridViewTextBoxColumn1
            // 
            this.fahrzeugDataGridViewTextBoxColumn1.DataPropertyName = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn1.HeaderText = "fahrzeug";
            this.fahrzeugDataGridViewTextBoxColumn1.Name = "fahrzeugDataGridViewTextBoxColumn1";
            this.fahrzeugDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fahrzeugDataGridViewTextBoxColumn1.Visible = false;
            // 
            // kennzeichenDataGridViewTextBoxColumn2
            // 
            this.kennzeichenDataGridViewTextBoxColumn2.DataPropertyName = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn2.HeaderText = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn2.Name = "kennzeichenDataGridViewTextBoxColumn2";
            this.kennzeichenDataGridViewTextBoxColumn2.ReadOnly = true;
            this.kennzeichenDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idgeraetetyp";
            this.dataGridViewTextBoxColumn1.HeaderText = "idgeraetetyp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // idgeraetetypDataGridViewTextBoxColumn1
            // 
            this.idgeraetetypDataGridViewTextBoxColumn1.DataPropertyName = "idgeraetetyp";
            this.idgeraetetypDataGridViewTextBoxColumn1.HeaderText = "idgeraetetyp";
            this.idgeraetetypDataGridViewTextBoxColumn1.Name = "idgeraetetypDataGridViewTextBoxColumn1";
            this.idgeraetetypDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idgeraetetypDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idherstellerDataGridViewTextBoxColumn1
            // 
            this.idherstellerDataGridViewTextBoxColumn1.DataPropertyName = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn1.HeaderText = "idhersteller";
            this.idherstellerDataGridViewTextBoxColumn1.Name = "idherstellerDataGridViewTextBoxColumn1";
            this.idherstellerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idherstellerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idfahrzeug";
            this.dataGridViewTextBoxColumn2.HeaderText = "idfahrzeug";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // fahrzeuge_standorteTableAdapter
            // 
            this.fahrzeuge_standorteTableAdapter.ClearBeforeFill = true;
            // 
            // fahrzeugestandorteBindingSourceUp
            // 
            this.fahrzeugestandorteBindingSourceUp.DataMember = "fahrzeuge_standorte";
            this.fahrzeugestandorteBindingSourceUp.DataSource = this.projektZDataSet;
            // 
            // fahrzeugestandorteBindingSourceDown
            // 
            this.fahrzeugestandorteBindingSourceDown.DataMember = "fahrzeuge_standorte";
            this.fahrzeugestandorteBindingSourceDown.DataSource = this.projektZDataSet;
            // 
            // Fahrzeugenverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 548);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Fahrzeugenverwaltung";
            this.Text = "Fahrzeugenverwaltung";
            this.Load += new System.EventHandler(this.Fahrzeugenverwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesDownBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSourceUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSourceDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDownToUp;
        private System.Windows.Forms.ComboBox comboBoxDown;
        private System.Windows.Forms.DataGridView dataGridViewDown;
        private System.Windows.Forms.Button btnUpToDown;
        private System.Windows.Forms.ComboBox comboBoxUp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewUp;
        private DataSets.ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource barcodesUpBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterUp barcodesTableAdapterUp;
        private System.Windows.Forms.BindingSource barcodesDownBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.barcodesTableAdapterDown barcodesTableAdapterDown;
        private System.Windows.Forms.Button btnFahrzeugeAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn geraetebarcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeugDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeraetetypDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idherstellerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn geraetebarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrzeugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeraetetypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idherstellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfahrzeug;
        private DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteTableAdapter fahrzeuge_standorteTableAdapter;
        private System.Windows.Forms.BindingSource fahrzeugestandorteBindingSourceDown;
        private System.Windows.Forms.BindingSource fahrzeugestandorteBindingSourceUp;
    }
}