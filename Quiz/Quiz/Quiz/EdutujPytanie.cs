﻿using System;
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
        
        int pom = 0;
        int pom2;
        Int32 ileOdp = 0;

        public EdutujPytanie()
        {
            InitializeComponent();
            wczytajPytania();
        }
        void wczytajPytania()
        {
            listBoxPytania.Items.Clear();
            listBoxPytania.Items.AddRange(baza.Polaczenie.Pytanias.OrderBy(o => o.tresc).ToArray());
            listBoxPytania.DisplayMember = "tresc";
        }

        private void EdutujPytanie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychQuizDataSet.Kategoria' table. You can move, or remove it, as needed.
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
         
            
             if (comboBoxIleOdp.Text == "")
             {

                 if (pom == 0)
                 {
                     if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                 }
                 else if (pom == 1)
                 {
                     npyt = listBoxPytania.SelectedItem as Pytania;
                     pom2 = npyt.Id;
                     npyt.tresc = textBoxPytanie.Text;
                     npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                     npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                     pom = 0;
                 }
                 baza.Polaczenie.SubmitChanges();
                 wczytajPytania();
                 textBoxPytanie.Text = "";
                 numericUpDownPoziom.Value = 0;
                 comboBoxIleOdp.Text = "";
                 comboBoxKategoria.Text = "";
                 panel1.Controls.Clear();
                // this.Close();
             }
             else
             {
                 ileOdp = Convert.ToInt32(comboBoxIleOdp.Text) - 1;

                 if (ileOdp == 0)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
                 if (ileOdp == 1)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                       //  this.Close();
                     }
                 }
                 if (ileOdp == 2)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                       //  this.Close();
                     }
                 }
                 if (ileOdp == 3)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
                 if (ileOdp == 4)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
                 if (ileOdp == 5)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[5].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                         //this.Close();
                     }
                 }
                 if (ileOdp == 6)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[5].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[6].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
                 if (ileOdp == 7)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[5].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[6].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[7].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                       //  this.Close();
                     }
                 }
                 if (ileOdp == 8)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[5].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[6].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[7].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[8].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
                 if (ileOdp == 9)
                 {
                     if (panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[1].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[2].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[3].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[4].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[5].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[6].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[7].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[8].Controls["textBoxOdpowiedz"].Text == "" || panel1.Controls[9].Controls["textBoxOdpowiedz"].Text == "")
                     {
                         MessageBox.Show("Pusta odpowiedz");
                     }
                     else
                     {
                         if (pom == 0)
                         {
                             if (textBoxPytanie.Text == "" || comboBoxIleOdp.Text == "" || numericUpDownPoziom.Text == "" || comboBoxKategoria.Text == "")
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
                         }
                         else if (pom == 1)
                         {
                             npyt = listBoxPytania.SelectedItem as Pytania;
                             pom2 = npyt.Id;
                             npyt.tresc = textBoxPytanie.Text;
                             npyt.id_kategoria = baza.Polaczenie.Kategorias.Where(x => x.nazwa == comboBoxKategoria.Text).Select(s => s.Id).First();
                             npyt.id_typ = baza.Polaczenie.Typ_pytanias.Where(x => x.poziom == numericUpDownPoziom.Value).Select(s => s.Id).First();
                             pom = 0;
                         }
                         baza.Polaczenie.SubmitChanges();
                         wczytajPytania();
                         textBoxPytanie.Text = "";
                         numericUpDownPoziom.Value = 0;
                         comboBoxIleOdp.Text = "";
                         comboBoxKategoria.Text = "";
                         panel1.Controls.Clear();
                        // this.Close();
                     }
                 }
             }
             var Form = new EdutujPytanie();
             this.Close();
             Form.Show();
           
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
                        baza.Polaczenie.Odpowiedzis.DeleteOnSubmit(o);
                }

                baza.Polaczenie.SubmitChanges();

                MessageBox.Show("Usunięto pomyślnie", "Informacja");
            }
            wczytajPytania();

        }

        private void buttonDodajOdp_Click(object sender, EventArgs e)
        {
            
            if (pom == 0)
            {

                string ile = comboBoxIleOdp.Text;
                Int32 ileOdpowiedzi = Convert.ToInt32(ile);
                ileOdp = Convert.ToInt32(ile);
                int move = 0;
                panel1.Controls.Clear();
                for (Int32 i = 0; i < ileOdpowiedzi; i++)
                {
                    DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi();
                    generator.Location = new Point(5, 10 + move);
                    generator.Size = new System.Drawing.Size(generator.Width - 120, 45);
                    panel1.Controls.Add(generator);
                    move += 35;
                    pyt1.Odpowiedzis.Add(generator.OdpowiedziDane);
                }
            }
            else
            {
                panel1.Controls.Clear();
                npyt = listBoxPytania.SelectedItem as Pytania;
                npyt.tresc = textBoxPytanie.Text;
                string ile = comboBoxIleOdp.Text;
                Int32 ileodp = Convert.ToInt32(ile);
                int move = 0;
                for (Int32 i = 0; i < ileodp; i++)
                {
                    DodawanieOdpowiedzi generator = new DodawanieOdpowiedzi();
                    generator.Location = new Point(5, 10 + move);
                    generator.Size = new System.Drawing.Size(generator.Width - 120, 45);
                    panel1.Controls.Add(generator);
                    move += 35;
                    npyt.Odpowiedzis.Add(generator.OdpowiedziDane);
                    
                }
            }
        }

        private void buttonUsunPoziom_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdytujKategoria_Click(object sender, EventArgs e)
        {

        }

        private void buttonCzysc_Click(object sender, EventArgs e)
        {
           
            pom = 0;       
            textBoxPytanie.Text = "";
            numericUpDownPoziom.Value = 0;
            comboBoxIleOdp.Text = "";
            comboBoxKategoria.Text = "";
           /* if(panel1.Controls[0].Controls["textBoxOdpowiedz"].Text == "" )
            {
  foreach (Control item in panel1.Controls.OfType<Control>())
            {
                if ( item.Name == "texBoxOdpowiedz")
                    panel1.Controls.Remove(item);
            }
            
            }*/
          
            panel1.Controls.Clear();
            
        }

        private void buttonZapisz_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }
    }
}
    
