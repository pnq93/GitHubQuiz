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
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.numericUpDownPoziom = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.comboBoxIleOdp = new System.Windows.Forms.ComboBox();
            this.buttonDodajOdp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCzysc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUsunOdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoziom)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPytania
            // 
            this.listBoxPytania.FormattingEnabled = true;
            this.listBoxPytania.Location = new System.Drawing.Point(12, 12);
            this.listBoxPytania.Name = "listBoxPytania";
            this.listBoxPytania.Size = new System.Drawing.Size(152, 277);
            this.listBoxPytania.TabIndex = 0;
            // 
            // textBoxPytanie
            // 
            this.textBoxPytanie.Location = new System.Drawing.Point(241, 9);
            this.textBoxPytanie.Name = "textBoxPytanie";
            this.textBoxPytanie.Size = new System.Drawing.Size(304, 20);
            this.textBoxPytanie.TabIndex = 1;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(12, 299);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(101, 34);
            this.buttonEdytuj.TabIndex = 3;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // numericUpDownPoziom
            // 
            this.numericUpDownPoziom.Location = new System.Drawing.Point(241, 39);
            this.numericUpDownPoziom.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPoziom.Name = "numericUpDownPoziom";
            this.numericUpDownPoziom.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownPoziom.TabIndex = 0;
            this.numericUpDownPoziom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Items.AddRange(new object[] {
            "Sport",
            "Matematyka",
            "Informatyka",
            "Przyroda",
            "J.Polski",
            "Kultura",
            "Muzyka ",
            "Geografia"});
            this.comboBoxKategoria.Location = new System.Drawing.Point(241, 65);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(156, 21);
            this.comboBoxKategoria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Poziom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategoria";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(119, 299);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(101, 34);
            this.buttonZapisz.TabIndex = 7;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            this.buttonZapisz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonZapisz_MouseClick);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(226, 299);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(101, 34);
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
            this.comboBoxIleOdp.Location = new System.Drawing.Point(276, 96);
            this.comboBoxIleOdp.Name = "comboBoxIleOdp";
            this.comboBoxIleOdp.Size = new System.Drawing.Size(44, 21);
            this.comboBoxIleOdp.TabIndex = 9;
            // 
            // buttonDodajOdp
            // 
            this.buttonDodajOdp.Location = new System.Drawing.Point(333, 94);
            this.buttonDodajOdp.Name = "buttonDodajOdp";
            this.buttonDodajOdp.Size = new System.Drawing.Size(116, 23);
            this.buttonDodajOdp.TabIndex = 10;
            this.buttonDodajOdp.Text = "Dodaj odpowiedź";
            this.buttonDodajOdp.UseVisualStyleBackColor = true;
            this.buttonDodajOdp.Click += new System.EventHandler(this.buttonDodajOdp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pytanie";
            // 
            // buttonCzysc
            // 
            this.buttonCzysc.Location = new System.Drawing.Point(333, 299);
            this.buttonCzysc.Name = "buttonCzysc";
            this.buttonCzysc.Size = new System.Drawing.Size(101, 34);
            this.buttonCzysc.TabIndex = 12;
            this.buttonCzysc.Text = "Czyść pola ";
            this.buttonCzysc.UseVisualStyleBackColor = true;
            this.buttonCzysc.Click += new System.EventHandler(this.buttonCzysc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ilość odpowiedzi";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoScroll = true;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(185, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 166);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonUsunOdp
            // 
            this.buttonUsunOdp.Location = new System.Drawing.Point(454, 305);
            this.buttonUsunOdp.Name = "buttonUsunOdp";
            this.buttonUsunOdp.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunOdp.TabIndex = 15;
            this.buttonUsunOdp.Text = "Usun odp";
            this.buttonUsunOdp.UseVisualStyleBackColor = true;
            this.buttonUsunOdp.Click += new System.EventHandler(this.buttonUsunOdp_Click);
            // 
            // EdutujPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 345);
            this.Controls.Add(this.buttonUsunOdp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCzysc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDodajOdp);
            this.Controls.Add(this.comboBoxIleOdp);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKategoria);
            this.Controls.Add(this.numericUpDownPoziom);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.textBoxPytanie);
            this.Controls.Add(this.listBoxPytania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.NumericUpDown numericUpDownPoziom;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ComboBox comboBoxIleOdp;
        private System.Windows.Forms.Button buttonDodajOdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCzysc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Button buttonUsunOdp;
    }
}