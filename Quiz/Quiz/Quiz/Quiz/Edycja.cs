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
    public partial class Edycja : Form
    {
        private bazaDanychQuizDataContext bazaDC;
        private Uzytkownicy uzytkownik;
        private bazaDanychQuizDataContext bazaDanychQuizDataContext;
        private Odpowiedzi odpowiedzi;
        public Edycja()
        {
            InitializeComponent();


        }
        public Edycja(bazaDanychQuizDataContext bazaDC, Uzytkownicy osobaEdytowana)
        {
            InitializeComponent();
            this.bazaDC = bazaDC;
            this.uzytkownik = osobaEdytowana;
            if (uzytkownik == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
            }
            else
            {
                textBoxUzytkownik.Text = uzytkownik.user_name;
                //textBoxHaslo.Text = uzytkownik.password;
                textBoxAdmin.Text = uzytkownik.czy_admin.ToString();
            }


        }

        public Edycja(bazaDanychQuizDataContext bazaDanychQuizDataContext, Odpowiedzi odpowiedzi)
        {
            this.bazaDanychQuizDataContext = bazaDanychQuizDataContext;
            this.odpowiedzi = odpowiedzi;
        }

        private void Edycja_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonUzytkownik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUzytkownik.Checked == true)
            {
                textBoxUzytkownik.Enabled = true;
            }
            else
            {
                textBoxUzytkownik.Enabled = false;
            }
        }

        private void radioButtonHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHaslo.Checked == true)
            {
                textBoxHaslo.Enabled = true;
            }
            else
            {
                textBoxHaslo.Enabled = false;
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked == true)
            {
                textBoxAdmin.Enabled = true;
            }
            else
            {
                textBoxAdmin.Enabled = false;
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (uzytkownik == null)
            {
                uzytkownik = new Uzytkownicy();

            }

            if (textBoxUzytkownik != null)
                uzytkownik.user_name = textBoxUzytkownik.Text;

            if (textBoxHaslo != null)
                uzytkownik.password = textBoxHaslo.Text;
            if (textBoxAdmin != null)
                uzytkownik.czy_admin = Convert.ToInt32(textBoxAdmin.Text);


            baza.Polaczenie.SubmitChanges();
            Close();


        }
    }
}

