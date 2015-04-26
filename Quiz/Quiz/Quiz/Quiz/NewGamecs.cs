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
        int pom = 0;
        Int32 licznik = 1;
        Random rand = new Random();
        Zadane_Pytania zp = new Zadane_Pytania();
        List<int> idpyt = new List<int>();
        int ile = 0;
        string poprawnaOdp;

        public NewGamecs()
        {
            InitializeComponent(); progressBar1.ForeColor = Color.Black;
            foreach (Pytania p in baza.Polaczenie.Pytanias)
            {
                idpyt.Add(p.Id);
                ile += 1;
            }
            int x = rand.Next(ile);
            Pytania pp = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[x]).First();
            string pytanie = baza.Polaczenie.Pytanias.Where(w => w.Id == idpyt[x]).Select(s => s.tresc).First();
           // zp.id_pytania = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[x]).Select(s => s.Id).First();
            //baza.Polaczenie.Zadane_Pytanias.InsertOnSubmit(zp);
            //baza.Polaczenie.SubmitChanges();
            losowanePytanie.Text = pytanie;
            odp1.Text = baza.Polaczenie.Odpowiedzis.Where(t => t.id_pytania == idpyt[x]).Select(s => s.odp).First();
            odp2.Text = baza.Polaczenie.Odpowiedzis.Where(z => z.id_pytania == idpyt[x] && z.odp != odp1.Text).Select(a => a.odp).First();
            odp3.Text = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[x] && y.odp != odp1.Text && y.odp != odp2.Text).Select(b => b.odp).First();
            odp4.Text = baza.Polaczenie.Odpowiedzis.Where(w => w.id_pytania == idpyt[x] && w.odp != odp1.Text && w.odp != odp2.Text && w.odp != odp3.Text).Select(c => c.odp).First();
            
            foreach (Odpowiedzi oo in pp.Odpowiedzis)
            {
                if (oo.czy_poprawna == 1)
                {
                    poprawnaOdp = oo.odp.ToString();
                }
            }
           // MessageBox.Show("odp " + poprawnaOdp);
            idpyt.RemoveAt(x);
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
            progressBar1.Maximum = 4;
            if (odp1.Checked || odp2.Checked || odp3.Checked || odp4.Checked)
            {
                if (pom == 0)
                {
                    if (odp1.Checked == true)
                    {
                        if (odp1.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }

                    if (odp2.Checked == true)
                    {
                        if (odp2.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }

                    if (odp3.Checked == true)
                    {
                        if (odp3.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }

                    if (odp4.Checked == true)
                    {
                        if (odp4.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }
                    pom += 1;
                }
                else if (pom == 1)
                {
                    if (odp1.Checked == true)
                    {
                        if (odp1.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }
                    if (odp2.Checked == true)
                    {
                        if (odp2.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }
                    if (odp3.Checked == true)
                    {
                        if (odp3.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }
                    if (odp4.Checked == true)
                    {
                        if (odp4.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                        }
                    }
                }

                if (licznik < 5)
                {
                    progressBar1.Value = licznik;
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

                    if (pom == 1)
                    {
                        ile = 0;
                        foreach (int i in idpyt)
                        {
                            ile += 1;
                        }
                        int z = rand.Next(ile);
                        Pytania ppp = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[z]).First();
                        string pytanie1 = baza.Polaczenie.Pytanias.Where(q => q.Id == idpyt[z]).Select(s => s.tresc).First();
                        foreach (Odpowiedzi ooo in ppp.Odpowiedzis)
                        {
                            if (ooo.czy_poprawna == 1)
                            {
                                poprawnaOdp = ooo.odp.ToString();

                            }
                        }
                        losowanePytanie.Text = pytanie1;
                        odp1.Text = baza.Polaczenie.Odpowiedzis.Where(x => x.id_pytania == idpyt[z]).Select(s => s.odp).First();
                        odp2.Text = baza.Polaczenie.Odpowiedzis.Where(a => a.id_pytania == idpyt[z] && a.odp != odp1.Text).Select(a => a.odp).First();
                        odp3.Text = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp != odp1.Text && y.odp != odp2.Text).Select(b => b.odp).First();
                        odp4.Text = baza.Polaczenie.Odpowiedzis.Where(w => w.id_pytania == idpyt[z] && w.odp != odp1.Text && w.odp != odp2.Text && w.odp != odp3.Text).Select(c => c.odp).First();

                       // MessageBox.Show("odp " + poprawnaOdp);
                        idpyt.RemoveAt(z);
                    }
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
