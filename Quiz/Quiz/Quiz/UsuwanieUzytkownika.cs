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
        bazaDanychQuizDataContext bazaDC = new bazaDanychQuizDataContext();
        public UsuwanieUzytkownika()
        {
            InitializeComponent();
            foreach (Uzytkownicy u in bazaDC.Uzytkownicies)
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
            var usunUzyt = bazaDC.Uzytkownicies.Where(u => u.user_name == listBox1.Text);
                
                {
                    bazaDC.Uzytkownicies.DeleteAllOnSubmit(usunUzyt);
                    bazaDC.SubmitChanges();
                }
                listBox1.Refresh();
            MessageBox.Show("Uzytkownik " + listBox1.Text + " został usunięty");
            this.Close();
        }
    }
}
