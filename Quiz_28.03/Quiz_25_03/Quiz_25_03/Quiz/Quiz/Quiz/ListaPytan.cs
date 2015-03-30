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
    public partial class ListaPytan : Form
    {
        private Pytania pytania;
        public ListaPytan()
        {
            InitializeComponent();
            wczytajPytania();
        }
        void wczytajPytania()
        {
            listBoxPytania.Items.Clear();
            listBoxPytania.Items.AddRange(baza.Polaczenie.Pytanias.OrderBy(o => o.tresc).ToArray());
            listBoxPytania.DisplayMember = "tresc";

        }

        private void ListaPytan_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
           
                EdycjaPytania fe = new EdycjaPytania(baza.Polaczenie, listBoxPytania.SelectedItem as Pytania);
                fe.FormClosed += EdycjaPytania_FormClosed;
                fe.Show();
           
         
            }
            

        private void EdycjaPytania_FormClosed(object sender, FormClosedEventArgs e)
        {
            wczytajPytania();
        }
    }
}
