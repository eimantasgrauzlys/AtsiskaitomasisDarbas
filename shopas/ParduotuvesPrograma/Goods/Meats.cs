using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class Meats : Goods
    {
       public int proteinQuantity;

        public Meats(int proteinQuantity)
        {
            this.proteinQuantity = proteinQuantity;
        }

        public Meats(string title, decimal price, int barcode, int weight) : base(title, price, barcode, weight)
        {
        }

        public Meats()
        {
        }

        

    }
}
