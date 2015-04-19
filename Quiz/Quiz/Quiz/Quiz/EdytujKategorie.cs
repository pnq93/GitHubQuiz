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
    public partial class EdytujKategorie : Form
    {
        private string p;

        public EdytujKategorie()
        {
            InitializeComponent();
        }

        public EdytujKategorie(string p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.p = p;
            textBoxKat.Text = p;
        }

        private void EdytujKategorie_Load(object sender, EventArgs e)
        {

        }
        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (textBoxKat.Text != "")
            {
                int czyIstnieje = 0;
                foreach (Kategoria k in baza.Polaczenie.Kategorias)
                {
                    if (k.nazwa == textBoxKat.Text)
                    {
                        czyIstnieje = 1;
                    }
                }
                if (czyIstnieje == 1)
                {
                    MessageBox.Show("Kategoria istnieje", "Błąd");
                }
                else
                {
                    Kategoria kat = new Kategoria();
                    kat.nazwa = textBoxKat.Text;
                    baza.Polaczenie.Kategorias.InsertOnSubmit(kat);
                    baza.Polaczenie.SubmitChanges();
                    MessageBox.Show("Kategoria dodana", "Informacja");
                }
            }
            else
            {
                MessageBox.Show("Nie można dodać pustej kategori", "Informacja");
            }
        }
    }
}
