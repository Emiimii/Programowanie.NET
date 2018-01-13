using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        private bool equationComplete = false;
        private bool zeroInTex = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (equationComplete) wynik.Text = "";

            if (zeroInTex)
            {
                wynik.Font = new Font("Arial", 24);
                zeroInTex = false;
            }

            if ((wynik.Text == "0")||(operation_pressed))
                wynik.Clear(); //komenda usuwa 0 z textBox'a przed cyfrą

            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text == ",")
            {
                if (!wynik.Text.Contains(","))
                wynik.Text = wynik.Text + b.Text; //niepowtarzalność kropki
            }
            else
                wynik.Text = wynik.Text + b.Text;
            
            label2.Focus();
            equationComplete = false;
            //bez work around:
            //rowne.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
            label2.Focus();
            //bez work around:
            //rowne.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
            value = 0;
            rownanie.Text = "";
            label2.Focus();
            //bez work around:
            //rowne.Focus();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                rowne.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                rownanie.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(wynik.Text);
                operation_pressed = true;
                rownanie.Text = value + " " + operation;
            }
            label2.Focus();
            //bez work around:
            //rowne.Focus();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            rownanie.Text = "";
            switch(operation)
            {
                case "+":
                wynik.Text = (value + Double.Parse(wynik.Text)).ToString();
                break;
                 case "-":
                wynik.Text = (value - Double.Parse(wynik.Text)).ToString();
                break;
                 case "*":
                wynik.Text = (value * Double.Parse(wynik.Text)).ToString();
                break;
                 case "/":
                    if (wynik.Text != "0")
                    {
                        wynik.Text = (value / Double.Parse(wynik.Text)).ToString();
                    }
                    break;
                default:
                    break;
            }

            if (wynik.Text == "0")
            {
                wynik.Text = "Nie mozna dzielic przez 0";
                wynik.Font = new Font("Arial", 10);
                zeroInTex = true;
            }
            else
            {
                value = Double.Parse(wynik.Text);
                zeroInTex = false;
            }
               
            operation = "";
            equationComplete = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //czytanie liczb z klawiatury
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                   none.PerformClick();
                    break;
                case "1":
                    jeden.PerformClick();
                    break;
                case "2":
                    dwa.PerformClick();
                    break;
                case "3":
                    trzy.PerformClick();
                    break;
                case "4":
                    cztery.PerformClick();
                    break;
                case "5":
                    piec.PerformClick();
                    break;
                case "6":
                    szesc.PerformClick();
                    break;
                case "7":
                    siedem.PerformClick();
                    break;
                case "8":
                    osiem.PerformClick();
                    break;
                case "9":
                    dziewiec.PerformClick();
                    break;
                case "+":
                    dodac.PerformClick();
                    break;
                case "-":
                    odjac.PerformClick();
                    break;
                case "*":
                    mnozenie.PerformClick();
                    break;
                case "/":
                    dzielic.PerformClick();
                    break;
                case "=":
                    rowne.PerformClick();
                    break;
                case ",":
                    dec.PerformClick();
                    break;
                case "\r":
                    rowne.PerformClick();
                    break;
                default:
                    break;         
            }
        }
    }
}
