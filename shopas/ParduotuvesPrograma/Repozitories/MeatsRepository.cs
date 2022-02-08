using ParduotuvesPrograma.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma
{
    public class MeatsRepository

    {
        public List<Meats> MeatsList { get; set; }

        public MeatsRepository()
        {
            MeatsList = new List<Meats>();
        }
        public List<Meats> MeatsDataLoader()
        {
            var reader = new CSV_Reader();
            MeatsList = reader.MeatCSVFileReader("MeatsFile");
            return MeatsList;
        }
        public void MeatToCSVAdder(Meats meats)
        {
            var handler = new CSV_Reader();
            handler.SweetsDataWriterToCSV("MeatsFile", meats);
        }
    }

}
