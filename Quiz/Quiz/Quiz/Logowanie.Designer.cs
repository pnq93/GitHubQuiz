namespace Quiz
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.rejestracja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(95, 125);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(95, 156);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 3;
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(12, 12);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(260, 107);
            this.obrazek.TabIndex = 4;
            this.obrazek.TabStop = false;
            this.obrazek.Click += new System.EventHandler(this.obrazek_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(95, 190);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 30);
            this.login.TabIndex = 5;
            this.login.Text = "Zaloguj!";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // rejestracja
            // 
            this.rejestracja.Location = new System.Drawing.Point(12, 226);
            this.rejestracja.Name = "rejestracja";
            this.rejestracja.Size = new System.Drawing.Size(75, 23);
            this.rejestracja.TabIndex = 8;
            this.rejestracja.Text = "Rejestracja";
            this.rejestracja.UseVisualStyleBackColor = true;
            this.rejestracja.Click += new System.EventHandler(this.rejestracja_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rejestracja);
            this.Controls.Add(this.login);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button rejestracja;
    }
}