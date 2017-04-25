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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Übernehmen = new System.Windows.Forms.Button();
            this.Abbrechen = new System.Windows.Forms.Button();
            this.projektZDataSet = new Zentralwerkstatt.ProjektZDataSet();
            this.herstellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herstellerTableAdapter = new Zentralwerkstatt.ProjektZDataSetTableAdapters.herstellerTableAdapter();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.herstellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // Übernehmen
            // 
            this.Übernehmen.Location = new System.Drawing.Point(13, 340);
            this.Übernehmen.Name = "Übernehmen";
            this.Übernehmen.Size = new System.Drawing.Size(121, 23);
            this.Übernehmen.TabIndex = 1;
            this.Übernehmen.Text = "Übernehmen";
            this.Übernehmen.UseVisualStyleBackColor = true;
            this.Übernehmen.Click += new System.EventHandler(this.Übernehmen_Click);
            // 
            // Abbrechen
            // 
            this.Abbrechen.Location = new System.Drawing.Point(140, 340);
            this.Abbrechen.Name = "Abbrechen";
            this.Abbrechen.Size = new System.Drawing.Size(131, 23);
            this.Abbrechen.TabIndex = 2;
            this.Abbrechen.Text = "Abbrechen";
            this.Abbrechen.UseVisualStyleBackColor = true;
            this.Abbrechen.Click += new System.EventHandler(this.Abbrechen_Click);
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herstellerBindingSource
            // 
            this.herstellerBindingSource.DataMember = "Hersteller";
            this.herstellerBindingSource.DataSource = this.projektZDataSet;
            // 
            // herstellerTableAdapter
            // 
            this.herstellerTableAdapter.ClearBeforeFill = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // HerstellerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.Abbrechen);
            this.Controls.Add(this.Übernehmen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HerstellerAdd";
            this.Text = "Hersteller bearbeiten";
            this.Load += new System.EventHandler(this.HerstellerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Übernehmen;
        private System.Windows.Forms.Button Abbrechen;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource herstellerBindingSource;
        private ProjektZDataSetTableAdapters.herstellerTableAdapter herstellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
    }
}