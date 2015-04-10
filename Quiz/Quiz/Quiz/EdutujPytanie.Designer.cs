namespace Quiz
{
    partial class EdutujPytanie
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
            this.listBoxPytania = new System.Windows.Forms.ListBox();
            this.textBoxPytanie = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.numericUpDownPoziom = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.comboBoxIleOdp = new System.Windows.Forms.ComboBox();
            this.buttonDodajOdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoziom)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPytania
            // 
            this.listBoxPytania.FormattingEnabled = true;
            this.listBoxPytania.ItemHeight = 16;
            this.listBoxPytania.Location = new System.Drawing.Point(16, 15);
            this.listBoxPytania.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPytania.Name = "listBoxPytania";
            this.listBoxPytania.Size = new System.Drawing.Size(201, 340);
            this.listBoxPytania.TabIndex = 0;
            // 
            // textBoxPytanie
            // 
            this.textBoxPytanie.Location = new System.Drawing.Point(259, 15);
            this.textBoxPytanie.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPytanie.Name = "textBoxPytanie";
            this.textBoxPytanie.Size = new System.Drawing.Size(475, 22);
            this.textBoxPytanie.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(259, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 177);
            this.panel1.TabIndex = 2;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(16, 368);
            this.buttonEdytuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(135, 42);
            this.buttonEdytuj.TabIndex = 3;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // numericUpDownPoziom
            // 
            this.numericUpDownPoziom.Location = new System.Drawing.Point(353, 47);
            this.numericUpDownPoziom.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPoziom.Name = "numericUpDownPoziom";
            this.numericUpDownPoziom.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownPoziom.TabIndex = 0;
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(353, 79);
            this.comboBoxKategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(207, 24);
            this.comboBoxKategoria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Poziom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategoria";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(159, 368);
            this.buttonZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(135, 42);
            this.buttonZapisz.TabIndex = 7;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(301, 368);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(135, 42);
            this.buttonUsun.TabIndex = 8;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // comboBoxIleOdp
            // 
            this.comboBoxIleOdp.FormattingEnabled = true;
            this.comboBoxIleOdp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxIleOdp.Location = new System.Drawing.Point(353, 112);
            this.comboBoxIleOdp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIleOdp.Name = "comboBoxIleOdp";
            this.comboBoxIleOdp.Size = new System.Drawing.Size(96, 24);
            this.comboBoxIleOdp.TabIndex = 9;
            // 
            // buttonDodajOdp
            // 
            this.buttonDodajOdp.Location = new System.Drawing.Point(476, 110);
            this.buttonDodajOdp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajOdp.Name = "buttonDodajOdp";
            this.buttonDodajOdp.Size = new System.Drawing.Size(155, 28);
            this.buttonDodajOdp.TabIndex = 10;
            this.buttonDodajOdp.Text = "Dodaj odpowiedź";
            this.buttonDodajOdp.UseVisualStyleBackColor = true;
            this.buttonDodajOdp.Click += new System.EventHandler(this.buttonDodajOdp_Click);
            // 
            // EdutujPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 425);
            this.Controls.Add(this.buttonDodajOdp);
            this.Controls.Add(this.comboBoxIleOdp);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKategoria);
            this.Controls.Add(this.numericUpDownPoziom);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPytanie);
            this.Controls.Add(this.listBoxPytania);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EdutujPytanie";
            this.Text = "EdutujPytanie";
            this.Load += new System.EventHandler(this.EdutujPytanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoziom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPytania;
        private System.Windows.Forms.TextBox textBoxPytanie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.NumericUpDown numericUpDownPoziom;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ComboBox comboBoxIleOdp;
        private System.Windows.Forms.Button buttonDodajOdp;
    }
}