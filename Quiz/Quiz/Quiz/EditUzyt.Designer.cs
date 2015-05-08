namespace Quiz
{
    partial class EditUzyt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxuzytkownicy = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxuzytkownicy
            // 
            this.listBoxuzytkownicy.FormattingEnabled = true;
            this.listBoxuzytkownicy.Location = new System.Drawing.Point(0, 29);
            this.listBoxuzytkownicy.Name = "listBoxuzytkownicy";
            this.listBoxuzytkownicy.Size = new System.Drawing.Size(237, 199);
            this.listBoxuzytkownicy.TabIndex = 0;
            this.listBoxuzytkownicy.SelectedIndexChanged += new System.EventHandler(this.listBoxuzytkownicy_SelectedIndexChanged);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(0, 0);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(81, 0);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 2;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(162, 0);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // EditUzyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxuzytkownicy);
            this.Name = "EditUzyt";
            this.Size = new System.Drawing.Size(244, 240);
            this.Load += new System.EventHandler(this.EditUzyt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxuzytkownicy;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonUsun;
    }
}
