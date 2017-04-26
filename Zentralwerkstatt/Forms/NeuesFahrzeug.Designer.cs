namespace Zentralwerkstatt.Forms
{
    partial class NeuesFahrzeug
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
            this.fahrzeugestandorteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.fahrzeugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrzeugeTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.fahrzeugeTableAdapter();
            this.standorteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standorteTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.standorteTableAdapter();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standort = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn,
            this.kennzeichenDataGridViewTextBoxColumn,
            this.standort});
            this.dataGridView1.DataSource = this.fahrzeugestandorteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fahrzeugestandorteBindingSource
            // 
            this.fahrzeugestandorteBindingSource.DataMember = "fahrzeuge_standorte";
            this.fahrzeugestandorteBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fahrzeugeBindingSource
            // 
            this.fahrzeugeBindingSource.DataMember = "fahrzeuge";
            this.fahrzeugeBindingSource.DataSource = this.projektZDataSet;
            // 
            // fahrzeugeTableAdapter
            // 
            this.fahrzeugeTableAdapter.ClearBeforeFill = true;
            // 
            // standorteBindingSource
            // 
            this.standorteBindingSource.DataMember = "standorte";
            this.standorteBindingSource.DataSource = this.projektZDataSet;
            // 
            // standorteTableAdapter
            // 
            this.standorteTableAdapter.ClearBeforeFill = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // kennzeichenDataGridViewTextBoxColumn
            // 
            this.kennzeichenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kennzeichenDataGridViewTextBoxColumn.DataPropertyName = "kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn.HeaderText = "Kennzeichen";
            this.kennzeichenDataGridViewTextBoxColumn.Name = "kennzeichenDataGridViewTextBoxColumn";
            this.kennzeichenDataGridViewTextBoxColumn.Width = 94;
            // 
            // standort
            // 
            this.standort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.standort.DataPropertyName = "standort";
            this.standort.DataSource = this.standorteBindingSource;
            this.standort.DisplayMember = "bezeichnung";
            this.standort.HeaderText = "Standort";
            this.standort.Name = "standort";
            this.standort.Width = 53;
            // 
            // NeuesFahrzeug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NeuesFahrzeug";
            this.Text = "NeuesFahrzeug";
            this.Load += new System.EventHandler(this.NeuesFahrzeug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standorteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSets.ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource fahrzeugeBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.fahrzeugeTableAdapter fahrzeugeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstandortDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fahrzeugestandorteBindingSource;
        private System.Windows.Forms.BindingSource standorteBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.standorteTableAdapter standorteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn standort;
    }
}