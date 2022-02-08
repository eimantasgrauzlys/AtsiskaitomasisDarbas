using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma.Services
{
    public class MenuOfProgram
    {
       

        public void MenuShower()
        {
            FilesReaderService service = new FilesReaderService();
            FilesReaderService goodsBuyingService = new FilesReaderService();
            SweetsRepository sweetsRepository = new SweetsRepository();
            CSV_Reader showList = new CSV_Reader();
            DataPrinter printData = new DataPrinter();

            Console.Write("Hello! Input your wallet balance! ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
         

            Console.WriteLine();


            if (balance > 0)
            {
                
                

                Console.WriteLine("Choose ant type categorie first letter that you want to see!");
                Console.WriteLine("(Sweets - 'S', Meats - 'M', Vegetables - 'V', Beverages - 'B')");
                Console.WriteLine("");
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 's')
                {

                    DataPrinter.SweetsInfoPrinter();



                }

                else if (input == 'm')
                {

                    DataPrinter.MeatsInfoPrinter();

                }

                else if (input == 'v')
                {

                    DataPrinter.VegetablesInfoPrinter();

                }

                if (input == 'b')
                {

                    DataPrinter.BeveragesInfoPrinter();

                }


            }
            else
            {
                FilesReaderService shower = new FilesReaderService();
                GoodsBuyingService buy = new GoodsBuyingService();
                
                Console.WriteLine("The balance is perfect for your purchase");
                Console.WriteLine("Type categorie first letter that you want to see!");
                Console.WriteLine("(Sweets - 'S', Meats - 'M', Vegetables - 'V', Beverages - 'B')");
                Console.WriteLine("");
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 's')
                {

                    DataPrinter.SweetsInfoPrinter();



                }

                else if (input == 'm')
                {

                    DataPrinter.MeatsInfoPrinter();

                }

                else if (input == 'v')
                {

                    DataPrinter.VegetablesInfoPrinter();

                }

                if (input == 'b')
                {

                    DataPrinter.BeveragesInfoPrinter();

                }

            }


        }
    }
}
