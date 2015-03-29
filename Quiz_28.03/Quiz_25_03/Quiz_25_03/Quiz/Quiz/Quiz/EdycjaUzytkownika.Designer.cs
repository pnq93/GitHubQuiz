namespace Quiz
{
    partial class EdycjaUzytkownika
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
            this.listBoxUzytkownicy = new System.Windows.Forms.ListBox();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUzytkownicy
            // 
            this.listBoxUzytkownicy.FormattingEnabled = true;
            this.listBoxUzytkownicy.Location = new System.Drawing.Point(12, 12);
            this.listBoxUzytkownicy.Name = "listBoxUzytkownicy";
            this.listBoxUzytkownicy.Size = new System.Drawing.Size(136, 238);
            this.listBoxUzytkownicy.TabIndex = 0;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(164, 12);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(90, 25);
            this.buttonEdytuj.TabIndex = 1;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // EdycjaUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.listBoxUzytkownicy);
            this.Name = "EdycjaUzytkownika";
            this.Text = "EdycjaUzytkownika";
            this.Load += new System.EventHandler(this.EdycjaUzytkownika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUzytkownicy;
        private System.Windows.Forms.Button buttonEdytuj;
    }
}