using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class Beverages : Goods
    {
        public float liters;

        public Beverages(float liters)
        {
            this.liters = liters;
        }

        public Beverages(string title, decimal price, int barcode, int weight) : base(title, price, barcode, weight)
        {
        }

        public Beverages()
        {
        }

      

    }
}
