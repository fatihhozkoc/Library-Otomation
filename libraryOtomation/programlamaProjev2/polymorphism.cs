using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programlamaProjev2
{
    class polymorphism
    {
        public string id, isim, soyisim, telefon, gmail, kitapİsim, üyeİsim, emanetSüresi;


        // Parametresi olmayan yapıcı metod
        public polymorphism()
        {

        }

        // Aşağıdakilerde parametreli yapıcı metod
        public polymorphism(string id, string isim, string soyisim, string telefon, string gmail)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.telefon = telefon;
            this.gmail = gmail;
        }

        public polymorphism(string id, string kitapİsim, string üyeİsim,string emanetSüresi)
        {
            this.id = id;
            this.kitapİsim = kitapİsim;
            this.üyeİsim = üyeİsim;
            this.emanetSüresi = emanetSüresi;
        }

    }
    class üyeMesajGöster: polymorphism
    {

        // Yapıcı metodlar
        public üyeMesajGöster(string id, string isim, string soyisim, string telefon, string gmail)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.telefon = telefon;
            this.gmail = gmail;
        }
        public üyeMesajGöster(string id, string kitapİsim, string üyeİsim, string emanetSüresi)
        {
            this.id = id;
            this.kitapİsim = kitapİsim;
            this.üyeİsim = üyeİsim;
            this.emanetSüresi = emanetSüresi;
        }

        public void göster(üyeMesajGöster mesajGöster)
        {
            MessageBox.Show("Üye Bilgileri:\n " + "ID:" + id +"\n"+
                "İSİM:" + isim + "\n" +
                "SOYİSİM: " + soyisim + "\n" +
                "TELEFON: " + telefon + "\n" +
                "G MAİL: " + gmail);
        }

        // Metodun aşırı yüklenmesi
        public void göster(string id, string kitapİsim, string üyeİsim, string emanetSüresi)
        {
            MessageBox.Show("Emanet Bilgileri:\n " + "ID:" + id + "\n" +
                "KİTAP İSMİ:" + kitapİsim + "\n" +
                "ÜYE İSMİ: " + üyeİsim + "\n" +
                "EMANET SÜRESİ: " + emanetSüresi);
        }


         // Yıkıcı metod 
        ~üyeMesajGöster()
        {
            Console.WriteLine("Yıkıcı metod çalıştı.");
        }
    }
       


}
