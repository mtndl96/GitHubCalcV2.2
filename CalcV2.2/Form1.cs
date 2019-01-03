using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcV2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 + sayi2;
            label3.Text = Convert.ToString(sayi1);
            label4.Text = "+";
            label5.Text = Convert.ToString(sayi2);
            label6.Text = "=";
            label7.Text = Convert.ToString(sonuc);
        }

        private void cıkarma_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sonuc = sayi1 - sayi2;
            label3.Text = Convert.ToString(sayi1);
            label4.Text = "-";
            label5.Text = Convert.ToString(sayi2);
            label6.Text = "=";
            label7.Text = Convert.ToString(sonuc);
        }
    }
}
