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
    public partial class NewGamecs : Form
    {
        //int licznik;
        public NewGamecs()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewGamecs_Load(object sender, EventArgs e)
        {

        }

        private void dalej_Click(object sender, EventArgs e)
        {

            if (odp1.Checked || odp2.Checked || odp3.Checked || odp4.Checked)
            {
                var Form = new NewGamecs();
                this.Close();
                Form.Show();
            }
            else
            {
                  MessageBox.Show("nie zaznaczyłeś żadnej odp");
            }
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void koniec_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
