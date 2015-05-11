using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Game : Form
    {

        Uzytkownicy u = new Uzytkownicy();

        public Game()
        {
            InitializeComponent();
            obrazek.Image = new Bitmap(Image.FromFile("E:/Inżynieria/Quiz/Quiz/Olympic-logo.png"));
            obrazek.SizeMode = PictureBoxSizeMode.StretchImage;
        }





        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Logowanie()).Show();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new NewGamecs();
            Form.Show();

        }



        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Logowanie()).Show();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void statystykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Statystyka s = new Statystyka(this);
            panel1.Controls.Add(s);
        }

    }
}
