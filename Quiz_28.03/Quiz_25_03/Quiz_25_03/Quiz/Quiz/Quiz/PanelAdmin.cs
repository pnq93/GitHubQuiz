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
    public partial class PanelAdmin : Form
    {

        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void dodaj_pyt_Click(object sender, EventArgs e)
        {
            var Form = new DodajPytanie();
            Form.Show();
        }

        private void usun_uzyt_Click(object sender, EventArgs e)
        {
            var Form = new UsuwanieUzytkownika();
            Form.Show();
        }

        private void dodAdmin_Click(object sender, EventArgs e)
        {
            var Form = new DodajAdmina();
            Form.Show();
        }

        private void edycja_Click(object sender, EventArgs e)
        {
            EdycjaUzytkownika fe = new EdycjaUzytkownika();
            fe.Show();
        }

        private void EdycjaUzytkownika_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void buttonEdycjaPytania_Click(object sender, EventArgs e)
        {
            ListaPytan fe = new ListaPytan();
            fe.Show();
        }

        private void buttonUsunPytanie_Click(object sender, EventArgs e)
        {
            UsunPytanie fe = new UsunPytanie();
            fe.Show();
        }
    }
}
    

