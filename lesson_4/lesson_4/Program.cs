namespace lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that will start with declaration of two constants (X and Y)
             and will count the sum of all numbers between these constants. 
             If they are equal then sum should be one of them*/
            //whith recursion would be better)
            Console.Write("X = ");
            string readX = Console.ReadLine();
            Console.Write("Y = ");
            string readY = Console.ReadLine();
            int x;
            int y;
            if (int.TryParse(readX, out x) && int.TryParse(readY, out y))
            {
                int sum = 0;
                Console.Write("Sum = ");

                if (x != y)
                {
                    if (x > y)
                    {
                        for (int i = y; i <= x; i++)
                        {
                            sum += i;
                            if (i == x)
                            {
                                Console.WriteLine(i + " = " + sum);
                            }
                            else Console.Write(i + " + ");
                        }
                    }
                    else
                    {
                        for (int i = x; i <= y; i++)
                        {
                            sum += i;
                            if (i == y)
                            {
                                Console.WriteLine(i + " = " + sum);
                            }
                            else Console.Write(i + " + ");
                        }
                    }
                }
                else
                {
                    sum = x;
                    Console.WriteLine("x and y equal! = " + sum);
                }
            }
            else Console.WriteLine("Invalid input!");
            Console.ReadKey();//якщо закривається
        }
    }
}