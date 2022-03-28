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
    public partial class emanetEkle2 : Form
    {
        // Ekleme fonksiyonumun içinde bulunduğu sınıftan nesne türetiyorum burada
        kitapListeleSınıfı emanetEkle = new kitapListeleSınıfı();

        // Ekleme fonksiyonumun içinde bulunduğu sınıftan nesne türetiyorum burada
        kitapKodSınıfı emanetVer = new kitapKodSınıfı();

        public emanetEkle2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "insert into emanetListesi2(id, üyeisim, kitapisim, emanetsüresi) values(@id,@üyeisim,@kitapisim,@emanetsüresi)";
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@id", textBox1.Text);
            command.Parameters.AddWithValue("@üyeisim", textBox2.Text);
            command.Parameters.AddWithValue("@kitapisim", textBox3.Text);
            command.Parameters.AddWithValue("@emanetsüresi", textBox4.Text);

            // Ekleme sınıfımda yazdığım fonksiyonu çağırıyorum
            emanetVer.add(command, text);
            MessageBox.Show("Emanet başarı ile eklenmiştir!");
        }

        private void emanetEkle2_Load(object sender, EventArgs e)
        {
            string text = "select *from kitapListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = emanetEkle.make_a_list(kkk2, text);
            emanetEkle.showMessage();  // abstract class'ımda override ettiğim metodun kullanıldığı yer
        }
    }
}
