using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class EditUzyt : UserControl
    {
        private PanelAdmin panelAdmin;
        int idGry;
        public EditUzyt()
        {
            InitializeComponent();
        }

        public EditUzyt(PanelAdmin panelAdmin)
        {
            InitializeComponent();
            // TODO: Complete member initialization
           
            this.panelAdmin = panelAdmin;
            listBoxuzytkownicy.Items.Clear();
            listBoxuzytkownicy.Items.AddRange(baza.Polaczenie.Uzytkownicies.OrderBy(o => o.user_name).ToArray());
            listBoxuzytkownicy.DisplayMember = "user_name";
        }
    
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            panelAdmin.panel1.Controls.Clear();
            DodUzy du = new DodUzy();
            panelAdmin.panel1.Controls.Add(du);
        }
        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            panelAdmin.panel1.Controls.Clear();
            EdycjaUzy eu = new EdycjaUzy(this, baza.Polaczenie, listBoxuzytkownicy.SelectedItem as Uzytkownicy);
            panelAdmin.panel1.Controls.Add(eu);

        }
        private void EditUzyt_Load(object sender, EventArgs e)
        {
        }
        private void listBoxuzytkownicy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            string nazwa = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == listBoxuzytkownicy.Text).Select(s => s.user_name).First();
            var id = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == listBoxuzytkownicy.Text).Select(i => i.Id).First();

            if (nazwa == "admin")
            {
                MessageBox.Show("Nie można usunąć głównego admina");
            }
            else
            {
                if (listBoxuzytkownicy.SelectedItem == null)
                {
                    MessageBox.Show("Nie wybrano żadnego elementu", "Błąd usuwania");
                }
                else
                {
                    var usunUzyt = baza.Polaczenie.Uzytkownicies.Where(u => u.user_name == listBoxuzytkownicy.Text);
                    int idUzyt = baza.Polaczenie.Uzytkownicies.Where(u => u.user_name == listBoxuzytkownicy.Text).Select(s => s.Id).First();
                    foreach(Zadane_Pytania z in baza.Polaczenie.Zadane_Pytanias)
                    {
                        baza.Polaczenie.Zadane_Pytanias.DeleteOnSubmit(z);
                    }
                    baza.Polaczenie.SubmitChanges();
                    foreach (Gra g in baza.Polaczenie.Gras)
                    {
                        if (id == g.id_uzytkownika)
                        {
                            baza.Polaczenie.Gras.DeleteOnSubmit(g);
                            baza.Polaczenie.SubmitChanges();
                        }
                    }
                    foreach (Table t in baza.Polaczenie.Tables)
                    {
                        if (id == t.id_uzytkownika)
                        {
                            baza.Polaczenie.Tables.DeleteOnSubmit(t);
                            baza.Polaczenie.SubmitChanges();
                        }
                    }

               /*    foreach (Gra g in baza.Polaczenie.Gras)
                    {
                        if (id == g.id_uzytkownika)
                        {
                            baza.Polaczenie.Gras.DeleteOnSubmit(g);
                            baza.Polaczenie.SubmitChanges();
                            foreach (Zadane_Pytania z in baza.Polaczenie.Zadane_Pytanias)
                            {
                                if (idGry == z.id_gra)
                                {
                                    baza.Polaczenie.Zadane_Pytanias.DeleteOnSubmit(z);
                                    
                                    
                                    baza.Polaczenie.SubmitChanges();
                                }
                            }
                           
                        }
                    }
                    */
                    baza.Polaczenie.Uzytkownicies.DeleteAllOnSubmit(usunUzyt);
                    baza.Polaczenie.SubmitChanges();
                    listBoxuzytkownicy.Items.Clear();
                    listBoxuzytkownicy.Items.AddRange(baza.Polaczenie.Uzytkownicies.OrderBy(o => o.user_name).ToArray());
                    listBoxuzytkownicy.DisplayMember = "user_name";

                    MessageBox.Show("Uzytkownik " + listBoxuzytkownicy.Text + " został usunięty", "Usuwanie");

                }

            }
        }
     

      
    }
}
