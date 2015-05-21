namespace Quiz
{
    partial class Statystyka
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
            this.richTextBoxStat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxStat
            // 
            this.richTextBoxStat.Enabled = false;
            this.richTextBoxStat.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxStat.Name = "richTextBoxStat";
            this.richTextBoxStat.Size = new System.Drawing.Size(274, 122);
            this.richTextBoxStat.TabIndex = 0;
            this.richTextBoxStat.Text = "";
            this.richTextBoxStat.TextChanged += new System.EventHandler(this.richTextBoxStat_TextChanged);
            // 
            // Statystyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxStat);
            this.Name = "Statystyka";
            this.Size = new System.Drawing.Size(280, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStat;

    }
}
