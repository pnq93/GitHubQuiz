namespace Quiz
{
    partial class EdycjaOdpowiedzi
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
            this.textBoxEdycjaOdpowiedzi = new System.Windows.Forms.TextBox();
            this.buttonZapiszOdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEdycjaOdpowiedzi
            // 
            this.textBoxEdycjaOdpowiedzi.Location = new System.Drawing.Point(12, 12);
            this.textBoxEdycjaOdpowiedzi.Name = "textBoxEdycjaOdpowiedzi";
            this.textBoxEdycjaOdpowiedzi.Size = new System.Drawing.Size(269, 20);
            this.textBoxEdycjaOdpowiedzi.TabIndex = 0;
            // 
            // buttonZapiszOdp
            // 
            this.buttonZapiszOdp.Location = new System.Drawing.Point(99, 39);
            this.buttonZapiszOdp.Name = "buttonZapiszOdp";
            this.buttonZapiszOdp.Size = new System.Drawing.Size(75, 23);
            this.buttonZapiszOdp.TabIndex = 1;
            this.buttonZapiszOdp.Text = "Zapisz!";
            this.buttonZapiszOdp.UseVisualStyleBackColor = true;
            this.buttonZapiszOdp.Click += new System.EventHandler(this.buttonZapiszOdp_Click);
            // 
            // EdycjaOdpowiedzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 74);
            this.Controls.Add(this.buttonZapiszOdp);
            this.Controls.Add(this.textBoxEdycjaOdpowiedzi);
            this.Name = "EdycjaOdpowiedzi";
            this.Text = "EdycjaOdpowiedzi";
            this.Load += new System.EventHandler(this.EdycjaOdpowiedzi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEdycjaOdpowiedzi;
        private System.Windows.Forms.Button buttonZapiszOdp;
    }
}