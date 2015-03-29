namespace Quiz
{
    partial class DodajPytanie
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
            this.zapiszPytanie = new System.Windows.Forms.Button();
            this.tresc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPoziom = new System.Windows.Forms.NumericUpDown();
            this.kategoriaPytania = new System.Windows.Forms.ComboBox();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxIleOdp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoziom)).BeginInit();
            this.SuspendLayout();
            // 
            // zapiszPytanie
            // 
            this.zapiszPytanie.Location = new System.Drawing.Point(171, 234);
            this.zapiszPytanie.Name = "zapiszPytanie";
            this.zapiszPytanie.Size = new System.Drawing.Size(102, 49);
            this.zapiszPytanie.TabIndex = 0;
            this.zapiszPytanie.Text = "Zapisz!";
            this.zapiszPytanie.UseVisualStyleBackColor = true;
            this.zapiszPytanie.Click += new System.EventHandler(this.zapiszPytanie_Click);
            // 
            // tresc
            // 
            this.tresc.Location = new System.Drawing.Point(52, 18);
            this.tresc.Name = "tresc";
            this.tresc.Size = new System.Drawing.Size(220, 20);
            this.tresc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Poziom pytania: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pytanie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Odpowiedzi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategoria:";
            // 
            // numericUpDownPoziom
            // 
            this.numericUpDownPoziom.Location = new System.Drawing.Point(94, 236);
            this.numericUpDownPoziom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPoziom.Name = "numericUpDownPoziom";
            this.numericUpDownPoziom.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownPoziom.TabIndex = 16;
            // 
            // kategoriaPytania
            // 
            this.kategoriaPytania.FormattingEnabled = true;
            this.kategoriaPytania.Items.AddRange(new object[] {
            "Sport",
            "Muzyka",
            "Informatyka",
            "Matematyka",
            "Przyroda",
            "Geografia"});
            this.kategoriaPytania.Location = new System.Drawing.Point(65, 262);
            this.kategoriaPytania.Name = "kategoriaPytania";
            this.kategoriaPytania.Size = new System.Drawing.Size(98, 21);
            this.kategoriaPytania.TabIndex = 17;
            // 
            // buttonGeneruj
            // 
            this.buttonGeneruj.Location = new System.Drawing.Point(200, 54);
            this.buttonGeneruj.Name = "buttonGeneruj";
            this.buttonGeneruj.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneruj.TabIndex = 18;
            this.buttonGeneruj.Text = "Generuj";
            this.buttonGeneruj.UseVisualStyleBackColor = true;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ilość odpowiedzi";
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
            this.comboBoxIleOdp.Location = new System.Drawing.Point(140, 56);
            this.comboBoxIleOdp.Name = "comboBoxIleOdp";
            this.comboBoxIleOdp.Size = new System.Drawing.Size(33, 21);
            this.comboBoxIleOdp.TabIndex = 21;
            this.comboBoxIleOdp.SelectedIndexChanged += new System.EventHandler(this.comboBoxIleOdp_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(10, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 110);
            this.panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(303, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 82);
            this.listBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 64);
            this.button1.TabIndex = 24;
            this.button1.Text = "JAK TU KLIKNIESZ TO CI SIE POKAZA DODANE PYTANIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(294, 175);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(210, 108);
            this.listBox2.TabIndex = 25;
            // 
            // DodajPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 295);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxIleOdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGeneruj);
            this.Controls.Add(this.kategoriaPytania);
            this.Controls.Add(this.numericUpDownPoziom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tresc);
            this.Controls.Add(this.zapiszPytanie);
            this.Name = "DodajPytanie";
            this.Text = "DodajPytanie";
            this.Load += new System.EventHandler(this.DodajPytanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoziom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zapiszPytanie;
        private System.Windows.Forms.TextBox tresc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPoziom;
        private System.Windows.Forms.ComboBox kategoriaPytania;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIleOdp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
    }
}