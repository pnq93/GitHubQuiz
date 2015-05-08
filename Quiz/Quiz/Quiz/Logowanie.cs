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
  
    public partial class Logowanie : Form
    {
        Udzielona_odpowiedz up = new Udzielona_odpowiedz();
        private int wynik;
        
        public Logowanie()
        {
            InitializeComponent();
            obrazek.Image = new Bitmap(Image.FromFile("E:/Inżynieria/Quiz/Quiz/pobrane.jpg"));
            obrazek.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Rejestracja";
            panel1.Controls.Clear();
            Logowaniee l = new Logowaniee(this);
            panel1.Controls.Add(l);
        }

        public Logowanie(int wynik)
        {
            this.wynik = wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Rejestracja")
            {
                panel1.Controls.Clear();
                RejestracjaUC l = new RejestracjaUC(this);
                panel1.Controls.Add(l);
                button1.Text = "Logowanie";
            }
            else
            {
                panel1.Controls.Clear();
                Logowaniee l = new Logowaniee(this);
                panel1.Controls.Add(l);
                button1.Text = "Rejestracja";
            }
        }

        private void obrazek_Click(object sender, EventArgs e)
        {

        }

        
    }
}
