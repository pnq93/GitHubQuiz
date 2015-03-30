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
    public partial class EdycjaPytania : Form
    {
        private bazaDanychQuizDataContext bazaDanychQuizDataContext;
        private Pytania pytania;
        private Kategoria kategoria;
        private Typ_pytania typ;
        private Odpowiedzi odpowiedzi;

        public EdycjaPytania()
        {
            InitializeComponent();

        }

        public EdycjaPytania(bazaDanychQuizDataContext bazaDanychQuizDataContext, Pytania pytania)
        {
            InitializeComponent();
            this.bazaDanychQuizDataContext = bazaDanychQuizDataContext;
            this.pytania = pytania;

            if (pytania == null)
            {
                MessageBox.Show("Nie zaznaczono elementu do edycji", "Błąd edycji");
            }
            else
            {
                textBoxPyt.Text = pytania.tresc;

                foreach (Odpowiedzi o in pytania.Odpowiedzis)
                {
                    listBoxOdpowiedzi.Items.Add(o);
                    listBoxOdpowiedzi.DisplayMember = "odp";
                }
            }
        }

        /*public EdycjaPytania(global::Quiz.bazaDanychQuizDataContext bazaDanychQuizDataContext, Odpowiedzi odpowiedzi)
        {
            // TODO: Complete member initialization
            this.bazaDanychQuizDataContext = bazaDanychQuizDataContext;
            this.odpowiedzi = odpowiedzi;
        }*/

        private void EdycjaPytania_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdytujOdp_Click(object sender, EventArgs e)
        {
                if(pytania == null)
                {
                    MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
                }
                else
                {
                    EdycjaOdpowiedzi fe = new EdycjaOdpowiedzi(baza.Polaczenie, listBoxOdpowiedzi.SelectedItem as Odpowiedzi);
                fe.FormClosed += EdycjaOdpowiedzi_FormClosed;
                fe.Show();
                }
                
     
            
        }

        private void EdycjaOdpowiedzi_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBoxOdpowiedzi.Items.Clear();
            foreach (Odpowiedzi o in pytania.Odpowiedzis)
            {     
                listBoxOdpowiedzi.Items.Add(o);
                listBoxOdpowiedzi.DisplayMember = "odp";
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            pytania.tresc = textBoxPyt.Text;
            baza.Polaczenie.SubmitChanges();
            Close();
        }
    }
}
