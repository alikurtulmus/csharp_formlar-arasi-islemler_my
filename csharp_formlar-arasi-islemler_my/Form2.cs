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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj; //nesneyi public yapmazsak form1'den bu nesneye ulaşamayız

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj; //form2'deki label1'i mesaj nesnesine eşitledik

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }
    }
}
