using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_formlar_arasi_islemler_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2(); //formlar da birer sınıf olduğu için Form2 sınıfına ait bir nesne oluşturduk.
            fr.Show(); //ilgili nesneye "Show" metodu uyguladık.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2(); //bir önceki nesne türetme işlemini buton içinde yaptığımız için tekrar nesne üretmemiz gerekti.
            //nesneyi global alanda türetseydik yeniden nesne üretmemize gerek kalmayacaktı
            fr.mesaj = textBox1.Text;
            fr.Show();
            this.Hide(); //form1'i gizledik
        }

        //FORMLAR ARASI VERİ TAŞIMA

    }
}
