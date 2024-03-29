﻿namespace lesson_9
{
    class PhoneRecord 
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public PhoneRecord()
        {
            FirstName = ReadStringFromConsole("Please enter first name: ");
            LastName = ReadStringFromConsole("Please enter last name: ");
            PhoneNumber = ReadPhoneNumberFromConsole("Please enter phone number: ");
        }

        public PhoneRecord(string fName, string lName, string phoneNumber)
        {
            FirstName = fName;
            LastName = lName;
            PhoneNumber = phoneNumber;
        }

        private string ReadStringFromConsole(string messegeText)
        {

            do
            {
                Console.WriteLine(messegeText);

                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                else
                    continue;
            } while (true);
        }

        private string ReadPhoneNumberFromConsole(string messegeText)
        {

            do
            {
                Console.WriteLine(messegeText);

                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) 
                    && input.Trim().Length == 12
                    && input.ToList().All(symbol => char.IsNumber(symbol)))
                    return input.Trim();
                else
                    continue;
            } while (true);
        }
    }
}