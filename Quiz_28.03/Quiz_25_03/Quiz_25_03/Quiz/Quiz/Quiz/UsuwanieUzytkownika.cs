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
    public partial class UsuwanieUzytkownika : Form
    {

        public UsuwanieUzytkownika()
        {
            InitializeComponent();
            foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
            {
                listBox1.Items.Add(u);
            }
            listBox1.DisplayMember = "user_name";

        }

        private void listaUzytkownikow_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaUzytkownikow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsuwanieUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.Refresh();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnego elementu", "Błąd usuwania");
            }
            else
            {
                var usunUzyt = baza.Polaczenie.Uzytkownicies.Where(u => u.user_name == listBox1.Text);

                baza.Polaczenie.Uzytkownicies.DeleteAllOnSubmit(usunUzyt);
                baza.Polaczenie.SubmitChanges();

                listBox1.Refresh();
                MessageBox.Show("Uzytkownik " + listBox1.Text + " został usunięty", "Usuwanie");
                this.Close();
            }

        }
    }
}
