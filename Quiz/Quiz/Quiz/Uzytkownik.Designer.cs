namespace Quiz
{
    partial class Uzytkownik
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
            this.obszar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // obszar
            // 
            this.obszar.Location = new System.Drawing.Point(12, 12);
            this.obszar.Name = "obszar";
            this.obszar.Size = new System.Drawing.Size(260, 237);
            this.obszar.TabIndex = 0;
            this.obszar.Text = "";
            this.obszar.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Uzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.obszar);
            this.Name = "Uzytkownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzytkownik";
            this.Load += new System.EventHandler(this.Uzytkownik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox obszar;
    }
}