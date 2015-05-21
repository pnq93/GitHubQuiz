namespace Quiz
{
    partial class EdytujKategorie
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
            this.textBoxKategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKategoria
            // 
            this.textBoxKategoria.Location = new System.Drawing.Point(61, 12);
            this.textBoxKategoria.Name = "textBoxKategoria";
            this.textBoxKategoria.Size = new System.Drawing.Size(166, 20);
            this.textBoxKategoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa:";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.Color.Lavender;
            this.buttonZapisz.Location = new System.Drawing.Point(96, 38);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 2;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // EdytujKategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(239, 65);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKategoria);
            this.Name = "EdytujKategorie";
            this.Text = "EdytujKategorie";
            this.Load += new System.EventHandler(this.EdytujKategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZapisz;
    }
}