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
    public partial class EdycjaUzytkownika : Form
    {
        public EdycjaUzytkownika()
        {
            InitializeComponent();
            wczytajOsoby();
        }
        void wczytajOsoby()
        {
            listBoxUzytkownicy.Items.Clear();
            listBoxUzytkownicy.Items.AddRange(baza.Polaczenie.Uzytkownicies.OrderBy(o => o.user_name).ToArray());
            listBoxUzytkownicy.DisplayMember = "user_name";
           
        }
        private void EdycjaUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            Edycja fe = new Edycja(baza.Polaczenie, listBoxUzytkownicy.SelectedItem as Uzytkownicy);
            fe.FormClosed += Edycja_FormClosed;
            fe.Show();
        }

        private void Edycja_FormClosed(object sender, FormClosedEventArgs e)
        {
             wczytajOsoby();
        }
        }
    }
