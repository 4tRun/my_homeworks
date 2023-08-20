using RandomNameGeneratorLibrary;
using System.Security.Cryptography;

namespace lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose operation (-g) - genarate, (-p) - print all, (-c) - create new name, (-e) - edit, (-out) - exit:");

                string input = Console.ReadLine();

                var storage = new PhonesStorage();

                switch (input)
                {
                    case "-g":
                        RunRandomGeneration();
                        break;
                    case "-c":
                        storage.Save(new PhoneRecord());
                        break;
                    case "-p":
                        storage.PrintAll();
                        break;
                    case "-e":
                        storage.Edit(int.Parse(Console.ReadLine()));
                        break;
                    case "-out":
                        return;
                    default:
                        continue;
                }
            } while (true);
        }

        private static void RunRandomGeneration()
        {
            var placeGenerator = new PersonNameGenerator();
            var randomNumberGenerator = new Random();
            var storage = new PhonesStorage();

            for (var i =0; i < 10; i++)
            {
                var newRecord = new PhoneRecord(placeGenerator.GenerateRandomFirstName(),
                    placeGenerator.GenerateRandomLastName(),
                    $"{randomNumberGenerator.Next(38010, 38099)}" +
                        $"{randomNumberGenerator.Next(1111111, 9999999)}");

                storage.Save(newRecord);
                
            }
        }
    }
}