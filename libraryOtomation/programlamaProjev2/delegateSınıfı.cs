using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programlamaProjev2
{
    class delegateSınıfı
    {
        enum tür
        {
            Cinayet,
            Polisiye,
            Roman,
            Biyografi,
            Tarih
        }
        //delegate void mesajKutusu();

        static void mesajGöster(string id, 
                                string kitapAdı,
                                string yazarAdı, 
                                string baskıYılı,
                                string sayfaSayısı, 
                                string kitapDili, 
                                tür kitapTürü)
        {
            MessageBox.Show("Eklenen Kitap Özellikleri"+
                            "ID: "+id+"\n"+
                            "Kitap İsmi:"+kitapAdı+"\n"+
                            "Yazar İsmi:"+yazarAdı+"\n"+
                            "Baskı Yılı:"+baskıYılı+"\n"+
                            "Sayfa Sayısı:"+sayfaSayısı+"\n"+
                            "Kitap Dili: "+kitapDili+"\n"+
                            "Kitap Türü: "+kitapTürü);
        }
    }
}
