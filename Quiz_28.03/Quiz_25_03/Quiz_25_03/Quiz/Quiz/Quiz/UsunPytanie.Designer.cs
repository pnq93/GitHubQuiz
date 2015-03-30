namespace Quiz
{
    partial class UsunPytanie
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
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPytania
            // 
            this.listBoxPytania.FormattingEnabled = true;
            this.listBoxPytania.Location = new System.Drawing.Point(12, 12);
            this.listBoxPytania.Name = "listBoxPytania";
            this.listBoxPytania.Size = new System.Drawing.Size(259, 186);
            this.listBoxPytania.TabIndex = 0;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(12, 218);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(93, 28);
            this.buttonUsun.TabIndex = 1;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // UsunPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 289);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.listBoxPytania);
            this.Name = "UsunPytanie";
            this.Text = "UsunPytanie";
            this.Load += new System.EventHandler(this.UsunPytanie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPytania;
        private System.Windows.Forms.Button buttonUsun;
    }
}