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

            /*int a = 2;
            double b = 1.47;
            bool c = true;
            string d = "Five";*/

            Console.Write("Input X = ");
            string readX = Console.ReadLine();
            Console.Write("Input Y = ");
            string readY = Console.ReadLine();
            double x;
            double y;
            if (double.TryParse(readX, out x) && double.TryParse(readY, out y))
            {

                //-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
                double res1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
                Console.WriteLine("-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 = " + res1 + $", where x = {x}");

                //abs(x) * sin(x)
                double res2 = Math.Abs(x) * Math.Sin(x);
                Console.WriteLine("abs(x) * sin(x) = " + res2 + $", where x = {x}");

                //2 * pi * x
                double res3 = 2 * Math.PI * x;
                Console.WriteLine("2 * pi * x = " + res3 + $", where x = {x}");

                //max(x, y)
                double maxof = Math.Max(x, y);
                Console.WriteLine("max(x, y) = " + maxof + $", where x = {x}, y = {y}");

                //доп завдання з датами
                DateTime date = DateTime.Today;
                int today = date.DayOfYear;
                int new_year = 365;
                Console.WriteLine("\nToday is " + date.ToString("d"));
                Console.WriteLine($"{new_year - today} days to New Year");
                Console.WriteLine($"{today} days passed from New Year");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadKey(); //якщо закривається саме
        }
    }
}