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
    public partial class DodUzy : UserControl
    {
        
        private PanelAdmin panelAdmin;
          Haszowanie hash = new Haszowanie();
        private Uzytkownicy osoba;

        public DodUzy()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
        }

        public DodUzy(PanelAdmin panelAdmin)
        {
            // TODO: Complete member initialization
            this.panelAdmin = panelAdmin;
        }

      

        private void DodUzy_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
             if (textBoxLogin.Text == "" || textBoxHaslo.Text == "")
            {
                MessageBox.Show("Uzupełnij każde pole w formularzu", "Błąd rejestracji");
            }
            else
            {
                int czyIstnieje = 0;
                foreach (Uzytkownicy u in baza.Polaczenie.Uzytkownicies)
                {
                    if (u.user_name == textBoxLogin.Text)
                    {
                        czyIstnieje = 1;
                    }
                }
                if (czyIstnieje == 1)
                {
                    MessageBox.Show("Użytkownik istnieje", "Błąd");
                }
                else
                {
                    osoba = new Uzytkownicy();
                    osoba.user_name = textBoxLogin.Text;
                    osoba.password = hash.SzyfrujMD5(textBoxHaslo.Text);
                    osoba.czy_admin = 0;
                    baza.Polaczenie.Uzytkownicies.InsertOnSubmit(osoba);
                    baza.Polaczenie.SubmitChanges();
                    textBoxLogin.Text = "";
                    textBoxHaslo.Text = "";
                    MessageBox.Show("Dodano użytkownika " + textBoxLogin.Text);

                }
            }
        }
    }
        }
    
