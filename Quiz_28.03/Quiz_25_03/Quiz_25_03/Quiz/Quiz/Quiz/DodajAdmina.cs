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
        }

        private void DodajAdminB_Click(object sender, EventArgs e)
        {
            if (osoba == null)
            {
                osoba = new Uzytkownicy();
                bazaDC.Uzytkownicies.InsertOnSubmit(osoba);
            }
            osoba.user_name = loginAdminTB.Text;
            osoba.password = hash.SzyfrujMD5(hasloAdminTB.Text);
            osoba.czy_admin = 1;

            bazaDC.SubmitChanges();
            Close();
        }

        private void DodajAdmina_Load(object sender, EventArgs e)
        {

        }
    }
}
