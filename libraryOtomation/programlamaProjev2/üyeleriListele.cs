using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace programlamaProjev2
{
    public partial class üyeleriListele : Form
    {
        // Listeleme işlemleri için yazdığım sınıftan nesne türetiyorum burada
        kitapListeleSınıfı list = new kitapListeleSınıfı();

        public üyeleriListele()
        {
            InitializeComponent();
        }
        
        //dataGridView'a sql tablosunu yazdıran kod 
        private void üyeleriListele_Load(object sender, EventArgs e)
        {
            string text = "select *from üyeListesi";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = list.make_a_list(kkk2, text);
            list.showMessage();  // abstract class'ımda override ettiğim metodun kullanıldığı yer
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow text2 = dataGridView1.CurrentRow;

            üyeMesajGöster mesajGöster = new üyeMesajGöster(text2.Cells["id"].Value.ToString(), 
                                                           text2.Cells["isim"].Value.ToString(), 
                                                           text2.Cells["soyisim"].Value.ToString(),
                                                           text2.Cells["telefon"].Value.ToString(),
                                                           text2.Cells["gmail"].Value.ToString());
            mesajGöster.göster(mesajGöster);

        }
    }
}
