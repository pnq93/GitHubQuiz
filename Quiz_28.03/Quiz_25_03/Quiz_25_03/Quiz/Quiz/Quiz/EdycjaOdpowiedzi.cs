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
    public partial class EdycjaOdpowiedzi : Form
    {
        private bazaDanychQuizDataContext bazaDanychQuizDataContext;
        private Odpowiedzi odpowiedzi;
        

        public EdycjaOdpowiedzi()
        {
            InitializeComponent();
        }

        public EdycjaOdpowiedzi(bazaDanychQuizDataContext bazaDanychQuizDataContext, Odpowiedzi odpowiedzi)
        {
            InitializeComponent();
            this.bazaDanychQuizDataContext = bazaDanychQuizDataContext;
            this.odpowiedzi = odpowiedzi;
            if(odpowiedzi == null)
            {
                MessageBox.Show("Nie wybrano żadnej odpowiedzi", "Błąd edycji");
            }
            else
            textBoxEdycjaOdpowiedzi.Text = odpowiedzi.odp;
        }

        private void EdycjaOdpowiedzi_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapiszOdp_Click(object sender, EventArgs e)
        {
            odpowiedzi.odp = textBoxEdycjaOdpowiedzi.Text;
            baza.Polaczenie.SubmitChanges();
            
            Close();
        }
    }
}
