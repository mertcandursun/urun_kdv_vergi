using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_kdv_vergi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urunfiyat,yuzde8,yuzde18;
            string urunismi;

            urunismi = adiBox.Text;
            urunfiyat = Double.Parse(fiyatBox.Text);
            yuzde8 = urunfiyat * 1.08;
            yuzde18 = urunfiyat * 1.18;

            listBox1.Items.Add($"Ürünün adı : {urunismi} %8 Vergili : {yuzde8.ToString("0000.00")} %18 Vergili : {yuzde18.ToString("0000.00")}");

        }
    }
}
