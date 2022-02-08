using ParduotuvesPrograma.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class SweetsRepository

    {
        public List<Sweets> SweetsList { get; set; }

        public SweetsRepository()
        {
            SweetsList = new List <Sweets>();
        }
        public List<Sweets> SweetsDataLoader()
        {
            var reader = new CSV_Reader();
            SweetsList = reader.SweetsCSVFileReader("SweetsFile");
            return SweetsList;
        }
        public void SweetToCSVAdder(Sweets sweet)
        {
            var handler = new CSV_Reader();
            handler.SweetsDataWriterToCSV("SweetsFile", sweet);
        }
    }
    
}
