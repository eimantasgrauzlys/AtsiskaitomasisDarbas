using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma.Services
{
    public class CSV_Reader
    {
        #region SweetsCSVFileManagment
        public void SweetsDataWriterToCSV(string fileName, Sweets sweets)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{fileName}.csv";
            string stringData = Environment.NewLine + $"{sweets.title}, " +$"{sweets.barcode}, " +$"{sweets.price}, " +$"{sweets.weight}";
            File.AppendAllText(path, stringData);

            
        }

        public List<Sweets> SweetsCSVFileReader(string CSVCoordinates)
        {

            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{CSVCoordinates}.csv";
            var SweetsCSVReader = new StreamReader(path);




            var repositoryOfSweets = new List<Sweets>();

            while (!SweetsCSVReader.EndOfStream)
            {
                var line = SweetsCSVReader.ReadLine(); //nuskaito visą eilutę
                string[] value = line.Split(","); //išsplitina visą eilutę į segmentus perskirtus kableliais.

                repositoryOfSweets.Add(ItemParserInSweetsCSVFile(value)); 
            }
            return repositoryOfSweets;
        }

        public Sweets ItemParserInSweetsCSVFile(string[] valueCache) 
        {
            var sweetsParcel = new Sweets();
            sweetsParcel.title = valueCache[0].ToString();
            sweetsParcel.price = decimal.Parse(valueCache[1], CultureInfo.InvariantCulture);
            sweetsParcel.barcode = int.Parse(valueCache[2], CultureInfo.InvariantCulture);  
            sweetsParcel.weight = int.Parse(valueCache[3].ToString());
            sweetsParcel.sugarQuantity = int.Parse(valueCache[4].ToString());

            return sweetsParcel;
        }
        #endregion SweetsCSVFileManagment

        #region MeatsCSVFileManagment

        public void MeatsDataWriterToCSV(string fileName, Meats meats)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{fileName}.csv";
            string stringData = Environment.NewLine + $"{meats.title}, " + $"{meats.barcode}, " + $"{meats.price}, " + $"{meats.weight}";
            File.AppendAllText(path, stringData);


        }
        public List<Meats> MeatCSVFileReader(string CSVCoordinates)
        {


            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{CSVCoordinates}.csv";

            var MeatsCSVReader = new StreamReader(path);


            var repositoryOfMeats = new List<Meats>();

            while (!MeatsCSVReader.EndOfStream)
            {
                var line = MeatsCSVReader.ReadLine(); //nuskaito visą eilutę
                string[] value = line.Split(", "); //išsplitina visą eilutę į segmentus perskirtus kableliais.

                repositoryOfMeats.Add(ItemParserInMeatCSVFile(value));
            }
            return repositoryOfMeats;
        }

        public Meats ItemParserInMeatCSVFile(string[] valueCache)
        {
            var meatsParcel = new Meats();
            meatsParcel.title = valueCache[0].ToString();
            meatsParcel.barcode = int.Parse(valueCache[1].ToString());
            meatsParcel.price = decimal.Parse(valueCache[2].ToString());
            meatsParcel.weight = int.Parse(valueCache[3].ToString());
            meatsParcel.proteinQuantity = int.Parse(valueCache[4].ToString());

            return meatsParcel;
        }
        #endregion MeatsCSVFileManagment

        #region VegetablesCSVFileManagment

        public void VegetablesDataWriterToCSV(string fileName, Vegetables vegetables)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{fileName}.csv";
            string stringData = Environment.NewLine + $"{vegetables.title}, " + $"{vegetables.barcode}, " + $"{vegetables.price}, " + $"{vegetables.weight}";
            File.AppendAllText(path, stringData);


        }

        public List<Vegetables> VegetablesCSVFileReader(string CSVCoordinates)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{CSVCoordinates}.csv";

            var VegetablesCSVReader = new StreamReader(path);


            var repositoryOfVegetables = new List<Vegetables>();

            while (!VegetablesCSVReader.EndOfStream)
            {
                var line = VegetablesCSVReader.ReadLine(); //nuskaito visą eilutę
                string[] value = line.Split(", "); //išsplitina visą eilutę į segmentus perskirtus kableliais.

                repositoryOfVegetables.Add(ItemParserInVegetablesCSVFile(value));
            }
            return repositoryOfVegetables;
        }

        public Vegetables ItemParserInVegetablesCSVFile(string[] valueCache)
        {
            var vegetablesParcel = new Vegetables();
            vegetablesParcel.title = valueCache[0].ToString();
            vegetablesParcel.barcode = int.Parse(valueCache[1].ToString());
            vegetablesParcel.price = decimal.Parse(valueCache[2].ToString());
            vegetablesParcel.weight = int.Parse(valueCache[3].ToString());
            vegetablesParcel.fiberQuantity = int.Parse(valueCache[4].ToString());

            return vegetablesParcel;
        }
        #endregion VegetablesCSVFileManagment

        #region BeveragesCSVFileManagment

        public void BeveragesDataWriterToCSV(string fileName, Beverages beverages)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{fileName}.csv";
            string stringData = Environment.NewLine + $"{beverages.title}, " + $"{beverages.barcode}, " + $"{beverages.price}, " + $"{beverages.weight}";
            File.AppendAllText(path, stringData);


        }

        public List<Beverages> BeveragesCSVFileReader(string CSVCoordinates)
        {
            string path = $@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\shopas\ParduotuvesPrograma\CSV files\{CSVCoordinates}.csv";

            var BeveragesCSVReader = new StreamReader(path);


            var repositoryOfBeverages = new List<Beverages>();

            while (!BeveragesCSVReader.EndOfStream)
            {
                var line = BeveragesCSVReader.ReadLine(); //nuskaito visą eilutę
                string[] value = line.Split(", "); //išsplitina visą eilutę į segmentus perskirtus kableliais.

                repositoryOfBeverages.Add(ItemParserInBeveragesCSVFile(value));
            }
            return repositoryOfBeverages;
        }

        public Beverages ItemParserInBeveragesCSVFile(string[] valueCache)
        {
            var beveragesParcel = new Beverages();
            beveragesParcel.title = valueCache[0].ToString();
            beveragesParcel.barcode = int.Parse(valueCache[1].ToString());
            beveragesParcel.price = decimal.Parse(valueCache[2].ToString());
            beveragesParcel.weight = int.Parse(valueCache[3].ToString());
            beveragesParcel.liters = int.Parse(valueCache[4].ToString());

            return beveragesParcel;
        }
        #endregion BeveragesCSVFileManagment

    }
}

