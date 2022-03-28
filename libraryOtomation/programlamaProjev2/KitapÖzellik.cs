using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programlamaProjev2
{
    class KitapÖzellik
    {
        public string id;
    }

    class kitapAdı : KitapÖzellik
    {
        public string kitapİsim;
    }

    class yazarAdı :KitapÖzellik
    {
        public string yazarİsim;
    }

    class baskıYılı : KitapÖzellik
    {
        public string baskıSenesi;
    }

    class sayfaSayısı: KitapÖzellik
    {
        public string sayfasayısı;
    }

    class kitapDili:KitapÖzellik
    {
        public string kitapdili;
    }
    class kitapTürü:KitapÖzellik
    {
        public string kitaptürü;
    }
}
