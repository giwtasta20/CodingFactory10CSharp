using System.Globalization;

namespace TravelingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0D;
            double fuelCons = 0D;
            double liters = 0D;
            double fuelPrice = 2.2;
            double totalCost;

            Console.WriteLine("Παρακαλώ εισάγετε την κατανάλωση καυσίμου του οχήματος σας (λίτρα/100km)");

            if  (!double.TryParse(Console.ReadLine(), out fuelCons) || fuelCons <= 0.0)
            {

                Console.WriteLine("Μη έγκυρος αριθμός");
                return;
            }

            Console.WriteLine("Παρακαλώ εισάγετε την απόσταση (km) που πρόκειται να διανύσετε");
            if (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0.0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός");
                return;

            }
          
            liters = Math.Round((distance * fuelCons) / 100, 2);
            totalCost = Math.Round((liters * fuelPrice), 2);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Το κόστος του ταξιδιού είναι: {totalCost:C2} ");


        }

    }
}
