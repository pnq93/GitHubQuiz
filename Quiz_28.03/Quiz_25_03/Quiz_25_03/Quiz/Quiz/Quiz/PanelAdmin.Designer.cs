namespace Quiz
{
    partial class PanelAdmin
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
            this.dodaj_pyt = new System.Windows.Forms.Button();
            this.usun_uzyt = new System.Windows.Forms.Button();
            this.dodAdmin = new System.Windows.Forms.Button();
            this.edycja = new System.Windows.Forms.Button();
            this.buttonEdycjaPytania = new System.Windows.Forms.Button();
            this.buttonUsunPytanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj_pyt
            // 
            this.dodaj_pyt.Location = new System.Drawing.Point(31, 12);
            this.dodaj_pyt.Name = "dodaj_pyt";
            this.dodaj_pyt.Size = new System.Drawing.Size(75, 44);
            this.dodaj_pyt.TabIndex = 0;
            this.dodaj_pyt.Text = "Dodaj pytanie";
            this.dodaj_pyt.UseVisualStyleBackColor = true;
            this.dodaj_pyt.Click += new System.EventHandler(this.dodaj_pyt_Click);
            // 
            // usun_uzyt
            // 
            this.usun_uzyt.Location = new System.Drawing.Point(112, 12);
            this.usun_uzyt.Name = "usun_uzyt";
            this.usun_uzyt.Size = new System.Drawing.Size(75, 44);
            this.usun_uzyt.TabIndex = 1;
            this.usun_uzyt.Text = "Usuń użytkownika";
            this.usun_uzyt.UseVisualStyleBackColor = true;
            this.usun_uzyt.Click += new System.EventHandler(this.usun_uzyt_Click);
            // 
            // dodAdmin
            // 
            this.dodAdmin.Location = new System.Drawing.Point(193, 12);
            this.dodAdmin.Name = "dodAdmin";
            this.dodAdmin.Size = new System.Drawing.Size(75, 44);
            this.dodAdmin.TabIndex = 2;
            this.dodAdmin.Text = "Dodaj administratora";
            this.dodAdmin.UseVisualStyleBackColor = true;
            this.dodAdmin.Click += new System.EventHandler(this.dodAdmin_Click);
            // 
            // edycja
            // 
            this.edycja.Location = new System.Drawing.Point(31, 62);
            this.edycja.Name = "edycja";
            this.edycja.Size = new System.Drawing.Size(75, 44);
            this.edycja.TabIndex = 3;
            this.edycja.Text = "Edycja użytkownika";
            this.edycja.UseVisualStyleBackColor = true;
            this.edycja.Click += new System.EventHandler(this.edycja_Click);
            // 
            // buttonEdycjaPytania
            // 
            this.buttonEdycjaPytania.Location = new System.Drawing.Point(112, 62);
            this.buttonEdycjaPytania.Name = "buttonEdycjaPytania";
            this.buttonEdycjaPytania.Size = new System.Drawing.Size(75, 46);
            this.buttonEdycjaPytania.TabIndex = 4;
            this.buttonEdycjaPytania.Text = "Edycja pytania";
            this.buttonEdycjaPytania.UseVisualStyleBackColor = true;
            this.buttonEdycjaPytania.Click += new System.EventHandler(this.buttonEdycjaPytania_Click);
            // 
            // buttonUsunPytanie
            // 
            this.buttonUsunPytanie.Location = new System.Drawing.Point(193, 62);
            this.buttonUsunPytanie.Name = "buttonUsunPytanie";
            this.buttonUsunPytanie.Size = new System.Drawing.Size(75, 46);
            this.buttonUsunPytanie.TabIndex = 5;
            this.buttonUsunPytanie.Text = "Usuń pytanie";
            this.buttonUsunPytanie.UseVisualStyleBackColor = true;
            this.buttonUsunPytanie.Click += new System.EventHandler(this.buttonUsunPytanie_Click);
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 114);
            this.Controls.Add(this.buttonUsunPytanie);
            this.Controls.Add(this.buttonEdycjaPytania);
            this.Controls.Add(this.edycja);
            this.Controls.Add(this.dodAdmin);
            this.Controls.Add(this.usun_uzyt);
            this.Controls.Add(this.dodaj_pyt);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj_pyt;
        private System.Windows.Forms.Button usun_uzyt;
        private System.Windows.Forms.Button dodAdmin;
        private System.Windows.Forms.Button edycja;
        private System.Windows.Forms.Button buttonEdycjaPytania;
        private System.Windows.Forms.Button buttonUsunPytanie;
    }
}