using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet hazır kodlar -prop-
    // Product bu claslarda *sadece* özellik olur.
    class Product
    {
        public int Id { get; set; } //ana anahtar tc etc.
        public int CategoryId { get; set; } // referans anahtarları 2. sıraya yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // ekleme silme gibi operasyonlara CRUD denir.
    }
}
