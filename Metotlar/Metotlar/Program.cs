// See https://aka.ms/new-console-template for more information
using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi=55;    

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe --tip güvenli ne ile çalışmak istediğini bilmek ister -var- yazilabilir.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati); 
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("-----------------Metotlar-----------");

            //instance -örnek
            //encapsulation -- ayrı ayrı yazacağın şeyi bir düzenin içine sokmamızı saglar.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Console.WriteLine("-----------------Metotlar kullanımı önerilmeyen Ekle 2-----------");
            //sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            //sepetManager.Ekle2("elma", "Yeşil Elma", 18);
            //sepetManager.Ekle2("karpuz", "çekirdeksiz", 92);
            //sepetManager.Ekle2("portakal", "washington", 10);



        }
    }
}










//Dont repeat yourself - DRY - Clean Code - Best Practice