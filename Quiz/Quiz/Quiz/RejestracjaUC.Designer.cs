namespace Quiz
{
    partial class RejestracjaUC
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
            this.dodaj = new System.Windows.Forms.Button();
            this.noweHaslo = new System.Windows.Forms.TextBox();
            this.nowyUzytkownik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Użytkownik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(85, 67);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(100, 25);
            this.dodaj.TabIndex = 9;
            this.dodaj.Text = "Dodaj!";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // noweHaslo
            // 
            this.noweHaslo.Location = new System.Drawing.Point(85, 41);
            this.noweHaslo.Name = "noweHaslo";
            this.noweHaslo.Size = new System.Drawing.Size(100, 20);
            this.noweHaslo.TabIndex = 8;
            // 
            // nowyUzytkownik
            // 
            this.nowyUzytkownik.Location = new System.Drawing.Point(85, 16);
            this.nowyUzytkownik.Name = "nowyUzytkownik";
            this.nowyUzytkownik.Size = new System.Drawing.Size(100, 20);
            this.nowyUzytkownik.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            // 
            // Użytkownik
            // 
            this.Użytkownik.AutoSize = true;
            this.Użytkownik.Location = new System.Drawing.Point(14, 19);
            this.Użytkownik.Name = "Użytkownik";
            this.Użytkownik.Size = new System.Drawing.Size(65, 13);
            this.Użytkownik.TabIndex = 5;
            this.Użytkownik.Text = "Użytkownik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rejestracja";
            // 
            // RejestracjaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.noweHaslo);
            this.Controls.Add(this.nowyUzytkownik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Użytkownik);
            this.Name = "RejestracjaUC";
            this.Size = new System.Drawing.Size(206, 107);
            this.Load += new System.EventHandler(this.RejestracjaUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox noweHaslo;
        private System.Windows.Forms.TextBox nowyUzytkownik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Użytkownik;
        private System.Windows.Forms.Label label1;
    }
}
