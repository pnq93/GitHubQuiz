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
    public partial class EdutujPytanie : Form
    {

        Pytania npyt;
        Pytania pyt1 = new Pytania();
        Pytania p;
        int ile = 0;
        int pom = 0;
        int pom2;
        Int32 ileOdp = 0;


        public EdutujPytanie()
        {
            InitializeComponent();
            wczytajPytania();
            usunComboBoxKategoria();
            wypelnijComboBoxKategoria();
        }
        void wczytajPytania()
        {
            listBoxPytania.Items.Clear();
            listBoxPytania.Items.AddRange(baza.Polaczenie.Pytanias.OrderBy(o => o.tresc).ToArray());
            listBoxPytania.DisplayMember = "tresc";
        }
        void wypelnijComboBoxKategoria()
        {
            foreach (Kategoria k in baza.Polaczenie.Kategorias)
                comboBoxKategoria.Items.Add(k.nazwa);
        }
        void usunComboBoxKategoria()
        {
            foreach (Kategoria k in baza.Polaczenie.Kategorias)
                comboBoxKategoria.Items.Remove(k.nazwa);
        }
        public int iloscUC()
        {
            int ileUC = 0;
            foreach (DodawanieOdpowiedzi dododp in panel1.Controls)
            {
                ileUC += 1;
            }
            return ileUC;
        }


        private void EdutujPytanie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychQuizDataSet.Kategoria' table. You can move, or remove it, as needed.
        }

       /* private void buttonEdytuj_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            ile = 0;
            if (listBoxPytania.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
            }
            else
            {
                pom = 1;
                Pytania pytanie = listBoxPytania.SelectedItem as Pytania;

                pom2 = pytanie.Id;
                if (listBoxPytania.SelectedItem == null)
                {
                    MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
                }
                else
                {
                    textBoxPytanie.Text = pytanie.tresc;
                    numericUpDownPoziom.Value = baza.Polaczenie.Typ_pytanias.Where(x => x.Id == pytanie.id_typ).Select(s => s.poziom).ToArray().First();
                    comboBoxKategoria.Text = baza.Polaczenie.Kategorias.Where(x => x.Id == pytanie.id_kategoria).Select(s => s.nazwa).ToArray().First();
                    int move = 0;
                    panel1.Controls.Clear();
                    foreach (Odpowiedzi odp in pytanie.Odpowiedzis)
                    {
                        DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi(odp);
                        generator.Location = new Point(5, 10 + move);
                        panel1.Controls.Add(generator);
                        move += 35;
                    }
                }
            }
            int liczbaUC = iloscUC();
            foreach (DodawanieOdpowiedzi odp in panel1.Controls)
            {
                odp.liczenie(liczbaUC);
            }
        }*/

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            int ileO = 0;
            bool czy = true;
            foreach (Odpowiedzi o in pyt1.Odpowiedzis)
            {
                if (panel1.Controls[ileO].Controls["textBoxOdpowiedz"].Text == "")
                {
                    czy = false;
                }
                ileO++;
            }
            if (czy == true)
            {
                if (pom == 0)
                {
                    int ist = 0;
                    foreach (Pytania p in baza.Polaczenie.Pytanias)
                    {
                        if (p.tresc == textBoxPytanie.Text)
                        {
                            ist = 1;
                        }
                    }
                    if (ist == 1)
                    {
                        MessageBox.Show("Pytanie istnieje w bazie");
                    }
                    else
                    {
                        if (textBoxPytanie.Text == "" /*|| comboBoxIleOdp.Text == ""*/ || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
                        {
                            MessageBox.Show("Wypełnij każde pole formularza", "Błąd");
                        }
                        else
                        {
                            pyt1.tresc = textBoxPytanie.Text;
                            pyt1.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                            pyt1.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                            baza.Polaczenie.Pytanias.InsertOnSubmit(pyt1);
                        }
                        bool pop = true;
                        int pomocnicza = 0;
                        foreach (DodawanieOdpowiedzi odpp in panel1.Controls)
                        {
                            if (odpp.czyZaznaczonaPoprawna() == false)
                            {
                                pop = false;

                            }
                            else
                            {
                                pomocnicza = 1;
                            }

                        }
                        if (pomocnicza == 1)
                        {
                            baza.Polaczenie.SubmitChanges();
                            MessageBox.Show("Zapisano", "Informacja");
                            wczytajPytania();
                            var Form = new EdutujPytanie();
                            this.Close();
                            Form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Przynajmniej jedna odpowiedź musi być poprawna");

                        }
                    }
                }
                else if (pom == 1)
                {
                    npyt = listBoxPytania.SelectedItem as Pytania;
                    pom2 = npyt.Id;
                    npyt.tresc = textBoxPytanie.Text;
                    npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                    npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                    pom = 0;
                    bool czy1 = true;
                    foreach (Odpowiedzi o in npyt.Odpowiedzis)
                    {
                        if (panel1.Controls[ileO].Controls["textBoxOdpowiedz"].Text == "")
                        {
                            czy1 = false;
                        }
                        ileO++;
                    }
                    if (czy1 == true)
                    {
                        bool pop = true;
                        int pomocnicza = 0;
                        foreach (DodawanieOdpowiedzi odpp in panel1.Controls)
                        {
                            if (odpp.czyZaznaczonaPoprawna() == false)
                            {
                                pop = false;

                            }
                            else
                            {
                                pomocnicza = 1;
                            }

                        }
                        if (pomocnicza == 1)
                        {
                            baza.Polaczenie.SubmitChanges();
                            MessageBox.Show("Zapisano", "Informacja");
                            wczytajPytania();
                            var Form = new EdutujPytanie();
                            this.Close();
                            Form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Przynajmniej jedna odpowiedź musi być poprawna");
                            pom = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pusta odpowiedz");
                        pom = 1;
                    }
                }
            }

            else
            {
                MessageBox.Show("Pusta odpowiedz");
            }
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
                    {
                        baza.Polaczenie.Odpowiedzis.DeleteOnSubmit(o);

                    }


                }

                foreach (Zadane_Pytania z in baza.Polaczenie.Zadane_Pytanias)
                {
                    if (id == z.id_pytania)
                    {
                        baza.Polaczenie.Zadane_Pytanias.DeleteOnSubmit(z);

                    }
                }

                baza.Polaczenie.SubmitChanges();
                MessageBox.Show("Usunięto pomyślnie", "Informacja");
            }
            pom = 0;
            textBoxPytanie.Text = "";
            numericUpDownPoziom.Value = 0;
            comboBoxIleOdp.Text = "";
            comboBoxKategoria.Text = "";
            panel1.Controls.Clear();
            wczytajPytania();

        }

        private void buttonDodajOdp_Click(object sender, EventArgs e)
        {
            if (comboBoxIleOdp.Text != "")
            {
                if (pom == 0)
                {
                    string ile = comboBoxIleOdp.Text;
                    Int32 ileOdpowiedzi = Convert.ToInt32(ile);
                    ileOdp = Convert.ToInt32(ile);
                    int move = 0;
                    //panel1.Controls.Clear();
                    for (Int32 i = 0; i < ileOdpowiedzi; i++)
                    {
                        DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi();
                        generator.Location = new Point(2, move);
                        generator.Size = new System.Drawing.Size(generator.Width, 45);
                        panel1.Controls.Add(generator);
                        move += 5;
                        pyt1.Odpowiedzis.Add(generator.OdpowiedziDane);
                    }
                }
                else
                {
                    npyt = listBoxPytania.SelectedItem as Pytania;
                    npyt.tresc = textBoxPytanie.Text;
                    string ile = comboBoxIleOdp.Text;
                    Int32 ileodp = Convert.ToInt32(ile);
                    int move = 0;
                    for (Int32 i = 0; i < ileodp; i++)
                    {
                        DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi();
                        generator.Location = new Point(2, move);
                        generator.Size = new System.Drawing.Size(generator.Width, 45);
                        panel1.Controls.Add(generator);
                        move += 5;
                        npyt.Odpowiedzis.Add(generator.OdpowiedziDane);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano ilości dodawanych odpowiedzi");
            }
        }

        private void buttonCzysc_Click(object sender, EventArgs e)
        {

            pom = 0;
            textBoxPytanie.Text = "";
            numericUpDownPoziom.Value = 0;
            comboBoxIleOdp.Text = "";
            comboBoxKategoria.Text = "";
            panel1.Controls.Clear();
            // var Form = new EdutujPytanie();
            // this.Close();
            // Form.Show();

        }

        private void buttonDodajKat_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoria.Text != "")
            {
                int czyIstnieje = 0;
                foreach (Kategoria k in baza.Polaczenie.Kategorias)
                {
                    if (k.nazwa == comboBoxKategoria.Text)
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
                    kat.nazwa = comboBoxKategoria.Text;
                    baza.Polaczenie.Kategorias.InsertOnSubmit(kat);
                    baza.Polaczenie.SubmitChanges();
                    usunComboBoxKategoria();
                    wypelnijComboBoxKategoria();
                    MessageBox.Show("Kategoria dodana", "Informacja");
                }
            }
            else
            {
                MessageBox.Show("Nie można dodać pustej kategori", "Informacja");
            }
        }

        private void buttonEdytujKat_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoria.Text != "")
            {
                Kategoria kat = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).ToArray().First();

                var Form = new EdytujKategorie(kat, comboBoxKategoria.Text);
                Form.Show();
            }
            else
            {
                MessageBox.Show("Nie można edytować pustej kategori", "Informacja");
            }


        }
        public bool sprawdzKategorie()
        {

            //var uzytk = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == uzytkownik.ToLower() && x.password == h.SzyfrujMD5(haslo));
            var kats = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text);
            if (kats.Count() != 0)
            {
                return true;
            }
            return false;

        }
        private void buttonUsunKat_Click(object sender, EventArgs e)
        {
            if (comboBoxKategoria.Text != "")
            {
                int pom = 0;
                if (sprawdzKategorie())
                {
                    Kategoria k = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).First();
                    int idKat = k.Id;
                    foreach (Pytania p in baza.Polaczenie.Pytanias)
                    {
                        if (idKat == p.id_kategoria)
                        {
                            pom = 1;
                        }
                    }
                    if (pom == 1)
                    {
                        MessageBox.Show("Nie można usunąć kategori. Kategoria jest przypisana do pytania");
                    }
                    else if (pom == 0)
                    {
                        var usunKat = baza.Polaczenie.Kategorias.Where(u => u.nazwa == comboBoxKategoria.Text);
                        baza.Polaczenie.Kategorias.DeleteAllOnSubmit(usunKat);
                        baza.Polaczenie.SubmitChanges();
                        MessageBox.Show("Kategoria została usunięta");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej kategori do usunięcia");
            }
            usunComboBoxKategoria();
            // wypelnijComboBoxKategoria();
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            int liczbaUC = iloscUC();
            foreach (DodawanieOdpowiedzi odp in panel1.Controls)
            {
                odp.liczenie(liczbaUC);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxPytania_MouseClick(object sender, MouseEventArgs e)
        {

            Pytania pyt = listBoxPytania.SelectedItem as Pytania;
            foreach (Zadane_Pytania p in baza.Polaczenie.Zadane_Pytanias)
            {
                if (p.id_pytania == pyt.Id)
                {
                    baza.Polaczenie.Zadane_Pytanias.DeleteOnSubmit(p);
                }
            }
            baza.Polaczenie.SubmitChanges();

            panel1.Controls.Clear();
            ile = 0;
            if (listBoxPytania.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
            }
            else
            {
                pom = 1;
                Pytania pytanie = listBoxPytania.SelectedItem as Pytania;

                pom2 = pytanie.Id;
                if (listBoxPytania.SelectedItem == null)
                {
                    MessageBox.Show("Nie wybrano żadnego elementu", "Błąd edycji");
                }
                else
                {
                    textBoxPytanie.Text = pytanie.tresc;
                    numericUpDownPoziom.Value = baza.Polaczenie.Typ_pytanias.Where(x => x.Id == pytanie.id_typ).Select(s => s.poziom).ToArray().First();
                    comboBoxKategoria.Text = baza.Polaczenie.Kategorias.Where(x => x.Id == pytanie.id_kategoria).Select(s => s.nazwa).ToArray().First();
                    int move = 0;
                    panel1.Controls.Clear();
                    foreach (Odpowiedzi odp in pytanie.Odpowiedzis)
                    {
                        DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi(odp);
                        generator.Location = new Point(5, 10 + move);
                        panel1.Controls.Add(generator);
                        move += 35;
                    }
                }
            }
            int liczbaUC = iloscUC();
            foreach (DodawanieOdpowiedzi odp in panel1.Controls)
            {
                odp.liczenie(liczbaUC);
            }
         
           
        }

        

        
    }
}


