namespace Quiz
{
    partial class Game
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
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.newgame = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(12, 12);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(260, 104);
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(12, 122);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(82, 38);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "Nowa Gra";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(12, 164);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(82, 38);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "Statystyki";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(12, 208);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(82, 38);
            this.quit.TabIndex = 3;
            this.quit.Text = "Wyjście";
            this.quit.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.obrazek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Gry";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Button quit;
    }
}