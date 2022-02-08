using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class Vegetables : Goods
    {
        public int fiberQuantity;

        public Vegetables()
        {
        }

        public Vegetables(int fiberQuantity)
        {
            this.fiberQuantity = fiberQuantity;
        }

        public Vegetables(string title, decimal price, int barcode, int weight) : base(title, price, barcode, weight)
        {
        }

        
        

    }
}
