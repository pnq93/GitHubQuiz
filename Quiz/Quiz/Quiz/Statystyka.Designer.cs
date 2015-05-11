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
            this.listBoxWynik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxWynik
            // 
            this.listBoxWynik.FormattingEnabled = true;
            this.listBoxWynik.Location = new System.Drawing.Point(0, 0);
            this.listBoxWynik.Name = "listBoxWynik";
            this.listBoxWynik.Size = new System.Drawing.Size(277, 121);
            this.listBoxWynik.TabIndex = 0;
            this.listBoxWynik.SelectedIndexChanged += new System.EventHandler(this.listBoxWynik_SelectedIndexChanged);
            // 
            // Statystyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxWynik);
            this.Name = "Statystyka";
            this.Size = new System.Drawing.Size(280, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWynik;
    }
}
