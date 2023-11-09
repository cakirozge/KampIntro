using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Ürünle ilgili operasyonları barındırır. ekleme silme etc.
    //ProductService olarak da adlandırılabilir.
    class ProductManager
    {
        //encapsulation
      
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi!");
        }


        // --------------------------   void nedir ? --------------------
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2; //üzerinde yeniden calısmak istedigimiz icin return kullanılır.
        //}

        //public void Topla2(int sayi1, int sayi2) //return yazılmaz -- emir kipi-- cıkan değeri yeniden kullanamayız.
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
















    }
}
