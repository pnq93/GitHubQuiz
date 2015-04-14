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
        private int forma;
        public Odpowiedzi OdpowiedziDane
        {
            get { return odp; }
        }

        public DodawanieOdpowiedzi(int forma)
        {
            this.forma = forma;
            this.odp = new Odpowiedzi();
            if (forma == 0)
            {
            textBoxOdpowiedz.DataBindings.Add(new Binding("Text", odp, "odp"));

            this.checkBoxCzyPrawda.DataBindings.Add(new Binding("Checked", odp, "czy_poprawna"));

          
                baza.Polaczenie.SubmitChanges();
            }
        }


        public DodawanieOdpowiedzi()
        {
            InitializeComponent();
            this.odp = new Odpowiedzi();
         
                textBoxOdpowiedz.DataBindings.Add(new Binding("Text", odp, "odp"));
                checkBoxCzyPrawda.DataBindings.Add(new Binding("Checked", odp, "czy_poprawna"));       
        }

        public DodawanieOdpowiedzi(Odpowiedzi odp)
        {
            InitializeComponent();
            this.odp = odp;

            // textBoxOdpowiedz.Text = odp.odp;
            if (odp.czy_poprawna == 1)
            {
                checkBoxCzyPrawda.Checked = true;
            }
            else
            {
                checkBoxCzyPrawda.Checked = false;
            }
           
            
                textBoxOdpowiedz.DataBindings.Add(new Binding("Text", odp, "odp"));
                checkBoxCzyPrawda.DataBindings.Add(new Binding("Checked", odp, "czy_poprawna"));
           

            
        }



        private void textBoxOdpowiedz_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodawanieOdpowiedzi_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxCzyPrawda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            baza.Polaczenie.Odpowiedzis.DeleteOnSubmit(odp);
            baza.Polaczenie.SubmitChanges();
            
        }


    }
}
