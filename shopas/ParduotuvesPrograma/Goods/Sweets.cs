using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class Sweets : Goods
    {
        public int sugarQuantity;

        public Sweets()
        {
        }

        public Sweets(int sugarQuantity)
        {
            this.sugarQuantity = sugarQuantity;
        }

        public Sweets(string title, decimal price, int barcode, int weight) : base(title, price, barcode, weight)
        {
            

        }

    }
}
