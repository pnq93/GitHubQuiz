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
    public partial class DodajPytanie : Form
    {
        private Pytania pytanie;
       
        public DodajPytanie()
        {
            InitializeComponent();
            this.pytanie = new Pytania();

        }

        private void zapiszPytanie_Click(object sender, EventArgs e)
        {

            if (tresc.Text == "" || comboBoxIleOdp.Text == "" ||  kategoriaPytania.Text == "" )
            {

                MessageBox.Show("Wypełnij każde pole formularza", "Błąd");
            }
            else
            {

                pytanie.tresc = tresc.Text;
                pytanie.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == kategoriaPytania.Text).Select(s => s.Id).First();

                pytanie.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                baza.Polaczenie.Pytanias.InsertOnSubmit(pytanie);
                baza.Polaczenie.SubmitChanges();
            }
            Close();
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            int move = 0;
            String ile = comboBoxIleOdp.Text;
            if (comboBoxIleOdp.Text != "")
            {
            Int32 ileOdpowiedzi = Convert.ToInt32(ile);
            
                for (Int32 i = 0; i < ileOdpowiedzi; i++)
                {
                    DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi();
                    generator.Location = new Point(5, 10 + move);
                    panel1.Controls.Add(generator);
                    move += 35;
                    pytanie.Odpowiedzis.Add(generator.OdpowiedziDane);
                }
            }
            else
            {
                MessageBox.Show("Wybierz ile dodac odpowiedzi");
            }

        }

       

        private void DodajPytanie_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxIleOdp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
