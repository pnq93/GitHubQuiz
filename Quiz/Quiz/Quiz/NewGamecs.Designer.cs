﻿namespace Quiz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.odp4 = new System.Windows.Forms.RadioButton();
            this.odp3 = new System.Windows.Forms.RadioButton();
            this.odp2 = new System.Windows.Forms.RadioButton();
            this.odp1 = new System.Windows.Forms.RadioButton();
            this.koniec = new System.Windows.Forms.Button();
            this.UdzieloneOdp = new System.Windows.Forms.Label();
            this.dalej = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.losowanePytanie = new System.Windows.Forms.Label();
            this.labelIlePyt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.koniec);
            this.groupBox1.Controls.Add(this.UdzieloneOdp);
            this.groupBox1.Controls.Add(this.dalej);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odpowiedzi:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.odp4);
            this.groupBox3.Controls.Add(this.odp3);
            this.groupBox3.Controls.Add(this.odp2);
            this.groupBox3.Controls.Add(this.odp1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 121);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // odp4
            // 
            this.odp4.AutoSize = true;
            this.odp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odp4.Location = new System.Drawing.Point(7, 89);
            this.odp4.Name = "odp4";
            this.odp4.Size = new System.Drawing.Size(107, 19);
            this.odp4.TabIndex = 3;
            this.odp4.TabStop = true;
            this.odp4.Text = "radioButton4";
            this.odp4.UseVisualStyleBackColor = true;
            // 
            // odp3
            // 
            this.odp3.AutoSize = true;
            this.odp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odp3.Location = new System.Drawing.Point(7, 66);
            this.odp3.Name = "odp3";
            this.odp3.Size = new System.Drawing.Size(107, 19);
            this.odp3.TabIndex = 2;
            this.odp3.TabStop = true;
            this.odp3.Text = "radioButton3";
            this.odp3.UseVisualStyleBackColor = true;
            // 
            // odp2
            // 
            this.odp2.AutoSize = true;
            this.odp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odp2.Location = new System.Drawing.Point(7, 43);
            this.odp2.Name = "odp2";
            this.odp2.Size = new System.Drawing.Size(107, 19);
            this.odp2.TabIndex = 1;
            this.odp2.TabStop = true;
            this.odp2.Text = "radioButton2";
            this.odp2.UseVisualStyleBackColor = true;
            // 
            // odp1
            // 
            this.odp1.AutoSize = true;
            this.odp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odp1.Location = new System.Drawing.Point(7, 19);
            this.odp1.Name = "odp1";
            this.odp1.Size = new System.Drawing.Size(107, 19);
            this.odp1.TabIndex = 0;
            this.odp1.TabStop = true;
            this.odp1.Text = "radioButton1";
            this.odp1.UseVisualStyleBackColor = true;
            // 
            // koniec
            // 
            this.koniec.BackColor = System.Drawing.Color.Lavender;
            this.koniec.Location = new System.Drawing.Point(287, 113);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(93, 26);
            this.koniec.TabIndex = 11;
            this.koniec.Text = "Zakończ Quiz";
            this.koniec.UseVisualStyleBackColor = false;
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
            this.dalej.BackColor = System.Drawing.Color.Lavender;
            this.dalej.Location = new System.Drawing.Point(287, 67);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(93, 40);
            this.dalej.TabIndex = 9;
            this.dalej.Text = "Następne pytanie";
            this.dalej.UseVisualStyleBackColor = false;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.losowanePytanie);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pytanie";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // losowanePytanie
            // 
            this.losowanePytanie.AutoSize = true;
            this.losowanePytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losowanePytanie.Location = new System.Drawing.Point(6, 16);
            this.losowanePytanie.Name = "losowanePytanie";
            this.losowanePytanie.Size = new System.Drawing.Size(231, 17);
            this.losowanePytanie.TabIndex = 0;
            this.losowanePytanie.Text = "Wyswietlanie losowego pytania";
            // 
            // labelIlePyt
            // 
            this.labelIlePyt.AutoSize = true;
            this.labelIlePyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIlePyt.ForeColor = System.Drawing.Color.Blue;
            this.labelIlePyt.Location = new System.Drawing.Point(106, 206);
            this.labelIlePyt.Name = "labelIlePyt";
            this.labelIlePyt.Size = new System.Drawing.Size(82, 17);
            this.labelIlePyt.TabIndex = 11;
            this.labelIlePyt.Text = "iloscPytan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numer pytania";
            // 
            // NewGamecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(420, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIlePyt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGamecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozgrywka";
            this.Load += new System.EventHandler(this.NewGamecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.Label UdzieloneOdp;
        private System.Windows.Forms.Button koniec;
        private System.Windows.Forms.Label losowanePytanie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton odp4;
        private System.Windows.Forms.RadioButton odp3;
        private System.Windows.Forms.RadioButton odp2;
        private System.Windows.Forms.RadioButton odp1;
        private System.Windows.Forms.Label labelIlePyt;
        private System.Windows.Forms.Label label1;
    }
}