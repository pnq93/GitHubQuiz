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
    public partial class NewGamecs : Form
    {
        Pytania pyt;
        Int32 licznik = 1;
        Random rand = new Random();
        Zadane_Pytania zp = new Zadane_Pytania();
        public NewGamecs()
        {
            InitializeComponent();
            losuj();
        }
        void losuj()
        {
            Int32 nr = rand.Next(baza.Polaczenie.Pytanias.Count());
            pyt = baza.Polaczenie.Pytanias.Skip(nr).First();
            losowanePytanie.Text = pyt.tresc;


            odp1.Text = baza.Polaczenie.Odpowiedzis.Where(x => x.id_pytania == pyt.Id).Select(s => s.odp).First();
            odp2.Text = baza.Polaczenie.Odpowiedzis.Where(z => z.id_pytania == pyt.Id && z.odp != odp1.Text).Select(a => a.odp).First();
            odp3.Text = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == pyt.Id && y.odp != odp1.Text && y.odp != odp2.Text).Select(b => b.odp).First();
            odp4.Text = baza.Polaczenie.Odpowiedzis.Where(w => w.id_pytania == pyt.Id && w.odp != odp1.Text && w.odp != odp2.Text && w.odp != odp3.Text).Select(c => c.odp).First();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewGamecs_Load(object sender, EventArgs e)
        {

        }

        private void dalej_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 5;
            if (odp1.Checked || odp2.Checked || odp3.Checked || odp4.Checked)
            {
                if(licznik < 5)
                {
                losowanePytanie.Text = "";
                odp1.Text = "";
                odp1.Checked = false;
                odp2.Text = "";
                odp2.Checked = false;
                odp3.Text = "";
                odp3.Checked = false;
                odp4.Text = "";
                odp4.Checked = false;
                licznik += 1;
                losuj();
                }
                else
                {
                    MessageBox.Show("Koniec rozgrywki");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej odp");               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void koniec_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
