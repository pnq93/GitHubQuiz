namespace Quiz
{
    partial class NewGamecs
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
            this.odp3 = new System.Windows.Forms.CheckBox();
            this.odp4 = new System.Windows.Forms.CheckBox();
            this.odp1 = new System.Windows.Forms.CheckBox();
            this.odp2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.koniec = new System.Windows.Forms.Button();
            this.UdzieloneOdp = new System.Windows.Forms.Label();
            this.dalej = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.losowanePytanie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // odp3
            // 
            this.odp3.AutoSize = true;
            this.odp3.Location = new System.Drawing.Point(6, 75);
            this.odp3.Name = "odp3";
            this.odp3.Size = new System.Drawing.Size(80, 17);
            this.odp3.TabIndex = 5;
            this.odp3.Text = "checkBox1";
            this.odp3.UseVisualStyleBackColor = true;
            this.odp3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // odp4
            // 
            this.odp4.AutoSize = true;
            this.odp4.Location = new System.Drawing.Point(6, 98);
            this.odp4.Name = "odp4";
            this.odp4.Size = new System.Drawing.Size(80, 17);
            this.odp4.TabIndex = 6;
            this.odp4.Text = "checkBox2";
            this.odp4.UseVisualStyleBackColor = true;
            // 
            // odp1
            // 
            this.odp1.AutoSize = true;
            this.odp1.Location = new System.Drawing.Point(6, 29);
            this.odp1.Name = "odp1";
            this.odp1.Size = new System.Drawing.Size(80, 17);
            this.odp1.TabIndex = 7;
            this.odp1.Text = "checkBox3";
            this.odp1.UseVisualStyleBackColor = true;
            // 
            // odp2
            // 
            this.odp2.AutoSize = true;
            this.odp2.Location = new System.Drawing.Point(6, 52);
            this.odp2.Name = "odp2";
            this.odp2.Size = new System.Drawing.Size(80, 17);
            this.odp2.TabIndex = 8;
            this.odp2.Text = "checkBox4";
            this.odp2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.koniec);
            this.groupBox1.Controls.Add(this.UdzieloneOdp);
            this.groupBox1.Controls.Add(this.dalej);
            this.groupBox1.Controls.Add(this.odp3);
            this.groupBox1.Controls.Add(this.odp2);
            this.groupBox1.Controls.Add(this.odp4);
            this.groupBox1.Controls.Add(this.odp1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odpowiedzi:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // koniec
            // 
            this.koniec.Location = new System.Drawing.Point(255, 113);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(93, 26);
            this.koniec.TabIndex = 11;
            this.koniec.Text = "zakończ Quiz";
            this.koniec.UseVisualStyleBackColor = true;
            this.koniec.Click += new System.EventHandler(this.koniec_Click);
            // 
            // UdzieloneOdp
            // 
            this.UdzieloneOdp.AutoSize = true;
            this.UdzieloneOdp.Location = new System.Drawing.Point(311, 123);
            this.UdzieloneOdp.Name = "UdzieloneOdp";
            this.UdzieloneOdp.Size = new System.Drawing.Size(0, 13);
            this.UdzieloneOdp.TabIndex = 10;
            this.UdzieloneOdp.Click += new System.EventHandler(this.label1_Click);
            // 
            // dalej
            // 
            this.dalej.Location = new System.Drawing.Point(255, 62);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(93, 40);
            this.dalej.TabIndex = 9;
            this.dalej.Text = "Następne pytanie";
            this.dalej.UseVisualStyleBackColor = true;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.losowanePytanie);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pytanie:";
            // 
            // losowanePytanie
            // 
            this.losowanePytanie.AutoSize = true;
            this.losowanePytanie.Location = new System.Drawing.Point(6, 16);
            this.losowanePytanie.Name = "losowanePytanie";
            this.losowanePytanie.Size = new System.Drawing.Size(154, 13);
            this.losowanePytanie.TabIndex = 0;
            this.losowanePytanie.Text = "Wyswietlanie losowego pytania";
            // 
            // NewGamecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewGamecs";
            this.Text = "Rozgrywka";
            this.Load += new System.EventHandler(this.NewGamecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox odp3;
        private System.Windows.Forms.CheckBox odp4;
        private System.Windows.Forms.CheckBox odp1;
        private System.Windows.Forms.CheckBox odp2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.Label UdzieloneOdp;
        private System.Windows.Forms.Button koniec;
        private System.Windows.Forms.Label losowanePytanie;
    }
}