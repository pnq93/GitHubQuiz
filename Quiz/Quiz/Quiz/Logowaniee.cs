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
    public partial class Logowaniee : UserControl
    {
      
        private RejestracjaUC rejestracjaUC;
        private Logowanie logowanie;

        public Logowaniee(Logowanie logowanie)
        {
            InitializeComponent();
            this.logowanie = logowanie;
            pass.PasswordChar = '*';
        }

      

        private void login_Click(object sender, EventArgs e)
        {
             Haszowanie h = new Haszowanie();
            Gra g = new Gra();
            string uzytkownik = user.Text;
            string haslo = pass.Text;
            string hasloHasz = h.SzyfrujMD5(haslo);
           
            
                if (SprawdzNazweiHaslo(uzytkownik, haslo))
                {
                    
                    Uzytkownicy u = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == uzytkownik).First();
                    string admin = u.czy_admin.ToString();
                    
                    g.id_uzytkownika = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == user.Text).Select(s => s.Id).First();
                    g.data_rozgrywki = DateTime.Now;
                    
                    if (admin == "1")
                    {
                      
                        logowanie.Hide();
                        (new PanelAdmin()).Show();                                      
                    }
                    else
                    {
                        
                        logowanie.Hide();   
                        (new Game()).Show();
                      
                        baza.Polaczenie.Gras.InsertOnSubmit(g);
                        baza.Polaczenie.SubmitChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                    return;
                }
                NewGamecs noweOkno = new NewGamecs(uzytkownik);
                NewGamecs n = new NewGamecs(baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == user.Text).Select(s => s.Id).First());
                    }

          public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {
            Haszowanie h = new Haszowanie();
            var uzytk = baza.Polaczenie.Uzytkownicies.Where(x => x.user_name == uzytkownik.ToLower() && x.password == h.SzyfrujMD5(haslo));

            if (uzytk.Count() != 0)
            {
                return true;
            }
            return false;
           
        }

          private void rejestracja_Click(object sender, EventArgs e)
          {
              logowanie.panel1.Controls.Clear();
              RejestracjaUC r = new RejestracjaUC();
              logowanie.panel1.Controls.Add(r);
          }

          private void Logowaniee_Load(object sender, EventArgs e)
          {

          }

        }
    }

