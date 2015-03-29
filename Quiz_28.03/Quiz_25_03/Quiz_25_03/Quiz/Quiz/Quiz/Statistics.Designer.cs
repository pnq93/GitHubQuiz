namespace Quiz
{
    partial class Statistics
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
            this.listaStat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listaStat
            // 
            this.listaStat.FormattingEnabled = true;
            this.listaStat.Location = new System.Drawing.Point(12, 10);
            this.listaStat.Name = "listaStat";
            this.listaStat.Size = new System.Drawing.Size(260, 238);
            this.listaStat.TabIndex = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listaStat);
            this.Name = "Statistics";
            this.Text = "Statystyki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaStat;

    }
}