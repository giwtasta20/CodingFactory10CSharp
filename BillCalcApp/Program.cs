namespace BillCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double consumptionKwh = 0D;
            const decimal RATE_PER_KWH = 0.18M;
            const decimal FIXED_FEE = 5M;
            const decimal RES_FEE_PER_KWH = 0.02M;
            const decimal VAT_RATE = 0.24M;
            decimal netValue = 0M;
            decimal totalValue = 0M;

            Console.WriteLine("Παρακαλώ εισάγετε την κατανάλωση σε kWh");
            if (!double.TryParse(Console.ReadLine(), out consumptionKwh))

            {
                Console.WriteLine("Μη έγκυρος αριθμός");
                return;

            }

        }
    }
}
