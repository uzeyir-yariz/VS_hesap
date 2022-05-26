using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        char _isim;
        bool _temizleme;
        int _s1;
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "0" || label1.Text == "00") { label1.Text = ""; }
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_temizleme) { label1.Text = ""; _temizleme = false; }
            if (label1.Text == "00") { label1.Text = "0"; }
            label1.Text += "0";
        }

        private void buttontopla_Click(object sender, EventArgs e)
        {
            _isim = '+';
            _temizleme = true;
            _s1 = Convert.ToInt32(label1.Text);            
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            
            label1.Text = "0";
            
            
        }

        private void buttonesit_Click(object sender, EventArgs e)
        {
            int s2 = Convert.ToInt32(label1.Text);
            int sonuc = 0;


            switch (_isim)
            {
                case '+':
                    sonuc = _s1 + s2;
                    break;

                case '-':
                    sonuc = _s1 - s2;
                    break;

                case '*':
                    sonuc = _s1 * s2;
                    break;

                case '/':
                    sonuc = _s1 / s2;
                    break;

                
                
                
                default:
                    break;
            }

            label1.Text = sonuc.ToString();

            listBox1.Items.Add(_s1 + " " + _isim + " " + s2 + " = " + sonuc);

        }

        private void buttoncikart_Click(object sender, EventArgs e)
        {
            _isim = '-';
            _temizleme = true;
            _s1 = Convert.ToInt32(label1.Text);       
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            _isim = '*';
            _temizleme = true;
            _s1 = Convert.ToInt32(label1.Text);       
        }

        private void buttonbol_Click(object sender, EventArgs e)
        {
            _isim = '/';
            _temizleme = true;
            _s1 = Convert.ToInt32(label1.Text);       
        }
    }
}
