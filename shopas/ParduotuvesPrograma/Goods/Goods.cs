using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class Goods
    {
        public string title;
        public decimal price;
        public int barcode;
        public int weight;
        

        public Goods()
        {
        }

        public Goods(string title, decimal price, int barcode, int weight)
        {
            this.title = title;
            this.price = price;
            this.barcode = barcode;
            this.weight = weight;
        }

        
    }
}
