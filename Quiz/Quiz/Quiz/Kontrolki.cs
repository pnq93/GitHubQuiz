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
    class Kontrolki
    {
        private DodajPytanie forma;

        public Kontrolki(DodajPytanie forma)
        {
            this.forma = forma;
        }
        public void GenerateRegisterControls(int number)
        {
            int[] textboxes = new int[number];
            int i = 0, move = 0;

            //tworzę GroupBoxa, do którego wrzucę tworzone kontrolki (opis metody w następnym listingu)
           // GroupBox box = GenerateGroupBoxControl(text);
            Panel box = GenerateGroupBoxControl();

            foreach (int element in textboxes)
            {
                TextBox textbox = new TextBox(); //tworzę nowego TextBoxa
                CheckBox label = new CheckBox(); //tworzę nowy Label
                //lokalizacja TextBoxa
                textbox.Location = new System.Drawing.Point(200, 70 + move);
                textbox.Name = "textbox" + i.ToString();
                textbox.Size = new System.Drawing.Size(360, 20 + move); //wymiary TextBoxa
                //Rozmiar czcionki w TextBoxie - funkcja nie zostanie przedstawiona
                //w tym wpisie
               // textbox.Font = SetFontForElement(40, textbox.Font);
                textbox.TabIndex = i;
                textbox.Visible = true;
                //automatyczna zmiana rozmiarów TextBoxa przy zmianie rozmiaru okna
                textbox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                textbox.BorderStyle = BorderStyle.FixedSingle; //styl ramki
                //lokalizacja Labela
                label.Location = new System.Drawing.Point(20, 80 + move);
                label.Name = "label" + i.ToString();
                //nazwa Labela wzięta z wcześniej utworzonej tablicy stringów
                label.Text = "Czy prawdziwa";
               // label.Font = SetFontForElement(28, label.Font);
                label.Size = new System.Drawing.Size(160, 28);
                label.Visible = true;

                box.Controls.Add(textbox); //dodaję do GroupBoxa utworzone TextBoxy
                box.Controls.Add(label); //dodaję do GroupBoxa utworzone Labele

                i++;
                move += 50;
            }
            //dodaję GroupBoxa z kontrolkami do panelu w kontenerze Form1
            forma.panel1.Controls.Add(box);
        }

       
    private Panel GenerateGroupBoxControl()
    {
      Panel box = new Panel();
 
      box.Name = "GroupBoxRegister";
      //box.Text = text;
      box.Location = new System.Drawing.Point(1, 9);
      box.AutoScroll = true;
      box.Size = new System.Drawing.Size(forma.panel1.Width - 20, forma.panel1.Height - 20);
      box.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
 
      return box;
    }


    }
}
