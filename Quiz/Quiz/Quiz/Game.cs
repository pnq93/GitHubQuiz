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
        public Game()
        {
            InitializeComponent();
     obrazek.Image = new Bitmap(Image.FromFile("E:/Inżynieria/Quiz/Quiz/Olympic-logo.png"));
            obrazek.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statistics_Click(object sender, EventArgs e)
        {
            var Form = new Statistics();
            Form.Show();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            var Form = new NewGamecs();
            Form.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
