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
            this.LabelBezeichnung = new System.Windows.Forms.Label();
            this.HerstellerAktualisieren = new System.Windows.Forms.Button();
            this.projektZDataSet = new Zentralwerkstatt.ProjektZDataSet();
            this.herstellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herstellerTableAdapter = new Zentralwerkstatt.ProjektZDataSetTableAdapters.herstellerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
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
            this.DropDownMenuHersteller.DataSource = this.herstellerBindingSource;
            this.DropDownMenuHersteller.DisplayMember = "Bezeichnung";
            this.DropDownMenuHersteller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMenuHersteller.FormattingEnabled = true;
            this.DropDownMenuHersteller.Location = new System.Drawing.Point(12, 68);
            this.DropDownMenuHersteller.Name = "DropDownMenuHersteller";
            this.DropDownMenuHersteller.Size = new System.Drawing.Size(345, 21);
            this.DropDownMenuHersteller.TabIndex = 3;
            this.DropDownMenuHersteller.ValueMember = "Bezeichnung";
            this.DropDownMenuHersteller.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NeuerHerstellerButton
            // 
            this.NeuerHerstellerButton.Location = new System.Drawing.Point(363, 68);
            this.NeuerHerstellerButton.Name = "NeuerHerstellerButton";
            this.NeuerHerstellerButton.Size = new System.Drawing.Size(114, 21);
            this.NeuerHerstellerButton.TabIndex = 5;
            this.NeuerHerstellerButton.Text = "Hersteller bearbeiten";
            this.NeuerHerstellerButton.UseVisualStyleBackColor = true;
            this.NeuerHerstellerButton.Click += new System.EventHandler(this.NeuerHerstellerButton_Click);
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
            this.textBox2.Size = new System.Drawing.Size(465, 60);
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
            this.textBox3.Size = new System.Drawing.Size(465, 60);
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
            this.GeraetetypenHinzufuegenButton.Click += new System.EventHandler(this.GeraetetypenHinzufuegenButton_Click);
            // 
            // GeraetetypenHinzufuegenAbbrechenButton
            // 
            this.GeraetetypenHinzufuegenAbbrechenButton.Location = new System.Drawing.Point(326, 269);
            this.GeraetetypenHinzufuegenAbbrechenButton.Name = "GeraetetypenHinzufuegenAbbrechenButton";
            this.GeraetetypenHinzufuegenAbbrechenButton.Size = new System.Drawing.Size(151, 28);
            this.GeraetetypenHinzufuegenAbbrechenButton.TabIndex = 11;
            this.GeraetetypenHinzufuegenAbbrechenButton.Text = "Abbrechen";
            this.GeraetetypenHinzufuegenAbbrechenButton.UseVisualStyleBackColor = true;
            this.GeraetetypenHinzufuegenAbbrechenButton.Click += new System.EventHandler(this.GeraetetypenHinzufuegenAbbrechenButton_Click);
            // 
            // LabelBezeichnung
            // 
            this.LabelBezeichnung.AutoSize = true;
            this.LabelBezeichnung.Location = new System.Drawing.Point(13, 9);
            this.LabelBezeichnung.Name = "LabelBezeichnung";
            this.LabelBezeichnung.Size = new System.Drawing.Size(94, 13);
            this.LabelBezeichnung.TabIndex = 15;
            this.LabelBezeichnung.Text = "Gerätbezeichnung";
            this.LabelBezeichnung.Click += new System.EventHandler(this.LabelBezeichnung_Click);
            // 
            // HerstellerAktualisieren
            // 
            this.HerstellerAktualisieren.Location = new System.Drawing.Point(169, 269);
            this.HerstellerAktualisieren.Name = "HerstellerAktualisieren";
            this.HerstellerAktualisieren.Size = new System.Drawing.Size(151, 28);
            this.HerstellerAktualisieren.TabIndex = 16;
            this.HerstellerAktualisieren.Text = "Hersteller aktualisieren";
            this.HerstellerAktualisieren.UseVisualStyleBackColor = true;
            this.HerstellerAktualisieren.Click += new System.EventHandler(this.HerstellerAktualisieren_Click);
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
            // Geraetetypen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 319);
            this.Controls.Add(this.HerstellerAktualisieren);
            this.Controls.Add(this.LabelBezeichnung);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.Geraetetypen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox DropDownMenuHersteller;
        private System.Windows.Forms.Label LabelBezeichnung;
        private System.Windows.Forms.Button HerstellerAktualisieren;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource herstellerBindingSource;
        private ProjektZDataSetTableAdapters.herstellerTableAdapter herstellerTableAdapter;
    }
}