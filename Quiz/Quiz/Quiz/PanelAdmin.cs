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
    public partial class PanelAdmin : Form
    {

        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void dodaj_pyt_Click(object sender, EventArgs e)
        {
            var Form = new DodajPytanie();
            Form.Show();
        }

        private void usun_uzyt_Click(object sender, EventArgs e)
        {
           
        }

        private void dodAdmin_Click(object sender, EventArgs e)
        {
            var Form = new DodajAdmina();
            Form.Show();
        }

        private void edycja_Click(object sender, EventArgs e)
        {
            EdycjaUzytkownika fe = new EdycjaUzytkownika();
            fe.Show();
        }

        private void EdycjaUzytkownika_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

      
     

        private void edytujPytanie_Click(object sender, EventArgs e)
        {
            EdutujPytanie fe = new EdutujPytanie();
            fe.Show();
        }
    }
}
    
