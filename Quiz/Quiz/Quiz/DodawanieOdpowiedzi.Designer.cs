namespace Quiz
{
    partial class DodawanieOdpowiedzi
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
            this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
            this.checkBoxCzyPrawda = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxOdpowiedz
            // 
            this.textBoxOdpowiedz.Location = new System.Drawing.Point(105, 11);
            this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
            this.textBoxOdpowiedz.Size = new System.Drawing.Size(125, 20);
            this.textBoxOdpowiedz.TabIndex = 0;
            this.textBoxOdpowiedz.TextChanged += new System.EventHandler(this.textBoxOdpowiedz_TextChanged);
            // 
            // checkBoxCzyPrawda
            // 
            this.checkBoxCzyPrawda.AutoSize = true;
            this.checkBoxCzyPrawda.Location = new System.Drawing.Point(3, 13);
            this.checkBoxCzyPrawda.Name = "checkBoxCzyPrawda";
            this.checkBoxCzyPrawda.Size = new System.Drawing.Size(96, 17);
            this.checkBoxCzyPrawda.TabIndex = 1;
            this.checkBoxCzyPrawda.Text = "Czy prawdziwa";
            this.checkBoxCzyPrawda.UseVisualStyleBackColor = true;
            this.checkBoxCzyPrawda.CheckedChanged += new System.EventHandler(this.checkBoxCzyPrawda_CheckedChanged);
            // 
            // DodawanieOdpowiedzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCzyPrawda);
            this.Controls.Add(this.textBoxOdpowiedz);
            this.Name = "DodawanieOdpowiedzi";
            this.Size = new System.Drawing.Size(243, 44);
            this.Load += new System.EventHandler(this.DodawanieOdpowiedzi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOdpowiedz;
        private System.Windows.Forms.CheckBox checkBoxCzyPrawda;
    }
}
