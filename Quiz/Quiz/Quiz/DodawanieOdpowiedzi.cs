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
      
       
        private int liczbaUC1=0;
        
        private int zmienna=0;
       
        public Odpowiedzi OdpowiedziDane
        {
            get { return odp; }
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
        public void liczenie(int ilosc)
        {
            this.zmienna = ilosc;
        }

        public void usunOdpowiedz()
        {
                MessageBox.Show("usuwam");
                baza.Polaczenie.Odpowiedzis.DeleteOnSubmit(odp);
                baza.Polaczenie.SubmitChanges();
                this.Parent.Controls.Remove(this);

        }
        public void buttonUsun_Click(object sender, EventArgs e)
        {
            if (zmienna > 4)
            {
                usunOdpowiedz();
            }
            else
            {
                MessageBox.Show("nie moge usunac juz :(");
            }
        }
        
        public Boolean czyZaznaczonaPoprawna()
        {

            if (checkBoxCzyPrawda.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }               
        }

        private void checkBoxCzyPrawda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DodawanieOdpowiedzi_Load(object sender, EventArgs e)
        {

        }
    }
}
