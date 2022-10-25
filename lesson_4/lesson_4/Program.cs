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
            //Я не знаю як вивести "Неправильне значення" оскільки при вводі букв видає помилку
            //... точніше знаю... через try{} але ми ще це не вивчали) чи то у с++...
            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
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
                        } else Console.Write(i + " + ");
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
            Console.ReadKey();//якщо закривається
        }
    }
}