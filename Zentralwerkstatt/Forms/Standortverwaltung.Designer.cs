namespace Zentralwerkstatt.Forms
{
    partial class Standortverwaltung
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.standorteDataGridView = new System.Windows.Forms.DataGridView();
            this.idstandort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standorteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboBoxUp = new System.Windows.Forms.ComboBox();
            this.standorteBindingSourceUp = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpToDown = new System.Windows.Forms.Button();
            this.fahrzeuge_standorteUpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeuge_standorteUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDown = new System.Windows.Forms.ComboBox();
            this.standorteBindingSourceDown = new System.Windows.Forms.BindingSource(this.components);
            this.btnDownToUp = new System.Windows.Forms.Button();
            this.fahrzeuge_standorteDownDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fahrzeuge_standorteDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standorteTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.standorteTableAdapter();
            this.tableAdapterManager = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.TableAdapterManager();
            this.fahrzeuge_standorteUpTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteUpTableAdapter();
            this.fahrzeuge_standorteDownTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteDownTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standorteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSourceUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteUpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSourceDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteDownDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteDownBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.standorteDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(592, 496);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // standorteDataGridView
            // 
            this.standorteDataGridView.AutoGenerateColumns = false;
            this.standorteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.standorteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstandort,
            this.dataGridViewTextBoxColumn2});
            this.standorteDataGridView.DataSource = this.standorteBindingSource;
            this.standorteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standorteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.standorteDataGridView.MultiSelect = false;
            this.standorteDataGridView.Name = "standorteDataGridView";
            this.standorteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.standorteDataGridView.Size = new System.Drawing.Size(180, 496);
            this.standorteDataGridView.TabIndex = 0;
            this.standorteDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.standorteDataGridView_CellEndEdit);
            this.standorteDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.standorteDataGridView_UserDeletedRow);
            this.standorteDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.standorteDataGridView_UserDeletingRow);
            // 
            // idstandort
            // 
            this.idstandort.DataPropertyName = "idstandort";
            this.idstandort.HeaderText = "idstandort";
            this.idstandort.Name = "idstandort";
            this.idstandort.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bezeichnung";
            this.dataGridViewTextBoxColumn2.HeaderText = "Standort";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // standorteBindingSource
            // 
            this.standorteBindingSource.DataMember = "standorte";
            this.standorteBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxUp);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpToDown);
            this.splitContainer2.Panel1.Controls.Add(this.fahrzeuge_standorteUpDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.comboBoxDown);
            this.splitContainer2.Panel2.Controls.Add(this.btnDownToUp);
            this.splitContainer2.Panel2.Controls.Add(this.fahrzeuge_standorteDownDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(408, 496);
            this.splitContainer2.SplitterDistance = 248;
            this.splitContainer2.TabIndex = 0;
            // 
            // comboBoxUp
            // 
            this.comboBoxUp.DataSource = this.standorteBindingSourceUp;
            this.comboBoxUp.DisplayMember = "bezeichnung";
            this.comboBoxUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUp.FormattingEnabled = true;
            this.comboBoxUp.Location = new System.Drawing.Point(3, 3);
            this.comboBoxUp.Name = "comboBoxUp";
            this.comboBoxUp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUp.TabIndex = 2;
            this.comboBoxUp.SelectedIndexChanged += new System.EventHandler(this.refreshFahrzeugeTables);
            // 
            // standorteBindingSourceUp
            // 
            this.standorteBindingSourceUp.DataMember = "standorte";
            this.standorteBindingSourceUp.DataSource = this.projektZDataSet;
            // 
            // btnUpToDown
            // 
            this.btnUpToDown.Location = new System.Drawing.Point(130, 3);
            this.btnUpToDown.Name = "btnUpToDown";
            this.btnUpToDown.Size = new System.Drawing.Size(136, 21);
            this.btnUpToDown.TabIndex = 1;
            this.btnUpToDown.Text = "Nach unten verschieben";
            this.btnUpToDown.UseVisualStyleBackColor = true;
            this.btnUpToDown.Click += new System.EventHandler(this.move);
            // 
            // fahrzeuge_standorteUpDataGridView
            // 
            this.fahrzeuge_standorteUpDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fahrzeuge_standorteUpDataGridView.AutoGenerateColumns = false;
            this.fahrzeuge_standorteUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fahrzeuge_standorteUpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idfahrzeug});
            this.fahrzeuge_standorteUpDataGridView.DataSource = this.fahrzeuge_standorteUpBindingSource;
            this.fahrzeuge_standorteUpDataGridView.Location = new System.Drawing.Point(0, 30);
            this.fahrzeuge_standorteUpDataGridView.MultiSelect = false;
            this.fahrzeuge_standorteUpDataGridView.Name = "fahrzeuge_standorteUpDataGridView";
            this.fahrzeuge_standorteUpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fahrzeuge_standorteUpDataGridView.Size = new System.Drawing.Size(408, 215);
            this.fahrzeuge_standorteUpDataGridView.TabIndex = 0;
            this.fahrzeuge_standorteUpDataGridView.VirtualMode = true;
            this.fahrzeuge_standorteUpDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.fahrzeuge_standorteDataGridView_CellBeginEdit);
            this.fahrzeuge_standorteUpDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.fahrzeuge_standorteDataGridView_CellEndEdit);
            this.fahrzeuge_standorteUpDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.fahrzeuge_standorteDataGridView_DataError);
            this.fahrzeuge_standorteUpDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fahrzeuge_standorteDataGridView_RowHeaderMouseDoubleClick);
            this.fahrzeuge_standorteUpDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.fahrzeuge_standorteDataGridView_UserDeletedRow);
            this.fahrzeuge_standorteUpDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.fahrzeuge_standorteDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bezeichnung";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fahrzeug";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kennzeichen";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kennzeichen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 94;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "standort";
            this.dataGridViewTextBoxColumn5.HeaderText = "Standort";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // idfahrzeug
            // 
            this.idfahrzeug.DataPropertyName = "idfahrzeug";
            this.idfahrzeug.HeaderText = "idfahrzeug";
            this.idfahrzeug.Name = "idfahrzeug";
            this.idfahrzeug.Visible = false;
            // 
            // fahrzeuge_standorteUpBindingSource
            // 
            this.fahrzeuge_standorteUpBindingSource.DataMember = "fahrzeuge_standorteUp";
            this.fahrzeuge_standorteUpBindingSource.DataSource = this.projektZDataSet;
            // 
            // comboBoxDown
            // 
            this.comboBoxDown.DataSource = this.standorteBindingSourceDown;
            this.comboBoxDown.DisplayMember = "bezeichnung";
            this.comboBoxDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDown.FormattingEnabled = true;
            this.comboBoxDown.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDown.Name = "comboBoxDown";
            this.comboBoxDown.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDown.TabIndex = 2;
            this.comboBoxDown.SelectedIndexChanged += new System.EventHandler(this.refreshFahrzeugeTables);
            // 
            // standorteBindingSourceDown
            // 
            this.standorteBindingSourceDown.DataMember = "standorte";
            this.standorteBindingSourceDown.DataSource = this.projektZDataSet;
            // 
            // btnDownToUp
            // 
            this.btnDownToUp.Location = new System.Drawing.Point(130, 3);
            this.btnDownToUp.Name = "btnDownToUp";
            this.btnDownToUp.Size = new System.Drawing.Size(136, 21);
            this.btnDownToUp.TabIndex = 1;
            this.btnDownToUp.Text = "Nach oben verschieben";
            this.btnDownToUp.UseVisualStyleBackColor = true;
            this.btnDownToUp.Click += new System.EventHandler(this.move);
            // 
            // fahrzeuge_standorteDownDataGridView
            // 
            this.fahrzeuge_standorteDownDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fahrzeuge_standorteDownDataGridView.AutoGenerateColumns = false;
            this.fahrzeuge_standorteDownDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fahrzeuge_standorteDownDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn1});
            this.fahrzeuge_standorteDownDataGridView.DataSource = this.fahrzeuge_standorteDownBindingSource;
            this.fahrzeuge_standorteDownDataGridView.Location = new System.Drawing.Point(0, 30);
            this.fahrzeuge_standorteDownDataGridView.MultiSelect = false;
            this.fahrzeuge_standorteDownDataGridView.Name = "fahrzeuge_standorteDownDataGridView";
            this.fahrzeuge_standorteDownDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fahrzeuge_standorteDownDataGridView.Size = new System.Drawing.Size(408, 214);
            this.fahrzeuge_standorteDownDataGridView.TabIndex = 0;
            this.fahrzeuge_standorteDownDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.fahrzeuge_standorteDataGridView_CellBeginEdit);
            this.fahrzeuge_standorteDownDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.fahrzeuge_standorteDataGridView_CellEndEdit);
            this.fahrzeuge_standorteDownDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.fahrzeuge_standorteDataGridView_DataError);
            this.fahrzeuge_standorteDownDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fahrzeuge_standorteDataGridView_RowHeaderMouseDoubleClick);
            this.fahrzeuge_standorteDownDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.fahrzeuge_standorteDataGridView_UserDeletedRow);
            this.fahrzeuge_standorteDownDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.fahrzeuge_standorteDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bezeichnung";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fahrzeug";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 76;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kennzeichen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kennzeichen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 94;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "standort";
            this.dataGridViewTextBoxColumn8.HeaderText = "Standort";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idfahrzeug";
            this.dataGridViewTextBoxColumn1.HeaderText = "idfahrzeug";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // fahrzeuge_standorteDownBindingSource
            // 
            this.fahrzeuge_standorteDownBindingSource.DataMember = "fahrzeuge_standorteDown";
            this.fahrzeuge_standorteDownBindingSource.DataSource = this.projektZDataSet;
            // 
            // standorteTableAdapter
            // 
            this.standorteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.benutzerTableAdapter = null;
            this.tableAdapterManager.fahrzeugeDownTableAdapter = null;
            this.tableAdapterManager.fahrzeugeTableAdapter = null;
            this.tableAdapterManager.fahrzeugeUpTableAdapter = null;
            this.tableAdapterManager.geraeteTableAdapter = null;
            this.tableAdapterManager.geraetetypenTableAdapter = null;
            this.tableAdapterManager.herstellerTableAdapter = null;
            this.tableAdapterManager.pruefergebnisseTableAdapter = null;
            this.tableAdapterManager.pruefkriterienTableAdapter = null;
            this.tableAdapterManager.pruefungenTableAdapter = null;
            this.tableAdapterManager.standorteTableAdapter = this.standorteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fahrzeuge_standorteUpTableAdapter
            // 
            this.fahrzeuge_standorteUpTableAdapter.ClearBeforeFill = true;
            // 
            // fahrzeuge_standorteDownTableAdapter
            // 
            this.fahrzeuge_standorteDownTableAdapter.ClearBeforeFill = true;
            // 
            // Standortverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 496);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Standortverwaltung";
            this.Text = "NeuesFahrzeug";
            this.Load += new System.EventHandler(this.NeuesFahrzeug_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standorteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSourceUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteUpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSourceDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteDownDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeuge_standorteDownBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSets.ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource standorteBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.standorteTableAdapter standorteTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DataSets.ProjektZDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView standorteDataGridView;
        private System.Windows.Forms.DataGridView fahrzeuge_standorteUpDataGridView;
        private System.Windows.Forms.DataGridView fahrzeuge_standorteDownDataGridView;
        private System.Windows.Forms.ComboBox comboBoxUp;
        private System.Windows.Forms.Button btnUpToDown;
        private System.Windows.Forms.ComboBox comboBoxDown;
        private System.Windows.Forms.Button btnDownToUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstandort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource standorteBindingSourceUp;
        private System.Windows.Forms.BindingSource standorteBindingSourceDown;
        private System.Windows.Forms.BindingSource fahrzeuge_standorteUpBindingSource;
        private System.Windows.Forms.BindingSource fahrzeuge_standorteDownBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteUpTableAdapter fahrzeuge_standorteUpTableAdapter;
        private DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteDownTableAdapter fahrzeuge_standorteDownTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfahrzeug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}