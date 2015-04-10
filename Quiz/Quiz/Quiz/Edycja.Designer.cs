namespace Quiz
{
    partial class Edycja
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
            this.textBoxUzytkownik = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxAdmin = new System.Windows.Forms.TextBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.radioButtonUzytkownik = new System.Windows.Forms.RadioButton();
            this.radioButtonHaslo = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxUzytkownik
            // 
            this.textBoxUzytkownik.Enabled = false;
            this.textBoxUzytkownik.Location = new System.Drawing.Point(129, 12);
            this.textBoxUzytkownik.Name = "textBoxUzytkownik";
            this.textBoxUzytkownik.Size = new System.Drawing.Size(100, 20);
            this.textBoxUzytkownik.TabIndex = 0;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Enabled = false;
            this.textBoxHaslo.Location = new System.Drawing.Point(129, 38);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHaslo.TabIndex = 1;
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Enabled = false;
            this.textBoxAdmin.Location = new System.Drawing.Point(129, 64);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdmin.TabIndex = 2;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(90, 93);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 6;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // radioButtonUzytkownik
            // 
            this.radioButtonUzytkownik.AutoSize = true;
            this.radioButtonUzytkownik.Location = new System.Drawing.Point(12, 15);
            this.radioButtonUzytkownik.Name = "radioButtonUzytkownik";
            this.radioButtonUzytkownik.Size = new System.Drawing.Size(83, 17);
            this.radioButtonUzytkownik.TabIndex = 7;
            this.radioButtonUzytkownik.TabStop = true;
            this.radioButtonUzytkownik.Text = "Użytkownik:";
            this.radioButtonUzytkownik.UseVisualStyleBackColor = true;
            this.radioButtonUzytkownik.CheckedChanged += new System.EventHandler(this.radioButtonUzytkownik_CheckedChanged);
            // 
            // radioButtonHaslo
            // 
            this.radioButtonHaslo.AutoSize = true;
            this.radioButtonHaslo.Location = new System.Drawing.Point(12, 41);
            this.radioButtonHaslo.Name = "radioButtonHaslo";
            this.radioButtonHaslo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHaslo.TabIndex = 8;
            this.radioButtonHaslo.TabStop = true;
            this.radioButtonHaslo.Text = "Hasło:";
            this.radioButtonHaslo.UseVisualStyleBackColor = true;
            this.radioButtonHaslo.CheckedChanged += new System.EventHandler(this.radioButtonHaslo_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(12, 67);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(76, 17);
            this.radioButtonAdmin.TabIndex = 9;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Czy admin:";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // Edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 128);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonHaslo);
            this.Controls.Add(this.radioButtonUzytkownik);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.textBoxAdmin);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxUzytkownik);
            this.Name = "Edycja";
            this.Text = "Edycja";
            this.Load += new System.EventHandler(this.Edycja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUzytkownik;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxAdmin;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.RadioButton radioButtonUzytkownik;
        private System.Windows.Forms.RadioButton radioButtonHaslo;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}