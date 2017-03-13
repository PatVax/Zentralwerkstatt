namespace Zentralwerkstatt
{
    partial class Pruefliste
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
            this.Prüfliste = new System.Windows.Forms.DataGridView();
            this.Gerätetypen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.projektzDataSet = new Zentralwerkstatt.projektzDataSet();
            this.gerätetypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerätetypenTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.gerätetypenTableAdapter();
            this.iDGerÃtetypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prueftext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzeigeart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Prüfliste
            // 
            this.Prüfliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prüfliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prüfliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueftext,
            this.Anzeigeart});
            this.Prüfliste.Location = new System.Drawing.Point(191, 12);
            this.Prüfliste.Name = "Prüfliste";
            this.Prüfliste.RowHeadersVisible = false;
            this.Prüfliste.Size = new System.Drawing.Size(909, 563);
            this.Prüfliste.TabIndex = 0;
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
            this.iDGerÃtetypDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn});
            this.Gerätetypen.DataSource = this.gerätetypenBindingSource;
            this.Gerätetypen.Location = new System.Drawing.Point(12, 12);
            this.Gerätetypen.Name = "Gerätetypen";
            this.Gerätetypen.ReadOnly = true;
            this.Gerätetypen.RowHeadersVisible = false;
            this.Gerätetypen.Size = new System.Drawing.Size(173, 563);
            this.Gerätetypen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(928, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Abbrechen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projektzDataSet
            // 
            this.projektzDataSet.DataSetName = "projektzDataSet";
            this.projektzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDGerÃtetypDataGridViewTextBoxColumn
            // 
            this.iDGerÃtetypDataGridViewTextBoxColumn.DataPropertyName = "IDGerÃ¤tetyp";
            this.iDGerÃtetypDataGridViewTextBoxColumn.HeaderText = "IDGerÃ¤tetyp";
            this.iDGerÃtetypDataGridViewTextBoxColumn.Name = "iDGerÃtetypDataGridViewTextBoxColumn";
            this.iDGerÃtetypDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDGerÃtetypDataGridViewTextBoxColumn.Visible = false;
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
            // Prueftext
            // 
            this.Prueftext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prueftext.FillWeight = 10000F;
            this.Prueftext.HeaderText = "Prüftext";
            this.Prueftext.Name = "Prueftext";
            // 
            // Anzeigeart
            // 
            this.Anzeigeart.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Anzeigeart.HeaderText = "Anzeigeart";
            this.Anzeigeart.Items.AddRange(new object[] {
            "h",
            "b",
            "mm"});
            this.Anzeigeart.Name = "Anzeigeart";
            // 
            // Pruefliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 620);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gerätetypen);
            this.Controls.Add(this.Prüfliste);
            this.Name = "Pruefliste";
            this.Text = "Pruefliste";
            this.Load += new System.EventHandler(this.Pruefliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Prüfliste;
        private System.Windows.Forms.DataGridView Gerätetypen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private projektzDataSet projektzDataSet;
        private System.Windows.Forms.BindingSource gerätetypenBindingSource;
        private projektzDataSetTableAdapters.gerätetypenTableAdapter gerätetypenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGerÃtetypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueftext;
        private System.Windows.Forms.DataGridViewComboBoxColumn Anzeigeart;
    }
}