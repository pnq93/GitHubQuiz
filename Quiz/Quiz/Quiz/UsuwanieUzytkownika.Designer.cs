namespace Quiz
{
    partial class UsuwanieUzytkownika
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
            this.usun = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(200, 202);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(85, 52);
            this.usun.TabIndex = 1;
            this.usun.Text = "Usuń użytkownika";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 238);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // UsuwanieUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 269);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.usun);
            this.Name = "UsuwanieUzytkownika";
            this.Text = "Usuwanie Uzytkownika";
            this.Load += new System.EventHandler(this.UsuwanieUzytkownika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.ListBox listBox1;
    }
}