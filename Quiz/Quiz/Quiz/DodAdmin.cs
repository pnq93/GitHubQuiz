using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class DodAdmin : UserControl
    {
        private Uzytkownicy osoba;
        bazaDanychQuizDataContext bazaDC = new bazaDanychQuizDataContext();
        Haszowanie hash = new Haszowanie();
        public DodAdmin()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxUzyt.Text == "" || textBoxHaslo.Text == "")
            {
                MessageBox.Show("Każde pole musi być wypełnione", "Błąd założenia konta");
            }
            else
            {
                int czyIstnieje = 0;
                foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
                {
                    if (u.user_name == textBoxUzyt.Text)
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


                    osoba.user_name = textBoxUzyt.Text;
                    osoba.password = hash.SzyfrujMD5(textBoxHaslo.Text);
                    osoba.czy_admin = 1;
                    bazaDC.Uzytkownicies.InsertOnSubmit(osoba);
                    bazaDC.SubmitChanges();
                    MessageBox.Show("Dodano");
                    textBoxUzyt.Text = "";
                    textBoxHaslo.Text = "";
                }

            }
        }

        private void DodAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
