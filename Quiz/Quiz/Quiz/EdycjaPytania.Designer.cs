namespace Quiz
{
    partial class EdycjaPytania
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
            this.textBoxPyt = new System.Windows.Forms.TextBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.listBoxOdpowiedzi = new System.Windows.Forms.ListBox();
            this.buttonEdytujOdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPyt
            // 
            this.textBoxPyt.Location = new System.Drawing.Point(12, 12);
            this.textBoxPyt.Name = "textBoxPyt";
            this.textBoxPyt.Size = new System.Drawing.Size(321, 20);
            this.textBoxPyt.TabIndex = 0;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(233, 159);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(83, 23);
            this.buttonZapisz.TabIndex = 4;
            this.buttonZapisz.Text = "Zapisz!";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // listBoxOdpowiedzi
            // 
            this.listBoxOdpowiedzi.FormattingEnabled = true;
            this.listBoxOdpowiedzi.Location = new System.Drawing.Point(12, 52);
            this.listBoxOdpowiedzi.Name = "listBoxOdpowiedzi";
            this.listBoxOdpowiedzi.Size = new System.Drawing.Size(178, 212);
            this.listBoxOdpowiedzi.TabIndex = 5;
            this.listBoxOdpowiedzi.SelectedIndexChanged += new System.EventHandler(this.listBoxOdpowiedzi_SelectedIndexChanged);
            // 
            // buttonEdytujOdp
            // 
            this.buttonEdytujOdp.Location = new System.Drawing.Point(233, 109);
            this.buttonEdytujOdp.Name = "buttonEdytujOdp";
            this.buttonEdytujOdp.Size = new System.Drawing.Size(83, 44);
            this.buttonEdytujOdp.TabIndex = 6;
            this.buttonEdytujOdp.Text = "Edytuj odpowiedź";
            this.buttonEdytujOdp.UseVisualStyleBackColor = true;
            this.buttonEdytujOdp.Click += new System.EventHandler(this.buttonEdytujOdp_Click);
            // 
            // EdycjaPytania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 281);
            this.Controls.Add(this.buttonEdytujOdp);
            this.Controls.Add(this.listBoxOdpowiedzi);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.textBoxPyt);
            this.Name = "EdycjaPytania";
            this.Text = "EdycjaPytania";
            this.Load += new System.EventHandler(this.EdycjaPytania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPyt;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.ListBox listBoxOdpowiedzi;
        private System.Windows.Forms.Button buttonEdytujOdp;
    }
}