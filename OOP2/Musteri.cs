using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //classlar operasyon ve özellik tutar operasyon tutulan alanda özellik, özellik tutulan alanda operasyon tutmayız.
    class Musteri //ebeveyn
    {
        //bir nesnede bir değeri kullanmak zorunda gibi durmuyorsa alan orada bir hata yapıyoruz demektir.

        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
