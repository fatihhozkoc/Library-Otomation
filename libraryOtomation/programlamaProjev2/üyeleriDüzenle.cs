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
    public partial class üyeleriDüzenle : Form
    {
        kitapListeleSınıfı list = new kitapListeleSınıfı();
        kitapKodSınıfı ekle = new kitapKodSınıfı();
        public üyeleriDüzenle()
        {
            InitializeComponent();
        }

        private void üyeleriDüzenle_Load(object sender, EventArgs e)
        {
            string text = "select *from üyeListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            list.showMessage();  // abstract class'ımda override ettiğim metodun kullanıldığı yer
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow text2 = dataGridView1.CurrentRow; // işlemi kısaltmak için kullandım bunu
            textBox1.Text = text2.Cells["id"].Value.ToString();
            textBox2.Text = text2.Cells["isim"].Value.ToString();
            textBox3.Text = text2.Cells["soyisim"].Value.ToString();
            textBox4.Text = text2.Cells["telefon"].Value.ToString();
            textBox5.Text = text2.Cells["gmail"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text3 = "update üyeListesi set id=@id,isim=@isim,soyisim=@soyisim,telefon=@telefon,gmail=@gmail where id=@id";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@id", textBox1.Text);
            command2.Parameters.AddWithValue("@isim", textBox2.Text);
            command2.Parameters.AddWithValue("@soyisim", textBox3.Text);
            command2.Parameters.AddWithValue("@telefon", textBox4.Text);
            command2.Parameters.AddWithValue("@gmail", textBox4.Text);



            ekle.add(command2, text3);

            string text = "select *from üyeListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            MessageBox.Show("Üye başarı ile güncellenmiştir!");
        }
    }
}
