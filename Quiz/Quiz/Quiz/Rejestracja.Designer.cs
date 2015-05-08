namespace Quiz
{
    partial class Rejestracja
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
            this.Użytkownik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nowyUzytkownik = new System.Windows.Forms.TextBox();
            this.noweHaslo = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Użytkownik
            // 
            this.Użytkownik.AutoSize = true;
            this.Użytkownik.Location = new System.Drawing.Point(12, 50);
            this.Użytkownik.Name = "Użytkownik";
            this.Użytkownik.Size = new System.Drawing.Size(65, 13);
            this.Użytkownik.TabIndex = 0;
            this.Użytkownik.Text = "Użytkownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // nowyUzytkownik
            // 
            this.nowyUzytkownik.Location = new System.Drawing.Point(76, 47);
            this.nowyUzytkownik.Name = "nowyUzytkownik";
            this.nowyUzytkownik.Size = new System.Drawing.Size(100, 20);
            this.nowyUzytkownik.TabIndex = 2;
            // 
            // noweHaslo
            // 
            this.noweHaslo.Location = new System.Drawing.Point(76, 73);
            this.noweHaslo.Name = "noweHaslo";
            this.noweHaslo.Size = new System.Drawing.Size(100, 20);
            this.noweHaslo.TabIndex = 3;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(56, 115);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(100, 30);
            this.dodaj.TabIndex = 4;
            this.dodaj.Text = "Dodaj!";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 157);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.noweHaslo);
            this.Controls.Add(this.nowyUzytkownik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Użytkownik);
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Użytkownik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nowyUzytkownik;
        private System.Windows.Forms.TextBox noweHaslo;
        private System.Windows.Forms.Button dodaj;
    }
}