using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //Laden vom Programm
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
        //Von
        private void btn1_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 2;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 8;
        }
        //bis ist beim click vom button
        private void btn9_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + 9;
        }


        //Minus
        private void btnMinus_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            if(label3.Text != "")
            {
                label1.Text = label3.Text;
                label3.Text = "";
            }
        }
        //Plus
        private void btnPlus_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            if (label3.Text != "")
            {
                label1.Text = label3.Text;
                label3.Text = "";
            }
        }
        //Mal
        private void btnmal_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            if (label3.Text != "")
            {
                label1.Text = label3.Text;
                label3.Text = "";
            }
        }
        //Durch 
        private void btnDurch_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            if (label3.Text != "")
            {
                label1.Text = label3.Text;
                label3.Text = "";
            }
        }

        //Alles löschen
        private void btnCE_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

        }
        //Letztes Löschen
        private void btnC_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }


        //ausrechnen
        private void btnGleich_Click(object sender, EventArgs e)
        {
            double zahl, zahl2, zahl3;
            if (label3.Text != "" || label1.Text !="")
            {
                if (label2.Text == "-")
                {
                    zahl = double.Parse(label3.Text);
                    zahl2 = double.Parse(label1.Text);
                    zahl3 = zahl2 - zahl;
                    label4.Text = "Erkebniss: " + zahl3.ToString();
                }
                if (label2.Text == "+")
                {
                    zahl = double.Parse(label3.Text);
                    zahl2 = double.Parse(label1.Text);
                    zahl3 = zahl2 + zahl;
                    label4.Text = "Erkebniss: " + zahl3.ToString();
                }
                if (label2.Text == "*")
                {
                    zahl = double.Parse(label3.Text);
                    zahl2 = double.Parse(label1.Text);
                    zahl3 = zahl2 * zahl;
                    label4.Text = "Erkebniss: " + zahl3.ToString();
                }
                if (label2.Text == "/")
                {
                    zahl = double.Parse(label3.Text);
                    zahl2 = double.Parse(label1.Text);
                    zahl3 = zahl2 / zahl;
                    label4.Text = "Erkebniss: " + zahl3.ToString();
                }
            }
        }
    }
}
