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
    public partial class UsunPytanie : Form
    {
        private Pytania pytania;
        public UsunPytanie()
        {
            InitializeComponent();
            foreach (Pytania p in baza.Polaczenie.Pytanias)
            {
                listBoxPytania.Items.Add(p);
            }
            listBoxPytania.DisplayMember = "tresc";


        }

        private void UsunPytanie_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {


            if (listBoxPytania.SelectedItem == null)
            {
                MessageBox.Show("Nic nie zaznaczono", "Błąd usuwania");
            }
            else
            {
                var usunPyt = baza.Polaczenie.Pytanias.Where(p => p.tresc == listBoxPytania.Text);
                var id = baza.Polaczenie.Pytanias.Where(x => x.tresc == listBoxPytania.Text).Select(i => i.Id).First();

                baza.Polaczenie.Pytanias.DeleteAllOnSubmit(usunPyt);

                foreach (Odpowiedzi o in baza.Polaczenie.Odpowiedzis)
                {
                    if (id == o.id_pytania)
                        baza.Polaczenie.Odpowiedzis.DeleteOnSubmit(o);
                }

                baza.Polaczenie.SubmitChanges();
                listBoxPytania.Refresh();
                MessageBox.Show("Usunięto pomyślnie", "Informacja");
                Close();
            }



        }
    }
}
