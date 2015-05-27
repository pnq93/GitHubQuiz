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
    public partial class Statystyka : UserControl
    {
        private Game game;

        public Statystyka()
        {
            InitializeComponent();
        }

        public Statystyka(Game game)
        {
            InitializeComponent();
            this.game = game;


            
            richTextBoxStat.Text = "";
            
            foreach (Table r in baza.Polaczenie.Tables)
            {
                richTextBoxStat.AppendText(String.Format("Użytkownik: {0} --> {1} pkt. \n", r.uzytkownik_nazwa, r.wynik)); 
                
            }

        }

        private void listBoxWynik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxStat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Statystyka_Load(object sender, EventArgs e)
        {

        }
    }
}
