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
    public partial class DodajAdmina : Form
    {
        private Uzytkownicy osoba;
        bazaDanychQuizDataContext bazaDC = new bazaDanychQuizDataContext();
        Haszowanie hash = new Haszowanie();
        public DodajAdmina()
        {
            InitializeComponent();
            hasloAdminTB.PasswordChar = '*';
        }

        private void DodajAdminB_Click(object sender, EventArgs e)
        {
            if (loginAdminTB.Text == "" || hasloAdminTB.Text == "")
            {
                MessageBox.Show("Każde pole musi być wypełnione", "Błąd założenia konta");
            }
            else
            {
                int czyIstnieje = 0;
                foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
                {
                    if (u.user_name == loginAdminTB.Text)
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


                    osoba.user_name = loginAdminTB.Text;
                    osoba.password = hash.SzyfrujMD5(hasloAdminTB.Text);
                    osoba.czy_admin = 1;
                    bazaDC.Uzytkownicies.InsertOnSubmit(osoba);
                    bazaDC.SubmitChanges();
                    Close();
                }

            }
        }

        private void DodajAdmina_Load(object sender, EventArgs e)
        {

        }
    }
}
