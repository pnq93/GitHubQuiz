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
         Kategoria kat;
         private System.Data.Linq.Table<Kategoria> table;
         private IQueryable<Kategoria> queryable;
        public EdytujKategorie()
        {
            InitializeComponent();
        }


        public EdytujKategorie(Kategoria kat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.kat = kat;
        }

        public EdytujKategorie(Kategoria kat, string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.kat = kat;
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
                    kat.nazwa = textBoxKat.Text;
                    
                     
                    
                   
                    baza.Polaczenie.SubmitChanges();
                    MessageBox.Show("Kategoria została z edytowana", "Informacja");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nie można dodać pustej kategori", "Informacja");
            }
           
        }
       
    }

}
