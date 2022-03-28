using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programlamaProjev2
{
    public partial class emanetislemleri : Form
    {
        public emanetislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Emanet ekle butonuna tıkladığın zaman yeni sayfanın açılamasını sağlıyor.
            emanetEkle2 barrowBook = new emanetEkle2();
            barrowBook.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Emanetleri listele butonuna tıkladığın zaman yeni sayfanın açılamasını sağlıyor.
            emanetleriListele emanetListele = new emanetleriListele();
            emanetListele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetleriDüzenle emanetDüzenle = new emanetleriDüzenle();
            emanetDüzenle.ShowDialog();
        }
    }
}
