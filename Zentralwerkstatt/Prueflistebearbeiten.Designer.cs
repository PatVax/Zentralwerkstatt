namespace Zentralwerkstatt
{
    partial class Prueflistebearbeiten
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
            this.Gerätetypen = new System.Windows.Forms.DataGridView();
            this.Prüfliste = new System.Windows.Forms.DataGridView();
            this.projektzDataSet = new Zentralwerkstatt.projektzDataSet();
            this.prüfkriterienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prüfkriterienTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.prüfkriterienTableAdapter();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anzeigeartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerätetypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerätetypenTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.gerätetypenTableAdapter();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prüfkriterienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Gerätetypen
            // 
            this.Gerätetypen.AllowUserToAddRows = false;
            this.Gerätetypen.AllowUserToDeleteRows = false;
            this.Gerätetypen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gerätetypen.AutoGenerateColumns = false;
            this.Gerätetypen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerätetypen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn});
            this.Gerätetypen.DataSource = this.gerätetypenBindingSource;
            this.Gerätetypen.Location = new System.Drawing.Point(8, 12);
            this.Gerätetypen.Name = "Gerätetypen";
            this.Gerätetypen.ReadOnly = true;
            this.Gerätetypen.RowHeadersVisible = false;
            this.Gerätetypen.Size = new System.Drawing.Size(173, 557);
            this.Gerätetypen.TabIndex = 3;
            // 
            // Prüfliste
            // 
            this.Prüfliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prüfliste.AutoGenerateColumns = false;
            this.Prüfliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prüfliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.anzeigeartDataGridViewTextBoxColumn});
            this.Prüfliste.DataSource = this.prüfkriterienBindingSource;
            this.Prüfliste.Location = new System.Drawing.Point(187, 12);
            this.Prüfliste.Name = "Prüfliste";
            this.Prüfliste.RowHeadersVisible = false;
            this.Prüfliste.Size = new System.Drawing.Size(1048, 557);
            this.Prüfliste.TabIndex = 2;
            // 
            // projektzDataSet
            // 
            this.projektzDataSet.DataSetName = "projektzDataSet";
            this.projektzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prüfkriterienBindingSource
            // 
            this.prüfkriterienBindingSource.DataMember = "prüfkriterien";
            this.prüfkriterienBindingSource.DataSource = this.projektzDataSet;
            // 
            // prüfkriterienTableAdapter
            // 
            this.prüfkriterienTableAdapter.ClearBeforeFill = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.FillWeight = 10000F;
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // anzeigeartDataGridViewTextBoxColumn
            // 
            this.anzeigeartDataGridViewTextBoxColumn.DataPropertyName = "Anzeigeart";
            this.anzeigeartDataGridViewTextBoxColumn.HeaderText = "Anzeigeart";
            this.anzeigeartDataGridViewTextBoxColumn.Name = "anzeigeartDataGridViewTextBoxColumn";
            // 
            // gerätetypenBindingSource
            // 
            this.gerätetypenBindingSource.DataMember = "gerätetypen";
            this.gerätetypenBindingSource.DataSource = this.projektzDataSet;
            // 
            // gerätetypenTableAdapter
            // 
            this.gerätetypenTableAdapter.ClearBeforeFill = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Prueflistebearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 581);
            this.Controls.Add(this.Gerätetypen);
            this.Controls.Add(this.Prüfliste);
            this.Name = "Prueflistebearbeiten";
            this.Text = "Prueflistebearbeiten";
            this.Load += new System.EventHandler(this.Prueflistebearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prüfkriterienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gerätetypen;
        private System.Windows.Forms.DataGridView Prüfliste;
        private projektzDataSet projektzDataSet;
        private System.Windows.Forms.BindingSource prüfkriterienBindingSource;
        private projektzDataSetTableAdapters.prüfkriterienTableAdapter prüfkriterienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anzeigeartDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gerätetypenBindingSource;
        private projektzDataSetTableAdapters.gerätetypenTableAdapter gerätetypenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
    }
}