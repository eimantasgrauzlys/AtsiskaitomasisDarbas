using ParduotuvesPrograma.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class VegetablesRepository

    {
        public List<Vegetables> VegetablesList { get; set; }

        public VegetablesRepository()
        {
            VegetablesList = new List<Vegetables>();
        }
        public List<Vegetables> VegetablesDataLoader()
        {
            var reader = new CSV_Reader();
            VegetablesList = reader.VegetablesCSVFileReader("VegetablesFile");
            return VegetablesList;
        }
        public void VegetablesToCSVAdder(Vegetables vegetables)
        {
            var handler = new CSV_Reader();
            handler.SweetsDataWriterToCSV("VegetablesFile", vegetables);
        }
    }
}
