namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Define several variables in your program (byte, short, int, long, bool, char, float, double, decimal, string) 
            and write to console the result of addition, subtraction, multiplication of several of them.*/
            //я так зрозумів, що треба просто об'явити змінні та проробити з ними мат приклади...
            //хоча з типом string або char таке не прокатить)

            int a = 2;
            double b = 1.47;
            bool c = true;
            string d = "Five";
            //-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
            double res1 = -6 * Math.Pow(a, 3) + 5 * Math.Pow(a, 2) - 10 * a + 15;
            Console.WriteLine("-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 = " + res1 + $", where x = {a}");

            //abs(x) * sin(x)
            double res2 = Math.Abs(b) * Math.Sin(b);
            Console.WriteLine("abs(x) * sin(x) = " + res2 + $", where x = {b}");

            //2 * pi * x
            double res3 = 2 * Math.PI * b;
            Console.WriteLine("2 * pi * x = " + res3 + $", where x = {b}");

            //max(x, y)
            double maxof = Math.Max(a, b);
            Console.WriteLine("max(x, y) = " + maxof + $", where x = {a}, y = {b}");

            //доп завдання з датами
            DateTime date = DateTime.Today;
            int today = date.DayOfYear;
            int new_year = 365;
            Console.WriteLine("\nToday is " + date.ToString("d"));
            Console.WriteLine($"{new_year - today} days to New Year");
            Console.WriteLine($"{today} days passed from New Year");
            Console.ReadKey(); //якщо закривається саме
        }
    }
}