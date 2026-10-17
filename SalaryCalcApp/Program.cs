
namespace SalaryCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int DAYS_PER_MONTH = 22;
            const int HOURS_PER_DAY = 8;
            const int MIN_PER_HOUR = 60;
            decimal salaryPerMinute = 0M;
            decimal salary = 0M;
            decimal salaryPerDay = 0M;
            decimal salaryPerHour = 0M;


            Console.WriteLine("Παρακαλώ εισάγετε τον μηνιαίο μισθό σας");
            if (!decimal.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Μη έγκυρη τιμή");
                return;

            }

            salaryPerDay = salary / DAYS_PER_MONTH;
            salaryPerHour = salaryPerDay / HOURS_PER_DAY;
            salaryPerMinute = salaryPerHour / MIN_PER_HOUR;

            Console.WriteLine($"Σε {salary:C2} μηνιαίου μισθού αντιστοιχούν:");
            Console.WriteLine($"Ωρομίσθιο: {salaryPerHour:C2}");
            Console.WriteLine($"Ημερομίσθιο: {salaryPerDay:C2}");
            Console.WriteLine($"Aμοιβή ανά λεπτό: {salaryPerMinute:C2}");


        }
    }
}
