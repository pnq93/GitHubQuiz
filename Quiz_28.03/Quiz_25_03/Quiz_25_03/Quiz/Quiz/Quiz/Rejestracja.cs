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
    public partial class Rejestracja : Form
    {


        Haszowanie hash = new Haszowanie();
        private Uzytkownicy osoba;
        public Rejestracja()
        {
            InitializeComponent();
            noweHaslo.PasswordChar = '*';
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (nowyUzytkownik.Text == "" || noweHaslo.Text == "")
            {
                MessageBox.Show("Uzupełnij każde pole w formularzu", "Błąd rejestracji");
            }
            else
            {
                int czyIstnieje = 0;
                foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
                {
                    if (u.user_name == nowyUzytkownik.Text)
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
                    osoba.user_name = nowyUzytkownik.Text;
                    osoba.password = hash.SzyfrujMD5(noweHaslo.Text);
                    osoba.czy_admin = 0;
                    baza.Polaczenie.Uzytkownicies.InsertOnSubmit(osoba);
                    baza.Polaczenie.SubmitChanges();
                    Close();
                }
            }
        }


        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void adminCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



