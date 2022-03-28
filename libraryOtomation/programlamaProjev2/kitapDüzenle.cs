using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace programlamaProjev2
{
    public partial class kitapDüzenle : Form
    {
        // Listeleme işlemleri için yazdığım sınıftan nesne türetiyorum burada
        kitapListeleSınıfı list = new kitapListeleSınıfı();
        kitapKodSınıfı ekle = new kitapKodSınıfı();
        public kitapDüzenle()
        {
            InitializeComponent();
        }

        private void kitapDüzenle_Load(object sender, EventArgs e)
        {
            string text = "select *from kitapListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            list.showMessage();  // abstract class'ımda override ettiğim metodun kullanıldığı yer
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow text2 = dataGridView1.CurrentRow; // işlemi kısaltmak için kullandım bunu
            textBox1.Text = text2.Cells["id"].Value.ToString();
            textBox2.Text = text2.Cells["kitapAdı"].Value.ToString();
            textBox3.Text = text2.Cells["yazarAdı"].Value.ToString();
            textBox4.Text = text2.Cells["baskıYılı"].Value.ToString();
            textBox5.Text = text2.Cells["sayfaSayısı"].Value.ToString();
            textBox6.Text = text2.Cells["kitapDili"].Value.ToString();
            textBox7.Text = text2.Cells["kitapTürü"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text3 = "update kitapListesi set id=@id,kitapAdı=@kitapAdı,yazarAdı=@yazarAdı,baskıYılı=@baskıYılı,sayfaSayısı=@sayfaSayısı,kitapDili=@kitapDili,kitapTürü=@kitapTürü where id=@id";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@id", textBox1.Text);
            command2.Parameters.AddWithValue("@kitapAdı", textBox2.Text);
            command2.Parameters.AddWithValue("@yazarAdı", textBox3.Text);
            command2.Parameters.AddWithValue("@baskıYılı", textBox4.Text);
            command2.Parameters.AddWithValue("@sayfaSayısı", textBox5.Text);
            command2.Parameters.AddWithValue("@kitapDili", textBox6.Text);
            command2.Parameters.AddWithValue("@kitapTürü", textBox7.Text);


            ekle.add(command2, text3);

            string text = "select *from kitapListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            MessageBox.Show("Kitap başarı ile güncellenmiştir!");
        }
    }
}
