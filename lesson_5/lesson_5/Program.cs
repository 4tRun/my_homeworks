namespace lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Define and call with different parameters next methods:

            Method that will return max value among all the parameters
            … min value …
            Method TrySumIfOdd that accepts 2 parameters and returns true
            if sum of numbers between inputs is odd, otherwise false, sum return as out parameter
            Overload first two methods with 3 and 4 parameters

            Extra:

            Define and call with different parameters next methods:

            Method Repeat that will accept string X and number N and return X repeated N
            times(e.g.Repeat(‘str’, 3) returns ‘strstrstr’ = ‘str’ three times)
            */
            Console.WriteLine("Input variables... \nFor method TrySumIfOdd() input value tipe!");
            Console.Write("Input X = ");
            string readX = Console.ReadLine();
            Console.Write("Input Y = ");
            string readY = Console.ReadLine();
            if (int.TryParse(readX, out int valX) && int.TryParse(readY, out int valY))
            {

                Console.WriteLine("Max is " + Max(valX, valY) + "\nMin is " + Min(valX, valY));
                if(TrySumIfOdd(valX, valY, out int sum))
                {
                    Console.WriteLine("Sum of variables are odd!");
                } else Console.WriteLine("Sum = " + sum);
            }
            else if (double.TryParse(readX, out double dubX) && double.TryParse(readY, out double dubY))
            {
                Console.WriteLine("Max is " + Max(dubX, dubY) + "\nMin is " + Min(dubX, dubY));
            }
            else if (decimal.TryParse(readX, out decimal decX) && decimal.TryParse(readY, out decimal decY))
            {
                Console.WriteLine("Max is " + Max(decX, decY) + "\nMin is " + Min(decX, decY));
            }
            else Console.WriteLine("Invalid input!");

            Console.Write("Extra! Input some string: ");
            string input = Console.ReadLine();
            Console.Write("How many times repeat? ");
            string readNum = Console.ReadLine();
            if (int.TryParse(readNum, out int num))
            {
                Console.WriteLine(Repeat(input, num));
            }
            else Console.WriteLine("Invalid input!");

        }

        //max() method
        static int Max (int x, int y)
        {
            if (x > y) return x;
            else if (x < y) return y;
            else return x;
        }     
        //min() method
        static int Min (int x, int y)
        {
            if (x < y) return x;
            else if (x > y) return y;
            else return x;
        }

        //overloads methods
        #region OVERLOADS
        static double Max (double x, double y)
        {
            if (x > y) return x;
            else if (x < y) return y;
            else return x;
        }
        static double Min (double x, double y)
        {
            if (x < y) return x;
            else if (x > y) return y;
            else return x;
        }
        static decimal Max (decimal x, decimal y)
        {
            if (x > y) return x;
            else if (x < y) return y;
            else return x;
        }
        static decimal Min (decimal x, decimal y)
        {
            if (x < y) return x;
            else if (x > y) return y;
            else return x;
        }
        #endregion

        //TrySumIfOdd() method
        static bool TrySumIfOdd (int x, int y, out int sum)
        {
            int tryMax = x;
            sum = 0;
            if (x != y)
            {
                if (Max(x, y) == x)
                {
                    tryMax = y;
                    y = x;
                    x = tryMax;
                }
                for (int i = x; i <= y; i++)
                {
                    sum += i;
                }
            } else sum = x + x;

            if (sum % 2 == 1)
            {
                sum = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Repeat() method
        static string Repeat (string str, int num)
        {
            if (num == 1) return str;
            else if (num > 1) return str + Repeat(str, num - 1);
            else return null;
        }
    }
}