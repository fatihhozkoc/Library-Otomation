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
    public abstract class abstractClass
    {

        // Parametresi olmayan constructor
        public abstractClass() { }

        //Kitap değişkenleri

        protected string kitapid;
        protected string kitapAdı;
        protected string kitapYazar;
        protected string baskıYılı;
        protected string sayfaSayısı;
        protected string kitapTürü;

        // Bu metotları abstract olarak tanımladım böylece her sınıfta yeniden yazmak zorunda kalmayacak ve 
        // gerektiğinde override ederek kullanacağım
        public abstract void showMessage();
        public abstract DataTable make_a_list(SqlDataAdapter kkk, string query);

    }
}
