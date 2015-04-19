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
    public partial class DodajUzytkownika : Form
    {
        Haszowanie hash = new Haszowanie();
        private Uzytkownicy osoba;
        public DodajUzytkownika()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxHaslo.Text == "")
            {
                MessageBox.Show("Uzupełnij każde pole w formularzu", "Błąd rejestracji");
            }
            else
            {
                int czyIstnieje = 0;
                foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
                {
                    if (u.user_name == textBoxLogin.Text)
                    {
                        czyIstnieje = 1;
                    }
                }
                if (czyIstnieje == 1)
                {
                    MessageBox.Show("Użytkownik istnieje", "Błąd");
                }
                else
                {
                    osoba = new Uzytkownicy();
                    osoba.user_name = textBoxLogin.Text;
                    osoba.password = hash.SzyfrujMD5(textBoxHaslo.Text);
                    osoba.czy_admin = 0;
                    baza.Polaczenie.Uzytkownicies.InsertOnSubmit(osoba);
                    baza.Polaczenie.SubmitChanges();
                    Close();
                }
            }
        }
    }
}
