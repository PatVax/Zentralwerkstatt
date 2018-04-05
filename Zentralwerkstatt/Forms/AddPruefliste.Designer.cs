using Zentralwerkstatt.DataSets;

namespace Zentralwerkstatt
{
    partial class AddPruefliste
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
            this.dataGridViewPruefliste = new System.Windows.Forms.DataGridView();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anzeigeartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.messwert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolFeld = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idgeraetetyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkriterium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruefkriterienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.pruefkriterienTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.pruefkriterienTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPruefliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruefkriterienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPruefliste
            // 
            this.dataGridViewPruefliste.AllowDrop = true;
            this.dataGridViewPruefliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPruefliste.AutoGenerateColumns = false;
            this.dataGridViewPruefliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPruefliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.anzeigeartDataGridViewTextBoxColumn,
            this.header,
            this.messwert,
            this.boolFeld,
            this.idgeraetetyp,
            this.idkriterium});
            this.dataGridViewPruefliste.DataSource = this.pruefkriterienBindingSource;
            this.dataGridViewPruefliste.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPruefliste.Name = "dataGridViewPruefliste";
            this.dataGridViewPruefliste.Size = new System.Drawing.Size(1126, 470);
            this.dataGridViewPruefliste.TabIndex = 0;
            this.dataGridViewPruefliste.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewPruefliste_CellValidating);
            this.dataGridViewPruefliste.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPruefliste_CellValueChanged);
            this.dataGridViewPruefliste.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPruefliste_DataError);
            this.dataGridViewPruefliste.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPruefliste_RowEnter);
            this.dataGridViewPruefliste.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPruefliste_RowLeave);
            this.dataGridViewPruefliste.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewPruefliste_DragDrop);
            this.dataGridViewPruefliste.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewPruefliste_DragOver);
            this.dataGridViewPruefliste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPruefliste_MouseDown);
            this.dataGridViewPruefliste.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPruefliste_MouseMove);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Kritrerium";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // anzeigeartDataGridViewTextBoxColumn
            // 
            this.anzeigeartDataGridViewTextBoxColumn.DataPropertyName = "anzeigeart";
            this.anzeigeartDataGridViewTextBoxColumn.HeaderText = "anzeigeart";
            this.anzeigeartDataGridViewTextBoxColumn.Name = "anzeigeartDataGridViewTextBoxColumn";
            this.anzeigeartDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.anzeigeartDataGridViewTextBoxColumn.Visible = false;
            // 
            // header
            // 
            this.header.HeaderText = "Header";
            this.header.Name = "header";
            // 
            // messwert
            // 
            this.messwert.HeaderText = "Messwert";
            this.messwert.Name = "messwert";
            this.messwert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.messwert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // boolFeld
            // 
            this.boolFeld.HeaderText = "Checkbox";
            this.boolFeld.Name = "boolFeld";
            // 
            // idgeraetetyp
            // 
            this.idgeraetetyp.DataPropertyName = "idgeraetetyp";
            this.idgeraetetyp.HeaderText = "idgeraetetyp";
            this.idgeraetetyp.Name = "idgeraetetyp";
            this.idgeraetetyp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idgeraetetyp.Visible = false;
            // 
            // idkriterium
            // 
            this.idkriterium.DataPropertyName = "idkriterium";
            this.idkriterium.HeaderText = "idkriterium";
            this.idkriterium.Name = "idkriterium";
            this.idkriterium.Visible = false;
            // 
            // pruefkriterienBindingSource
            // 
            this.pruefkriterienBindingSource.DataMember = "pruefkriterien";
            this.pruefkriterienBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruefkriterienTableAdapter
            // 
            this.pruefkriterienTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1063, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(982, 488);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Weiter";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // AddPruefliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 523);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewPruefliste);
            this.Name = "AddPruefliste";
            this.Text = "Prüfliste erstellen";
            this.Load += new System.EventHandler(this.Pruefliste_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AddPruefliste_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPruefliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruefkriterienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPruefliste;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource pruefkriterienBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.pruefkriterienTableAdapter pruefkriterienTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anzeigeartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn header;
        private System.Windows.Forms.DataGridViewTextBoxColumn messwert;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolFeld;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeraetetyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkriterium;
    }
}