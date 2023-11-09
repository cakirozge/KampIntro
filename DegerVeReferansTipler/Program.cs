using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------
            // int, decimal, float, double, bool = değer tiplerdir.
            // array, class, interface = referans tip

            // nasıl çalışır ???

            // bellekte stack ve heap diye tanımlanan alanlarımız vardır.


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1); // -- 30
            // değer tipler nasıl çalışır.
            // stack = değer tip sayi1 = 10 burada gerçekleşir.
            // nasıl okuma yapılır? sayi1'in değeri = 10'dur, sayi2'nin değeri= 30'dur.
            // sayi1in değeri = sayi2nin değeri -- sadece değeri aktarırız. yani sayi2 ile tüm irtibat kopar 30 u atarız.
            //sayi2 = 65 yaparsak bunun sayi1 ile hiçbir alakası yoktur tamamen bağlantı kopar

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]); // -- 999
            //referans tipler nasıl çalışır?
            // bellekte stack ve heap diye tanımlanan alanlarımız vardır.
            // int[] sayilar1 diye stack de bir değişken tanımlamış oluruz.
            // new dediğimiz anda sayilar1 için heap de [] için yeni bir alan oluştururz ve değerleri oraya yazarız.
            // stack ve heapde bu ikisi için bağlantı nasıl oluşur -- * heap bir adres değeri tutar 
            // sayilar1 = sayilar2 ' nin referans nosuna eşittir diye okuma yapmalıyız.
            // sayilar1 sayilar2nin referans nosunu tutmaya basladığı için 999 sayısı oluşur.
            // ilk tutulan referans no 101 .net çöp toplayıcısı gelir ve bellekten atar.






        }




    }
}
