using System.Globalization;

namespace lesson_8
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Intro();
            Console.ReadKey();
        }

        public static void Intro()
        {
            Console.WriteLine("1. Compare - перевіряє рівність двох рядків;\n" +
                "2. Analize - рахує кількість букв, цифр та спеціальних символів у рядку\n" +
                "3. Sort - сортує рядок за алфавітом\n" +
                "4. Dublicate - повертає массив зі знаками, що повторюються\n");
            int userInput = 0;
            while (true) 
            { 
            Console.Write("Введіть вибраний метод: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput > 0 && userInput < 5) break;
            Console.WriteLine("Ви ввели невірне значення!! Спробуйте знову!");
            }
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Введіть 2 рядки для перевірки.");
                    Console.Write("Рядок 1: ");
                    string str1 = Console.ReadLine();
                    Console.Write("Рядок 2: ");
                    string str2 = Console.ReadLine();
                    if (Compare(str1, str2)) Console.WriteLine("Рядки однакові!");
                    else Console.WriteLine("Рядки різні!");
                    break;
                case 2:
                    Console.Write("Ваш рядок: ");
                    int[] units = Analize(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Ваш рядок: ");
                    string sortedString = Sort(Console.ReadLine());
                    Console.Write($"Відсортований рядок: {sortedString}");
                    break;
                case 4:
                    Console.Write("Ваш рядок: ");
                    char[] repited = Dublicate(Console.ReadLine());
                    break;

            }
        }
        private static bool Compare(string str1, string str2)
        {
            if (str1 == str2) return true;
            return false;
        } 
        private static int[] Analize(string str)
        {
            int lettersInStr = 0;
            int digitsInStr = 0;
            int otherInStr = 0;

            foreach (char ch in str)
            {
                if (char.IsLetter(ch)) lettersInStr++;
                if (char.IsDigit(ch)) digitsInStr++;
            }

            otherInStr = str.Length - (lettersInStr + digitsInStr);
            int[] analize = { lettersInStr, digitsInStr, otherInStr };
            Console.WriteLine($"Програма нарахувала: {lettersInStr} букв, {digitsInStr} цифр та {otherInStr} спецальних символів.");
            return analize;
        }
        private static string Sort(string str)
        {
            return string.Concat(str.OrderBy(c => c));
        }
        private static char[] Dublicate(string str)
        {
            string charStr = "";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count = 1;

                for ( int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j]) count++;
                }
                if (count > 1 && !charStr.Contains(str[i])) charStr += str[i];
            }
            char[] dublicate = charStr.ToCharArray();
            Console.Write("Символи, що повторюються: { ");
            foreach (char ch in dublicate)
            {
                Console.Write(ch + ", ");
            }
            Console.WriteLine("}.");
            return dublicate;
        }
    }
}