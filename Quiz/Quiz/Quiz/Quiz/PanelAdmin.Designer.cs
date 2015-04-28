namespace Quiz
{
    partial class PanelAdmin
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
            this.dodAdmin = new System.Windows.Forms.Button();
            this.edycja = new System.Windows.Forms.Button();
            this.edytujPytanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodAdmin
            // 
            this.dodAdmin.Location = new System.Drawing.Point(108, 12);
            this.dodAdmin.Name = "dodAdmin";
            this.dodAdmin.Size = new System.Drawing.Size(90, 44);
            this.dodAdmin.TabIndex = 2;
            this.dodAdmin.Text = "Dodaj administratora";
            this.dodAdmin.UseVisualStyleBackColor = true;
            this.dodAdmin.Click += new System.EventHandler(this.dodAdmin_Click);
            // 
            // edycja
            // 
            this.edycja.Location = new System.Drawing.Point(12, 11);
            this.edycja.Name = "edycja";
            this.edycja.Size = new System.Drawing.Size(90, 44);
            this.edycja.TabIndex = 3;
            this.edycja.Text = "Edytuj użytkownika";
            this.edycja.UseVisualStyleBackColor = true;
            this.edycja.Click += new System.EventHandler(this.edycja_Click);
            // 
            // edytujPytanie
            // 
            this.edytujPytanie.Location = new System.Drawing.Point(204, 12);
            this.edytujPytanie.Name = "edytujPytanie";
            this.edytujPytanie.Size = new System.Drawing.Size(90, 43);
            this.edytujPytanie.TabIndex = 6;
            this.edytujPytanie.Text = "Edytuj pytanie";
            this.edytujPytanie.UseVisualStyleBackColor = true;
            this.edytujPytanie.Click += new System.EventHandler(this.edytujPytanie_Click);
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 66);
            this.Controls.Add(this.edytujPytanie);
            this.Controls.Add(this.edycja);
            this.Controls.Add(this.dodAdmin);
            this.Name = "PanelAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodAdmin;
        private System.Windows.Forms.Button edycja;
        private System.Windows.Forms.Button edytujPytanie;
    }
}