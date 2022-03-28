using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace programlamaProjev2
{
    class kitapListeleSınıfı : abstractClass
    {

        // Database bağlantısı kurdum
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLBV3R4;Initial Catalog=projeDatabase;Integrated Security=True");
        DataTable table;


        public kitapListeleSınıfı() { }  // Parametresi olmayan yapıcı metod

        // Parametre alan yapıcı metod
        public kitapListeleSınıfı(string kitapid, 
                                  string kitapAdı, 
                                  string kitapYazar, 
                                  string baskıYılı, 
                                  string sayfaSayısı, 
                                  string kitapTürü)
        {
            this.kitapid = kitapid;
            this.kitapAdı = kitapAdı;
            this.kitapYazar = kitapYazar;
            this.baskıYılı = baskıYılı;
            this.sayfaSayısı = sayfaSayısı;
            this.kitapTürü = kitapTürü;

        }

        // Encapsulation ve get-set'i kullandığım kısım

        public string Kitapid { get; set; }
        public string KitapAdı { get; set; }
        public string KitapYazar { get; set; }
        public string BaskıYılı { get; set; }
        public string SayfaSayısı { get; set; }
        public string KitapTürü { get; set; }


        // abstract sınıfta bulunan metodun override edilmesi
        public override void showMessage()
        {
            MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.");
        }

        // abstract sınıfta bulunan metodun override edilmesi
        public override DataTable make_a_list(SqlDataAdapter kkk, string query)
        {
            table = new DataTable();
            kkk = new SqlDataAdapter(query, connection);
            kkk.Fill(table);
            connection.Close();
            return table;
            // Her seferinde güncellemesi için return tablo diyorum
        }

    }
}
