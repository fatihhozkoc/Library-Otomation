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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Anasayfadaki kitap işlemleri butonuna tıkladığım zaman yeni formun açılmasını sağlıyor
            kitapislemleri kitapislem = new kitapislemleri();
            kitapislem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Anasayfadaki üye işlemleri butonuna tıkladığım zaman yeni formun açılmasını sağlıyor
            üyeislemleri üyeislemi = new üyeislemleri();
            üyeislemi.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anasayfadaki emanet işlemleri butonuna tıkladığım zaman yeni formun açılmasını sağlıyor
            emanetislemleri emanetislemi = new emanetislemleri();
            emanetislemi.Show();
        }
    }
}
