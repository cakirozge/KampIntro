using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items; // [] new gerekmektedir. 
        
        //constructor -- class new otomatik çalışır.
        public MyList()
        {
                items = new T[0]; // newlenme zorunluluğu vardır.
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //gecici array referans tutar elemanlar kaybolmaz.
            items = new T[items.Length+1]; //ELEMAN SAYISINI 1 ARTTIRIYOR.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item; // bosluga cıkan index yok etmek için kullanırız.




        }
    }
}
