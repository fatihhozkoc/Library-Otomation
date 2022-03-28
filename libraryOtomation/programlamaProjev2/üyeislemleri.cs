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
    public partial class üyeislemleri : Form
    {
        public üyeislemleri()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Üye işlemlerinde üye ekle butonuna tıkladığım zaman yeni formun açılmasını sağlıyor.
            üyeEkle addMember = new üyeEkle();
            addMember.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //üye işlemleri formunda üyeleri listele butonuna tıkladığım zaman üyeleri listele formunun açılmasını sağlıyor.
            üyeleriListele listMembers = new üyeleriListele();
            listMembers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            üyeleriDüzenle düzenle = new üyeleriDüzenle();
            düzenle.ShowDialog();
        }
    }
}
