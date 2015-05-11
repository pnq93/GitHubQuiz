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
            // TODO: Complete member initialization
            this.game = game;
            listBoxWynik.Items.Clear();
            listBoxWynik.Items.AddRange(baza.Polaczenie.Tables.OrderBy(o => o.wynik).ToArray());
            listBoxWynik.DisplayMember = "wynik";
        }

        private void listBoxWynik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
