namespace lesson_8
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            string test = "Hello, World40938!";
            Analize(test);
        }

        private static bool Compare(string str1, string str2)
        {
            if (str1 == str2) return true;
            return false;
        } 
        private static void Analize(string str)
        {
            str.ToLower();
            string alphabet = "abcdefghijklmopqrstuvwxyz";
            string digits = "1234567890"; 
            char[] charStr = str.ToCharArray();
            int strLength = charStr.Length;
            int lettersInStr = 0;
            int digitsInStr = 0;
            int otherInStr = 0;

            for (int i = 0; i < strLength; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (charStr[i] == alphabet[j]) lettersInStr++;
                }
                for (int j = 0; j < digits.Length; j++)
                {
                    if (charStr[i] == digits[j]) digitsInStr++;
                }
            }

            otherInStr = strLength - (lettersInStr + digitsInStr);
            Console.WriteLine($"Програма нарахувала: {lettersInStr} букв, {digitsInStr} цифр та {otherInStr} спецальних символів.");
        }
       /* private static string Sort(string str)
        {

        }*/
    }
}