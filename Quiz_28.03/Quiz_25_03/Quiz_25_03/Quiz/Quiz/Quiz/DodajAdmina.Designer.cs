namespace Quiz
{
    partial class DodajAdmina
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
            this.loginAdminTB = new System.Windows.Forms.TextBox();
            this.DodajAdminB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasloAdminTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginAdminTB
            // 
            this.loginAdminTB.Location = new System.Drawing.Point(99, 10);
            this.loginAdminTB.Name = "loginAdminTB";
            this.loginAdminTB.Size = new System.Drawing.Size(100, 20);
            this.loginAdminTB.TabIndex = 1;
            // 
            // DodajAdminB
            // 
            this.DodajAdminB.Location = new System.Drawing.Point(57, 84);
            this.DodajAdminB.Name = "DodajAdminB";
            this.DodajAdminB.Size = new System.Drawing.Size(142, 23);
            this.DodajAdminB.TabIndex = 2;
            this.DodajAdminB.Text = "Dodaj!";
            this.DodajAdminB.UseVisualStyleBackColor = true;
            this.DodajAdminB.Click += new System.EventHandler(this.DodajAdminB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa admina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            // 
            // hasloAdminTB
            // 
            this.hasloAdminTB.Location = new System.Drawing.Point(99, 44);
            this.hasloAdminTB.Name = "hasloAdminTB";
            this.hasloAdminTB.Size = new System.Drawing.Size(100, 20);
            this.hasloAdminTB.TabIndex = 5;
            // 
            // DodajAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 119);
            this.Controls.Add(this.hasloAdminTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajAdminB);
            this.Controls.Add(this.loginAdminTB);
            this.Name = "DodajAdmina";
            this.Text = "DodajAdmina";
            this.Load += new System.EventHandler(this.DodajAdmina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginAdminTB;
        private System.Windows.Forms.Button DodajAdminB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hasloAdminTB;
    }
}