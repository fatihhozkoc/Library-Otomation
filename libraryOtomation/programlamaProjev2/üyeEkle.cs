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
    public partial class üyeEkle : Form
    {

        // Ekleme fonksiyonumun içinde bulunduğu sınıftan nesne türetiyorum burada
        kitapKodSınıfı addMember = new kitapKodSınıfı();

        public üyeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "insert into üyeListesi(id, isim, soyisim, telefon,gmail) values(@id,@isim,@soyisim,@telefon,@gmail)";
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@id", textBox1.Text);
            command.Parameters.AddWithValue("@isim", textBox2.Text);
            command.Parameters.AddWithValue("@soyisim", textBox3.Text);
            command.Parameters.AddWithValue("@telefon", textBox4.Text);
            command.Parameters.AddWithValue("@gmail", textBox5.Text);

            // Ekleme sınıfımda yazdığım fonksiyonu çağırıyorum
            addMember.add(command, text);
            MessageBox.Show("Üye başarı ile eklenmiştir!");
        }
    }
}
