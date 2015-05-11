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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(12, 21);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(254, 114);
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.statystykaToolStripMenuItem,
            this.wyjścieToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // statystykaToolStripMenuItem
            // 
            this.statystykaToolStripMenuItem.Name = "statystykaToolStripMenuItem";
            this.statystykaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.statystykaToolStripMenuItem.Text = "Statystyka";
            this.statystykaToolStripMenuItem.Click += new System.EventHandler(this.statystykaToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 100);
            this.panel1.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Gry";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}