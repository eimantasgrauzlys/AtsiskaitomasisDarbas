using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ParduotuvesPrograma
{
    public class CategoriesSumService
    {


        public void SumOfTheSweetsListPrice()
        {
            
            List<decimal> sumsList = new List<decimal>();

            string[] str = System.IO.File.ReadAllText(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\ParduotuvesProgramaFinal\ParduotuvesPrograma\CSV files\SweetsFile.csv")
                                         .Split(new string[] { Environment.NewLine },
                                                               StringSplitOptions.None);

            for (int i = 0; i < str.Length; i++)
            {
                string[] line = str[i].Split(',');

                Goods item = new Goods();
                

                item.price = decimal.Parse(line[1], CultureInfo.InvariantCulture);

                
                sumsList.Add(item.price);

            }
            //Console.WriteLine($"If you buy all items from  list you will spend: {sumsList.Sum()}€");
        }



        public void SumOfTheVegetablesListPrice()
        {
            {
                
                List<decimal> sumsList = new List<decimal>();

                string[] str = System.IO.File.ReadAllText(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\ParduotuvesProgramaFinal\ParduotuvesPrograma\CSV files\VegetablesFile.csv")
                                             .Split(new string[] { Environment.NewLine },
                                                                   StringSplitOptions.None);

                for (int i = 0; i < str.Length; i++)
                {
                    string[] line = str[i].Split(',');

                    Goods item = new Goods();
                    

                    item.price = decimal.Parse(line[1], CultureInfo.InvariantCulture);

                    
                    sumsList.Add(item.price);

                }
                //Console.WriteLine($"If you buy all items from the list you will spend: {sumsList.Sum()}€");
            }
        }



        public void SumOfTheMeatListPrice()
        {
            {
                List<Goods> meatList = new List<Goods>();
                List<decimal> sumsList = new List<decimal>();
                decimal totalPrice = sumsList.Sum();

                string[] str = System.IO.File.ReadAllText(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\ParduotuvesProgramaFinal\ParduotuvesPrograma\CSV files\MeatFile.csv")
                                             .Split(new string[] { Environment.NewLine },
                                                                   StringSplitOptions.None);

                for (int i = 0; i < str.Length; i++)
                {
                    string[] line = str[i].Split(',');

                    Goods item = new Goods();
                    

                    item.price = decimal.Parse(line[1], CultureInfo.InvariantCulture);

                    
                    sumsList.Add(item.price);

                }
               // Console.WriteLine($"If you buy all items from the list you will spend: {sumsList.Sum()}€");
            }

        }




        public void SumOfTheBeveragesListPrice()
        {
            {
                List<Goods> beveragesList = new List<Goods>();
                List<decimal> sumsList = new List<decimal>();
                decimal totalPrice = sumsList.Sum();

                string[] str = System.IO.File.ReadAllText(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\ParduotuvesProgramaFinal\ParduotuvesPrograma\CSV files\BeveragesFile.csv")
                                             .Split(new string[] { Environment.NewLine },
                                                                   StringSplitOptions.None);
                
               
                for (int i = 0; i < str.Length; i++)
                {
                    string[] line = str[i].Split(',');

                    Goods item = new Goods();
                    

                    item.price = decimal.Parse(line[1], CultureInfo.InvariantCulture);
                
                    
                    sumsList.Add(item.price);

                }
               // Console.WriteLine($"If you buy all items from the list you will spend: {totalPrice}€");
            }
        }
    }
}
