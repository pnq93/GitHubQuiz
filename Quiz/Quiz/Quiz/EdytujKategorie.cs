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
        private Kategoria kat;
        private string p;

        public EdytujKategorie()
        {
            InitializeComponent();
        }

        public EdytujKategorie(Kategoria kat, string p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.kat = kat;
            this.p = p;
            textBoxKategoria.Text = p;
        }

        private void EdytujKategorie_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (kat == null)
            {
                kat = new Kategoria();

            }
            if (textBoxKategoria.Text != "")
            {
                if (textBoxKategoria.Text != null)
                    kat.nazwa = textBoxKategoria.Text;
            }
               baza.Polaczenie.SubmitChanges();
        }
    }
}
