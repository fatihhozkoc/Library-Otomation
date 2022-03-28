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
    public partial class kitapEkle : Form
    {
        // Ekleme fonksiyonumun içinde bulunduğu sınıftan nesne türetiyorum burada
        kitapKodSınıfı addBook = new kitapKodSınıfı();



        enum dil
        {
            Türkçe,
            İngilizce, 
            Almanca
        }

        public kitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "insert into kitapListesi(id, kitapAdı, yazarAdı, baskıYılı,sayfaSayısı,kitapDili, kitapTürü) values(@id,@kitapAdı,@yazarAdı,@baskıYılı,@sayfaSayısı,@kitapDili,@kitapTürü)";
            //Console.WriteLine(text.Length);
            SqlCommand command = new SqlCommand();
            dil dilv1 = dil.Türkçe;

            command.Parameters.AddWithValue("@id", textBox1.Text);
            command.Parameters.AddWithValue("@kitapAdı", textBox2.Text);
            command.Parameters.AddWithValue("@yazarAdı", textBox3.Text);
            command.Parameters.AddWithValue("@baskıYılı", textBox4.Text);
            command.Parameters.AddWithValue("@sayfaSayısı", textBox5.Text);
            command.Parameters.AddWithValue("@kitapDili", textBox6.Text);
            command.Parameters.AddWithValue("@kitapTürü", dilv1);


            // Ekleme sınıfımda yazdığım fonksiyonu çağırıyorum
            addBook.add(command, text);


            MessageBox.Show("Kitap başarı ile eklenmiştir!");

            


        }
    }
}
