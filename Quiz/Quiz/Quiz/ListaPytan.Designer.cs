namespace Quiz
{
    partial class ListaPytan
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
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPytania
            // 
            this.listBoxPytania.FormattingEnabled = true;
            this.listBoxPytania.Location = new System.Drawing.Point(12, 12);
            this.listBoxPytania.Name = "listBoxPytania";
            this.listBoxPytania.Size = new System.Drawing.Size(260, 212);
            this.listBoxPytania.TabIndex = 0;
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(12, 230);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 1;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // ListaPytan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.listBoxPytania);
            this.Name = "ListaPytan";
            this.Text = "ListaPytan";
            this.Load += new System.EventHandler(this.ListaPytan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPytania;
        private System.Windows.Forms.Button buttonEdytuj;

    }
}