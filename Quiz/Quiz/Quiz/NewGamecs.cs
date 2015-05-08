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
        int ktorePyt = 0;
        int idUzyt;
        int id_zadPyt;
        int idOdp1, idOdp2, idOdp3, idOdp4;
        int iidOdp1, iidOdp2, iidOdp3, iidOdp4;
        int id_gry;
        int poziomPytania,wynik;
        Table stat = new Table();
        int pom = 0;
        Int32 licznik = 1;
        Random rand = new Random();
        List<int> iloscPunktow = new List<int>();
        List<int> idpyt = new List<int>();
        int ile = 0;
        string poprawnaOdp;
        private string uzytkownik;
        private int p;
       
        public NewGamecs()
        {
            InitializeComponent();
            
           
            foreach (Pytania p in baza.Polaczenie.Pytanias)
            {
                idpyt.Add(p.Id);
                ile += 1;
            }
            Zadane_Pytania zp = new Zadane_Pytania();
            int x = rand.Next(ile);
            Pytania pp = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[x]).First();
            string pytanie = baza.Polaczenie.Pytanias.Where(w => w.Id == idpyt[x]).Select(s => s.tresc).First();
            poziomPytania = baza.Polaczenie.Typ_pytanias.Where(u => u.Id == pp.id_typ).Select(c => c.poziom).First();
            
            losowanePytanie.Text = pytanie;
            odp1.Text = baza.Polaczenie.Odpowiedzis.Where(t => t.id_pytania == idpyt[x]).Select(s => s.odp).First();
            idOdp1 = baza.Polaczenie.Odpowiedzis.Where(e => e.id_pytania == idpyt[x] && e.odp == odp1.Text).Select(r => r.Id).First();
            odp2.Text = baza.Polaczenie.Odpowiedzis.Where(z => z.id_pytania == idpyt[x] && z.odp != odp1.Text).Select(a => a.odp).First();
            idOdp2 = baza.Polaczenie.Odpowiedzis.Where(e => e.id_pytania == idpyt[x] && e.odp == odp2.Text).Select(r => r.Id).First();
            odp3.Text = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[x] && y.odp != odp1.Text && y.odp != odp2.Text).Select(b => b.odp).First();
            idOdp3 = baza.Polaczenie.Odpowiedzis.Where(e => e.id_pytania == idpyt[x] && e.odp == odp3.Text).Select(r => r.Id).First();
            odp4.Text = baza.Polaczenie.Odpowiedzis.Where(w => w.id_pytania == idpyt[x] && w.odp != odp1.Text && w.odp != odp2.Text && w.odp != odp3.Text).Select(c => c.odp).First();
            idOdp4 = baza.Polaczenie.Odpowiedzis.Where(e => e.id_pytania == idpyt[x] && e.odp == odp4.Text).Select(r => r.Id).First();
           
            foreach (Odpowiedzi oo in pp.Odpowiedzis)
            {
                if (oo.czy_poprawna == 1)
                {
                    poprawnaOdp = oo.odp.ToString();
                }
            }
            foreach (Gra g in baza.Polaczenie.Gras)
            {
                id_gry = g.Id;
            }
            zp.id_pytania = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[x]).Select(s => s.Id).First();
            zp.id_gra = id_gry;
            ktorePyt += 1;
            //zp.Pytania = baza.Polaczenie.Pytanias.Single(p => p.Id == 49);
            baza.Polaczenie.Zadane_Pytanias.InsertOnSubmit(zp);
            baza.Polaczenie.SubmitChanges();
            idpyt.RemoveAt(x);
            labelIlePyt.Text = ktorePyt+"/5";
            
           
        }

        public NewGamecs(string uzytkownik)
        {
            // TODO: Complete member initialization
            this.uzytkownik = uzytkownik;
        }

        public NewGamecs(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
stat.id_uzytkownika = p;
idUzyt = p;
          
            baza.Polaczenie.Tables.InsertOnSubmit(stat);
          
  baza.Polaczenie.SubmitChanges();
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewGamecs_Load(object sender, EventArgs e)
        {
          /*  Gra g = new Gra();
            Zadane_Pytania zp = new Zadane_Pytania();
            g.Zadane_Pytanias.Add(zp);
            baza.Polaczenie.Gras.InsertOnSubmit(g);
            baza.Polaczenie.SubmitChanges();*/
        }

        private void dalej_Click(object sender, EventArgs e)
        {
            
            
            //progressBar1.Minimum = 0;
          //  progressBar1.Maximum = 4;
           // progressBar1.ForeColor = Color.Red;
           // progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            if (odp1.Checked || odp2.Checked || odp3.Checked || odp4.Checked)
            {
                
                if (pom == 0)
                {
                    Udzielona_odpowiedz ud = new Udzielona_odpowiedz();
                    if (odp1.Checked == true)
                    {
                        ud.id_odpowiedzi = idOdp1;
                        if (odp1.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);

                        }                       
                    }
                    if (odp2.Checked == true)
                    {
                        ud.id_odpowiedzi = idOdp2;
                        if (odp2.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);

                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);

                        }
                    }

                    if (odp3.Checked == true)
                    {
                        ud.id_odpowiedzi = idOdp3;
                        if (odp3.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);

                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);

                        }
                    }

                    if (odp4.Checked == true)
                    {
                        ud.id_odpowiedzi = idOdp4;
                        if (odp4.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);

                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);

                        }
                    }
                  
                   
                    foreach(Zadane_Pytania zp in baza.Polaczenie.Zadane_Pytanias)
                    {
                        id_zadPyt = zp.Id;
                    }
                    pom += 1;
                    ud.id_zadane_pytanie = id_zadPyt;
                    baza.Polaczenie.Udzielona_odpowiedzs.InsertOnSubmit(ud);
                    
                    baza.Polaczenie.SubmitChanges();

                }
                else if (pom == 1)
                {
                   
                    Udzielona_odpowiedz ud = new Udzielona_odpowiedz();
                    if (odp1.Checked == true)
                    {
                        ud.id_odpowiedzi = iidOdp1;
                        if (odp1.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);
                        }
                    }
                    if (odp2.Checked == true)
                    {
                        ud.id_odpowiedzi = iidOdp2;
                        if (odp2.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);
                        }
                    }
                    if (odp3.Checked == true)
                    {
                        ud.id_odpowiedzi = iidOdp3;
                        if (odp3.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);
                        }
                    }
                    if (odp4.Checked == true)
                    {
                        ud.id_odpowiedzi = iidOdp4;
                        if (odp4.Text == poprawnaOdp)
                        {
                            MessageBox.Show("Poprawna");
                            iloscPunktow.Add(poziomPytania);
                        }
                        else
                        {
                            MessageBox.Show("Nie poprawna");
                            iloscPunktow.Add(0);
                        }
                    }
                    foreach (Zadane_Pytania zp in baza.Polaczenie.Zadane_Pytanias)
                    {
                        id_zadPyt = zp.Id;
                    }
                    ud.id_zadane_pytanie = id_zadPyt;
                    baza.Polaczenie.Udzielona_odpowiedzs.InsertOnSubmit(ud);

                    baza.Polaczenie.SubmitChanges();
                }

                if (licznik < 5)
                {
                    ktorePyt += 1;
                    labelIlePyt.Text = ktorePyt + "/5";
                    //progressBar1.Value = licznik;
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
                        Zadane_Pytania zp = new Zadane_Pytania();
                        int z = rand.Next(ile);
                        Pytania ppp = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[z]).First();
                        string pytanie1 = baza.Polaczenie.Pytanias.Where(q => q.Id == idpyt[z]).Select(s => s.tresc).First();
                        poziomPytania = baza.Polaczenie.Typ_pytanias.Where(u => u.Id == ppp.id_typ).Select(c => c.poziom).First();
                        foreach (Odpowiedzi ooo in ppp.Odpowiedzis)
                        {
                            if (ooo.czy_poprawna == 1)
                            {
                                poprawnaOdp = ooo.odp.ToString();

                            }
                        }

                        losowanePytanie.Text = pytanie1;
                        odp1.Text = baza.Polaczenie.Odpowiedzis.Where(x => x.id_pytania == idpyt[z]).Select(s => s.odp).First();
                        iidOdp1 = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp == odp1.Text).Select(r => r.Id).First();
                        odp2.Text = baza.Polaczenie.Odpowiedzis.Where(a => a.id_pytania == idpyt[z] && a.odp != odp1.Text).Select(a => a.odp).First();
                        iidOdp2 = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp == odp2.Text).Select(r => r.Id).First();
                        odp3.Text = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp != odp1.Text && y.odp != odp2.Text).Select(b => b.odp).First();
                        iidOdp3 = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp == odp3.Text).Select(r => r.Id).First();
                        odp4.Text = baza.Polaczenie.Odpowiedzis.Where(w => w.id_pytania == idpyt[z] && w.odp != odp1.Text && w.odp != odp2.Text && w.odp != odp3.Text).Select(c => c.odp).First();
                        iidOdp4 = baza.Polaczenie.Odpowiedzis.Where(y => y.id_pytania == idpyt[z] && y.odp == odp4.Text).Select(r => r.Id).First();

                        zp.id_pytania = baza.Polaczenie.Pytanias.Where(v => v.Id == idpyt[z]).Select(s => s.Id).First();
                        zp.id_gra = id_gry;
                        //zp.Pytania = baza.Polaczenie.Pytanias.Single(p => p.Id == 49);
                       // MessageBox.Show("zd " + zp.id_pytania + " idgry " + id_gry);
                        baza.Polaczenie.Zadane_Pytanias.InsertOnSubmit(zp);
                        baza.Polaczenie.SubmitChanges(); 

                        
                        idpyt.RemoveAt(z);
                    }
                }
                else
                {
                    for (int i = 0; i < 5;i++ )
                    {
                        wynik += iloscPunktow[i];
                    }
                 
                        MessageBox.Show("Koniec rozgrywki");
                        Logowanie noweOkno = new Logowanie(wynik);
                        Statistics noweOknp = new Statistics(wynik, uzytkownik);
                      
                        //stat.id_uzytkownika = idUzyt;
                        stat.wynik = wynik;
                        MessageBox.Show("Wynik: " + stat.wynik + " pkt.", "Podsumowanie");
                   // foreach(Table t in baza.Polaczenie.Tables.Where(t=>t.id_uzytkownika==idUzyt))
                   // {
                    //    t.wynik = wynik;
                   //     
                  //  }

                      
                     
                      // baza.Polaczenie.Tables.InsertOnSubmit(stat);
                       
                   //   baza.Polaczenie.SubmitChanges();
                      
                      
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
