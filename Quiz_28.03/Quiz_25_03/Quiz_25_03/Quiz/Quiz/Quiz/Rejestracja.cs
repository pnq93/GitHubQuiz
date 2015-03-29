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
       // private bazaQuizDataContext bazaDC;
        
        Haszowanie hash = new Haszowanie();
        private Uzytkownicy osoba;
        bazaDanychQuizDataContext bazaDC = new bazaDanychQuizDataContext();
        public Rejestracja()
        {
            InitializeComponent();
            noweHaslo.PasswordChar = '*';
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (osoba == null)
            {
                osoba = new Uzytkownicy();
                bazaDC.Uzytkownicies.InsertOnSubmit(osoba);
            }
            osoba.user_name = nowyUzytkownik.Text;
            osoba.password = hash.SzyfrujMD5(noweHaslo.Text);
            osoba.czy_admin = 0;
            if (osoba.user_name != nowyUzytkownik.Text)
            {          
                bazaDC.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Taki użytkownik istnieje", "Błąd");
                return;
            }
            Close();
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void adminCB_CheckedChanged(object sender, EventArgs e)
        {

        }
        }
    }

