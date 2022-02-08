using ParduotuvesPrograma.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class BeveragesRepository

    {
        public List<Beverages> BeveragesList { get; set; }

        public BeveragesRepository()
        {
            BeveragesList = new List<Beverages>();
        }
        public List<Beverages> BeveragesDataLoader()
        {
            var reader = new CSV_Reader();
            BeveragesList = reader.BeveragesCSVFileReader("BeveragesFile");
            return BeveragesList;
        }
        public void BeveragesToCSVAdder(Beverages beverages)
        {
            var handler = new CSV_Reader();
            handler.SweetsDataWriterToCSV("BeveragesFile", beverages);
        }
    }
}
