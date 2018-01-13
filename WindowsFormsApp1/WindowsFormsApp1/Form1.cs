using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }
       
        private void bDodawanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
            textBox1.Text = "";
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
            textBox1.Text = "";
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
            textBox1.Text = "";
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
            textBox1.Text = "";
        }
        private void bRowne_Click(object sender, EventArgs e)
        {
            switch(RodzajDzialania)
            {
                case ('+'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzialania = ' ';
        }
        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }
        private void b1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b6_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b7_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b8_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b9_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void b0_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void bOdejmowanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void bDodawanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void bMnozenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void bDzielenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar + " ";
        }
        private void Dzialanie(int liczba)
        
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                textBox1.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                textBox1.Text = LiczbaDruga;
            }
        }

    }
}
