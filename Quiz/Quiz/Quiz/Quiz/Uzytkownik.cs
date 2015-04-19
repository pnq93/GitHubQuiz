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
    public partial class Uzytkownik : Form
    {
        bazaDanychQuizDataContext uzytkownikDB = new bazaDanychQuizDataContext();
        public Uzytkownik()
        {
            InitializeComponent();
            foreach (Uzytkownicy u in uzytkownikDB.Uzytkownicies) // pobiera z tabeli zarejestrowanych uzytkownikow
            {
                obszar.AppendText("Nazwa użytkowinika: " + u.user_name + "\n"); //" Hasl: " + u.password +"\n");
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uzytkownik_Load(object sender, EventArgs e)
        {

        }
    }
}
