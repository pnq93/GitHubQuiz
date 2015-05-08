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
    public partial class EdycjaUzy : UserControl
    {
        private EditUzyt editUzyt;
        private bazaDanychQuizDataContext bazaDanychQuizDataContext;
        private Uzytkownicy uzytkownicy;
        Haszowanie hash = new Haszowanie();

        public EdycjaUzy()
        {
            InitializeComponent();
        }

        public EdycjaUzy(EditUzyt editUzyt, bazaDanychQuizDataContext bazaDanychQuizDataContext, Uzytkownicy uzytkownicy)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            this.editUzyt = editUzyt;
            this.bazaDanychQuizDataContext = bazaDanychQuizDataContext;
            this.uzytkownicy = uzytkownicy;
            if (uzytkownicy == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");

            }
            else
            {
                textBoxUzytkownik.Text = uzytkownicy.user_name;
                textBoxHaslo.Text = "";
                textBoxAdmin.Text = uzytkownicy.czy_admin.ToString();
            }
        }

        private void EdycjaUzy_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            if (uzytkownicy == null)
            {
                uzytkownicy = new Uzytkownicy();

            }
            if (textBoxUzytkownik.Text != "" && textBoxHaslo.Text != "" && textBoxAdmin.Text != "")
            {


                if (textBoxUzytkownik != null)
                    uzytkownicy.user_name = textBoxUzytkownik.Text;

                if (textBoxHaslo != null)
                    uzytkownicy.password = hash.SzyfrujMD5(textBoxHaslo.Text);
                if (textBoxAdmin != null)
                    uzytkownicy.czy_admin = Convert.ToInt32(textBoxAdmin.Text);
                baza.Polaczenie.SubmitChanges();
                MessageBox.Show("Użytkownik został zedytowany");
            }
            else
            {
                MessageBox.Show("Każde pole musi być wypełnione");
            }





        }
    }
}
    
