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

        bazaDanychQuizDataContext bazaDC = new bazaDanychQuizDataContext();
        Haszowanie hasz;
        public Logowanie()
        {
         

            InitializeComponent();
            string uzytkownik = user.Text;
            pass.PasswordChar = '*';
            obrazek.Image = new Bitmap(Image.FromFile("E:/Inżynieria/Quiz/Quiz/pobrane.jpg"));
            obrazek.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string uzytkownik = this.user.Text;
            string haslo = pass.Text;

                if (SprawdzNazweiHaslo(uzytkownik, haslo))
                {
                    Uzytkownicy u = bazaDC.Uzytkownicies.Where(x => x.user_name == uzytkownik).First();
                    string admin = u.czy_admin.ToString();

                    if (admin == "1")
                    {
                        MessageBox.Show("Użytkownik jest w systemie jako admin", "Zaalogowano jako admin");
                        // var Form = new Game();
                        //Form.Show();
                        (new PanelAdmin()).Show();
                        //this.Visible = false;
                        // this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Użytkownik jest w systemie jako zwykły użytkownik", "Zaalogowano");
                        // var Form = new Game();
                        //Form.Show();
                        (new Game()).Show();
                        //this.Visible = false;
                        // this.Close();
                    }
                }     
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                return;
            }
        }
        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {           
           /* var uzytk = from c in bazaDC.Uzytkownicies
                        where (c.user_name == uzytkownik.ToLower() && c.password == haslo)
                        select c;*/
            var uzytk = bazaDC.Uzytkownicies.Where(x => x.user_name == uzytkownik.ToLower() && x.password == haslo);

            if (uzytk.Count() != 0)
            {
                return true;
            }
            return false;
        }

        private void obrazek_Click(object sender, EventArgs e)
        {
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {
        }

        private void polacz_Click(object sender, EventArgs e)
        {
            var Form = new NewGamecs();
            Form.Show();
        }

        private void uzytkownik_Click(object sender, EventArgs e)
        {
            var Form = new Uzytkownik();
            Form.Show();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rejestracja_Click(object sender, EventArgs e)
        {
            var Form = new Rejestracja();
            Form.Show();
        }
    }
}
