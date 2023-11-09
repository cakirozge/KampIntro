using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    // Manager ifadeleri -operasyon tuttugunu- belirtir.
    class SepetManager
    {
        //naming convention metotlarda Büyük harfle yazilir.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi + " " + urun.Aciklama + " " + urun.Fiyati + " "+ urun.StokAdedi );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdet)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
