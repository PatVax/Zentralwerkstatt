namespace Zentralwerkstatt
{
    partial class Geraetetypen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelHersteller = new System.Windows.Forms.Label();
            this.DropDownMenuHersteller = new System.Windows.Forms.ComboBox();
            this.NeuerHerstellerButton = new System.Windows.Forms.Button();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelFooter = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GeraetetypenHinzufuegenButton = new System.Windows.Forms.Button();
            this.GeraetetypenHinzufuegenAbbrechenButton = new System.Windows.Forms.Button();
            this.LabelPrüfliste = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.projektzDataSet = new Zentralwerkstatt.projektzDataSet();
            this.prüfkriterienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prüfkriterienTableAdapter = new Zentralwerkstatt.projektzDataSetTableAdapters.prüfkriterienTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prüfkriterienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LabelHersteller
            // 
            this.LabelHersteller.AutoSize = true;
            this.LabelHersteller.Location = new System.Drawing.Point(13, 52);
            this.LabelHersteller.Name = "LabelHersteller";
            this.LabelHersteller.Size = new System.Drawing.Size(51, 13);
            this.LabelHersteller.TabIndex = 2;
            this.LabelHersteller.Text = "Hersteller";
            // 
            // DropDownMenuHersteller
            // 
            this.DropDownMenuHersteller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMenuHersteller.FormattingEnabled = true;
            this.DropDownMenuHersteller.Location = new System.Drawing.Point(12, 68);
            this.DropDownMenuHersteller.Name = "DropDownMenuHersteller";
            this.DropDownMenuHersteller.Size = new System.Drawing.Size(238, 21);
            this.DropDownMenuHersteller.TabIndex = 3;
            this.DropDownMenuHersteller.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NeuerHerstellerButton
            // 
            this.NeuerHerstellerButton.Location = new System.Drawing.Point(256, 68);
            this.NeuerHerstellerButton.Name = "NeuerHerstellerButton";
            this.NeuerHerstellerButton.Size = new System.Drawing.Size(114, 21);
            this.NeuerHerstellerButton.TabIndex = 5;
            this.NeuerHerstellerButton.Text = "Neuer Hersteller";
            this.NeuerHerstellerButton.UseVisualStyleBackColor = true;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Location = new System.Drawing.Point(13, 92);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(58, 13);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Überschrift";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(358, 60);
            this.textBox2.TabIndex = 7;
            // 
            // LabelFooter
            // 
            this.LabelFooter.AutoSize = true;
            this.LabelFooter.Location = new System.Drawing.Point(13, 171);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(97, 13);
            this.LabelFooter.TabIndex = 8;
            this.LabelFooter.Text = "Schlussbemerkung";
            this.LabelFooter.Click += new System.EventHandler(this.LabelFooter_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 187);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 60);
            this.textBox3.TabIndex = 9;
            // 
            // GeraetetypenHinzufuegenButton
            // 
            this.GeraetetypenHinzufuegenButton.Location = new System.Drawing.Point(12, 269);
            this.GeraetetypenHinzufuegenButton.Name = "GeraetetypenHinzufuegenButton";
            this.GeraetetypenHinzufuegenButton.Size = new System.Drawing.Size(151, 28);
            this.GeraetetypenHinzufuegenButton.TabIndex = 10;
            this.GeraetetypenHinzufuegenButton.Text = "Hinzufügen";
            this.GeraetetypenHinzufuegenButton.UseVisualStyleBackColor = true;
            // 
            // GeraetetypenHinzufuegenAbbrechenButton
            // 
            this.GeraetetypenHinzufuegenAbbrechenButton.Location = new System.Drawing.Point(743, 269);
            this.GeraetetypenHinzufuegenAbbrechenButton.Name = "GeraetetypenHinzufuegenAbbrechenButton";
            this.GeraetetypenHinzufuegenAbbrechenButton.Size = new System.Drawing.Size(151, 28);
            this.GeraetetypenHinzufuegenAbbrechenButton.TabIndex = 11;
            this.GeraetetypenHinzufuegenAbbrechenButton.Text = "Abbrechen";
            this.GeraetetypenHinzufuegenAbbrechenButton.UseVisualStyleBackColor = true;
            this.GeraetetypenHinzufuegenAbbrechenButton.Click += new System.EventHandler(this.GeraetetypenHinzufuegenAbbrechenButton_Click);
            // 
            // LabelPrüfliste
            // 
            this.LabelPrüfliste.AutoSize = true;
            this.LabelPrüfliste.Location = new System.Drawing.Point(376, 13);
            this.LabelPrüfliste.Name = "LabelPrüfliste";
            this.LabelPrüfliste.Size = new System.Drawing.Size(44, 13);
            this.LabelPrüfliste.TabIndex = 12;
            this.LabelPrüfliste.Text = "Prüfliste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.prüfkriterienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(379, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 218);
            this.dataGridView1.TabIndex = 13;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(914, 25);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn1.FillWeight = 500F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Text";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Anzeigeart";
            this.dataGridViewTextBoxColumn2.HeaderText = "Anzeigeart";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Geraetetypen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 319);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LabelPrüfliste);
            this.Controls.Add(this.GeraetetypenHinzufuegenAbbrechenButton);
            this.Controls.Add(this.GeraetetypenHinzufuegenButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LabelFooter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.NeuerHerstellerButton);
            this.Controls.Add(this.DropDownMenuHersteller);
            this.Controls.Add(this.LabelHersteller);
            this.Controls.Add(this.textBox1);
            this.Name = "Geraetetypen";
            this.Text = "Gerätetypen hinzufügen";
            this.Load += new System.EventHandler(this.Geraetetypen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prüfkriterienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelHersteller;
        private System.Windows.Forms.Button NeuerHerstellerButton;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LabelFooter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button GeraetetypenHinzufuegenButton;
        private System.Windows.Forms.Button GeraetetypenHinzufuegenAbbrechenButton;
        private System.Windows.Forms.Label LabelPrüfliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox DropDownMenuHersteller;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private projektzDataSet projektzDataSet;
        private System.Windows.Forms.BindingSource prüfkriterienBindingSource;
        private projektzDataSetTableAdapters.prüfkriterienTableAdapter prüfkriterienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}