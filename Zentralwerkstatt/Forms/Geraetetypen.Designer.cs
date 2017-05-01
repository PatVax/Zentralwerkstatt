using Zentralwerkstatt.DataSets;

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
            this.herstellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektZDataSet = new Zentralwerkstatt.DataSets.ProjektZDataSet();
            this.NeuerHerstellerButton = new System.Windows.Forms.Button();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelFooter = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GeraetetypenHinzufuegenButton = new System.Windows.Forms.Button();
            this.GeraetetypenHinzufuegenAbbrechenButton = new System.Windows.Forms.Button();
            this.LabelBezeichnung = new System.Windows.Forms.Label();
            this.herstellerTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fahrzeugestandorteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNeuesFahrzeug = new System.Windows.Forms.Button();
            this.fahrzeuge_standorteTableAdapter = new Zentralwerkstatt.DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 20);
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
            this.DropDownMenuHersteller.TabIndex = 2;
            this.DropDownMenuHersteller.ValueMember = "Bezeichnung";
            // 
            // herstellerBindingSource
            // 
            this.herstellerBindingSource.DataMember = "Hersteller";
            this.herstellerBindingSource.DataSource = this.projektZDataSet;
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "DataSets.ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NeuerHerstellerButton
            // 
            this.NeuerHerstellerButton.Location = new System.Drawing.Point(363, 68);
            this.NeuerHerstellerButton.Name = "NeuerHerstellerButton";
            this.NeuerHerstellerButton.Size = new System.Drawing.Size(122, 21);
            this.NeuerHerstellerButton.TabIndex = 3;
            this.NeuerHerstellerButton.Text = "Hersteller bearbeiten";
            this.NeuerHerstellerButton.UseVisualStyleBackColor = true;
            this.NeuerHerstellerButton.Click += new System.EventHandler(this.NeuerHerstellerButton_Click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Location = new System.Drawing.Point(13, 119);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(58, 13);
            this.LabelHeader.TabIndex = 5;
            this.LabelHeader.Text = "Überschrift";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 135);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 60);
            this.textBox2.TabIndex = 4;
            // 
            // LabelFooter
            // 
            this.LabelFooter.AutoSize = true;
            this.LabelFooter.Location = new System.Drawing.Point(13, 198);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(97, 13);
            this.LabelFooter.TabIndex = 7;
            this.LabelFooter.Text = "Schlussbemerkung";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 214);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(473, 60);
            this.textBox3.TabIndex = 5;
            // 
            // GeraetetypenHinzufuegenButton
            // 
            this.GeraetetypenHinzufuegenButton.Location = new System.Drawing.Point(12, 280);
            this.GeraetetypenHinzufuegenButton.Name = "GeraetetypenHinzufuegenButton";
            this.GeraetetypenHinzufuegenButton.Size = new System.Drawing.Size(154, 28);
            this.GeraetetypenHinzufuegenButton.TabIndex = 6;
            this.GeraetetypenHinzufuegenButton.Text = "Hinzufügen";
            this.GeraetetypenHinzufuegenButton.UseVisualStyleBackColor = true;
            this.GeraetetypenHinzufuegenButton.Click += new System.EventHandler(this.GeraetetypenHinzufuegenButton_Click);
            // 
            // GeraetetypenHinzufuegenAbbrechenButton
            // 
            this.GeraetetypenHinzufuegenAbbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GeraetetypenHinzufuegenAbbrechenButton.Location = new System.Drawing.Point(331, 280);
            this.GeraetetypenHinzufuegenAbbrechenButton.Name = "GeraetetypenHinzufuegenAbbrechenButton";
            this.GeraetetypenHinzufuegenAbbrechenButton.Size = new System.Drawing.Size(154, 28);
            this.GeraetetypenHinzufuegenAbbrechenButton.TabIndex = 8;
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
            // 
            // herstellerTableAdapter
            // 
            this.herstellerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fahrzeugestandorteBindingSource;
            this.comboBox1.DisplayMember = "tostring";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "tostring";
            // 
            // fahrzeugestandorteBindingSource
            // 
            this.fahrzeugestandorteBindingSource.DataMember = "fahrzeuge_standorte";
            this.fahrzeugestandorteBindingSource.DataSource = this.projektZDataSet;
            // 
            // btnNeuesFahrzeug
            // 
            this.btnNeuesFahrzeug.Location = new System.Drawing.Point(363, 95);
            this.btnNeuesFahrzeug.Name = "btnNeuesFahrzeug";
            this.btnNeuesFahrzeug.Size = new System.Drawing.Size(122, 23);
            this.btnNeuesFahrzeug.TabIndex = 17;
            this.btnNeuesFahrzeug.Text = "Fahrzeuge bearbeiten";
            this.btnNeuesFahrzeug.UseVisualStyleBackColor = true;
            this.btnNeuesFahrzeug.Click += new System.EventHandler(this.btnNeuesFahrzeug_Click);
            // 
            // fahrzeuge_standorteTableAdapter
            // 
            this.fahrzeuge_standorteTableAdapter.ClearBeforeFill = true;
            // 
            // Geraetetypen
            // 
            this.AcceptButton = this.GeraetetypenHinzufuegenButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GeraetetypenHinzufuegenAbbrechenButton;
            this.ClientSize = new System.Drawing.Size(497, 318);
            this.Controls.Add(this.btnNeuesFahrzeug);
            this.Controls.Add(this.comboBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Geraetetypen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Geraetetypen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.herstellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugestandorteBindingSource)).EndInit();
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
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource herstellerBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.herstellerTableAdapter herstellerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNeuesFahrzeug;
        private System.Windows.Forms.BindingSource fahrzeugestandorteBindingSource;
        private DataSets.ProjektZDataSetTableAdapters.fahrzeuge_standorteTableAdapter fahrzeuge_standorteTableAdapter;
    }
}