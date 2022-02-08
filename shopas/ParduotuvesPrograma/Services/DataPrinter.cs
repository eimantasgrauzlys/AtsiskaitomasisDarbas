
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParduotuvesPrograma.Services
{
   public class DataPrinter
    {
        public static void SweetsInfoPrinter()
        {
            var sweetsRepository = new SweetsRepository();

            foreach (var item in sweetsRepository.SweetsDataLoader())
            {
                Console.WriteLine($"Goods title: {item.title}");
                Console.WriteLine($"Barcode: {item.barcode}");
                Console.WriteLine($"Price: {item.price} Eur");
                Console.WriteLine($"Weight: {item.weight} g");
                Console.WriteLine($"have: {item.sugarQuantity} sugar");

                Console.WriteLine();
            }
        }

        public static void MeatsInfoPrinter()
        {
            var meatsRepository = new MeatsRepository();

            foreach (var item in meatsRepository.MeatsDataLoader())
            {
                Console.WriteLine($"Goods title: {item.title}");
                Console.WriteLine($"Barcode: {item.barcode}");
                Console.WriteLine($"Price: {item.price} Eur");
                Console.WriteLine($"Weight: {item.weight} g");
                Console.WriteLine($"have: {item.proteinQuantity} protein");

                Console.WriteLine();
            }
        }

        public static void VegetablesInfoPrinter()
        {
            var vegetablesRepository = new VegetablesRepository();

            foreach (var item in vegetablesRepository.VegetablesDataLoader())
            {
                Console.WriteLine($"Goods title: {item.title}");
                Console.WriteLine($"Barcode: {item.barcode}");
                Console.WriteLine($"Price: {item.price} Eur");
                Console.WriteLine($"Weight: {item.weight} g");
                Console.WriteLine($"have: {item.fiberQuantity} fibers");

                Console.WriteLine();
            }
        }

        public static void BeveragesInfoPrinter()
        {
            var beveragesRepository = new BeveragesRepository();

            foreach (var item in beveragesRepository.BeveragesDataLoader())
            {
                Console.WriteLine($"Goods title: {item.title}");
                Console.WriteLine($"Barcode: {item.barcode}");
                Console.WriteLine($"Price: {item.price} Eur");
                Console.WriteLine($"Weight: {item.weight} g");
                Console.WriteLine($"have: {item.liters} ");

                Console.WriteLine();
            }
        }
    }
}
