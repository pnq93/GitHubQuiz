﻿namespace Quiz
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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAdminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaPytaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dodajAdminaToolStripMenuItem,
            this.edycjaPytaniaToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(330, 24);
            this.menuStripMenu.TabIndex = 7;
            this.menuStripMenu.Text = "menuStripMenu";
            this.menuStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            this.toolStripMenuItem1.Text = "Edycja użytkownika";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dodajAdminaToolStripMenuItem
            // 
            this.dodajAdminaToolStripMenuItem.Name = "dodajAdminaToolStripMenuItem";
            this.dodajAdminaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dodajAdminaToolStripMenuItem.Text = "Dodaj admina";
            this.dodajAdminaToolStripMenuItem.Click += new System.EventHandler(this.dodajAdminaToolStripMenuItem_Click);
            // 
            // edycjaPytaniaToolStripMenuItem
            // 
            this.edycjaPytaniaToolStripMenuItem.Name = "edycjaPytaniaToolStripMenuItem";
            this.edycjaPytaniaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.edycjaPytaniaToolStripMenuItem.Text = "Edycja pytania";
            this.edycjaPytaniaToolStripMenuItem.Click += new System.EventHandler(this.edycjaPytaniaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 242);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "PanelAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelAdmin";
            this.Load += new System.EventHandler(this.PanelAdmin_Load);
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajAdminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaPytaniaToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
    }
}