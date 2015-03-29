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
        private Kategoria kategoria;
        private Typ_pytania typ;
        public DodajPytanie()
        {
            InitializeComponent();
            this.pytanie = new Pytania();

        }

        private void zapiszPytanie_Click(object sender, EventArgs e)
        {

            if (tresc.Text == null || comboBoxIleOdp.Text == null || numericUpDownPoziom.Value == 0 || kategoriaPytania.Text == null)
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

        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            int move = 0;
            String ile = comboBoxIleOdp.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Odpowiedzi odp in baza.Polaczenie.Odpowiedzis)
            {
                listBox1.Items.Add(odp);
            }

            listBox1.DisplayMember = "odp";

            foreach (Pytania pyt in baza.Polaczenie.Pytanias)
            {
                listBox2.Items.Add(pyt);
            }
            listBox2.DisplayMember = "tresc";
        }

        private void DodajPytanie_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxIleOdp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
