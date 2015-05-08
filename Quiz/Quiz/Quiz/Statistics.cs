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
    public partial class Statistics : Form
    {
        private int wynik;
        private string uzytkownik;

        public Statistics()
        {
            InitializeComponent();
            
        }

        public Statistics(int wynik, string uzytkownik)
        {
            // TODO: Complete member initialization 
            InitializeComponent();
            this.wynik = wynik;
            this.uzytkownik = uzytkownik;       
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
