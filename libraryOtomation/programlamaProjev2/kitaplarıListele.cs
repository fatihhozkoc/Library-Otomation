using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace programlamaProjev2
{
    public partial class kitaplarıListele : Form
    {

        // Listeleme işlemleri için yazdığım sınıftan nesne türetiyorum burada
        kitapListeleSınıfı list = new kitapListeleSınıfı();
        public kitaplarıListele()
        {
            InitializeComponent();
        }

        // Kitapları listele sınıfında bulunan dataGridWiev'a sql tablomu yazdırdığım kısım
        private void kitaplarıListele_Load(object sender, EventArgs e)
        {
            string text = "select *from kitapListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            list.showMessage();  // abstract class'ımda override ettiğim metodun kullanıldığı yer
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // inheritence kullandığım yer

            DataGridViewRow text2 = dataGridView1.CurrentRow; // DataGridView'daki tıkladığım sırayı almamı sağlıyor
            KitapÖzellik özellik = new KitapÖzellik();   // KitapÖzellik sınıfından nesne türettim
            kitapAdı kitapisim = new kitapAdı();
            yazarAdı yazarisim = new yazarAdı();
            baskıYılı baskıyılı = new baskıYılı();
            sayfaSayısı sayfasayısı = new sayfaSayısı();
            kitapDili kitapdili = new kitapDili();
            kitapTürü kitaptürü = new kitapTürü();

            özellik.id= text2.Cells["id"].Value.ToString();
            textBox1.Text = özellik.id;

            kitapisim.kitapİsim= text2.Cells["kitapAdı"].Value.ToString();
            textBox2.Text = kitapisim.kitapİsim;

            yazarisim.yazarİsim= text2.Cells["yazarAdı"].Value.ToString();
            textBox3.Text = yazarisim.yazarİsim;

            baskıyılı.baskıSenesi= text2.Cells["baskıYılı"].Value.ToString();
            textBox4.Text = baskıyılı.baskıSenesi;

            sayfasayısı.sayfasayısı= text2.Cells["sayfaSayısı"].Value.ToString();
            textBox5.Text = sayfasayısı.sayfasayısı;

            kitapdili.kitapdili= text2.Cells["kitapDili"].Value.ToString();
            textBox6.Text = kitapdili.kitapdili;

            kitaptürü.kitaptürü= text2.Cells["kitapTürü"].Value.ToString();
            textBox7.Text = kitaptürü.kitaptürü;

        }
    }
}
