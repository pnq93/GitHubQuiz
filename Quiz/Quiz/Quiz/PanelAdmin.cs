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
    public partial class PanelAdmin : Form
    {

        public PanelAdmin()
        {
            InitializeComponent();

        }

        private void dodaj_pyt_Click(object sender, EventArgs e)
        {
           
        }

        private void usun_uzyt_Click(object sender, EventArgs e)
        {
           
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            EditUzyt eu = new EditUzyt(this);
            panel1.Controls.Add(eu);
            
        
        }

        private void dodajAdminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DodAdmin da = new DodAdmin();
            panel1.Controls.Add(da);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {

        }

        private void edycjaPytaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdutujPytanie fe = new EdutujPytanie();
            fe.Show();
        }
    }
}
    

