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
        private Uzytkownicy uzy;
        private PanelAdmin panelAdmin;
        
        public EditUzyt()
        {
            InitializeComponent();
   
        }

        public EditUzyt(PanelAdmin panelAdmin)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.panelAdmin = panelAdmin;
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
        public Uzytkownicy InfoUzytkownik
        {
            get { return uzy; }
        }
        private void EditUzyt_Load(object sender, EventArgs e)
        {
        }
        private void listBoxuzytkownicy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listBoxuzytkownicy.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd usuwania");
            }
            else
            {
                var usunUzyt = baza.Polaczenie.Uzytkownicies.Where(u => u.user_name == listBoxuzytkownicy.Text);

                baza.Polaczenie.Uzytkownicies.DeleteAllOnSubmit(usunUzyt);
                baza.Polaczenie.SubmitChanges();

                listBoxuzytkownicy.Refresh();
                MessageBox.Show("Uzytkownik " + listBoxuzytkownicy.Text + " został usunięty", "Usuwanie");
                listBoxuzytkownicy.Refresh();
            }

        }

     

      
    }
}
