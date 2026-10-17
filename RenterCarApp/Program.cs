using System.Globalization;

namespace RenterCarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Εξασφαλίζει UTF-8 στην κονσόλα
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 2. Εξασφαλίζει ότι το :C2 θα βγάζει ΠΑΝΤΑ € ακόμα και σε αγγλικά Windows
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("el-GR");


            const decimal FIXED_COST = 25M;
            const decimal COST_PER_KM = 0.15M;
            const decimal VAT_RATE = 0.24M;

            int days = 0;
            decimal distance = 0M;
            decimal netCost = 0M;
            decimal totalCost = 0M;

            Console.WriteLine("Παρακαλώ εισάγετε τον αριθμό ημερών ενοικίασης του αυτοκινήτου");

            if (!int.TryParse(Console.ReadLine(), out days) || days < 0)
            {
                Console.WriteLine("Μη εγκυρος αριθμός");
                return;
            }

            Console.WriteLine("Παρακαλώ εισάγετε τα χιλιόμετρα που διανύσατε");

            if (!decimal.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός");
                return;
            }

            netCost = ((days * FIXED_COST) + (distance * COST_PER_KM));
            totalCost = netCost * (1 + VAT_RATE);


            Console.WriteLine($"To βασικό κόστος ενοικίασης για {days} ημέρες είναι: {days * FIXED_COST:C2}");
            Console.WriteLine($"Το κόστος χιλιομέτρων είναι : {distance * COST_PER_KM:C2} ");
            Console.WriteLine($"Το κόστος ενοικίασης προ φπα είναι: {netCost:C2}");
            Console.WriteLine($"Το συνολικό κόστος ενοικίασης είναι: {totalCost:C2}");

        }
    }
}
