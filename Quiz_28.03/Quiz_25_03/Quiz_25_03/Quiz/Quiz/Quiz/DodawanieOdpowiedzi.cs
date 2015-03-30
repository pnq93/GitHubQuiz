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
    public partial class DodawanieOdpowiedzi : UserControl
    {
        
        private Odpowiedzi odp;
        public Odpowiedzi OdpowiedziDane
        {
            get { return odp; }
        }


        public DodawanieOdpowiedzi()
        {
            InitializeComponent();
            this.odp = new Odpowiedzi();

            textBoxOdpowiedz.DataBindings.Add(new Binding("Text", odp, "odp"));
           // checkBoxCzyPrawda.DataBindings.Add(new Binding("Checked", czy_poprawna, "czy_poprawna"));
           
            baza.Polaczenie.SubmitChanges();
        }
 

    }
}
