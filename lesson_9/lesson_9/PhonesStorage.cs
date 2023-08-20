namespace lesson_9
{
    class PhonesStorage
    {
        private readonly string DbFilePath = @"D:\beetroot\my_homeworks\lesson_9\phoneRecords\phonedb.cvs";
        private readonly char ColumnSeparator = ',';

        public PhonesStorage()
        {
            EnsureDbFile();
        }

        public void Edit(int orderNumber)
        {
            var records = GetAllRecord();
            var index = orderNumber - 1;

            if(index < 0 || index > records.Length - 1)
            {
                var redBuffer = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong order number.");
                Console.ForegroundColor = redBuffer;
            }

            var recordObj = DeserializeRecord(records[index]);

            var yellowBuffer = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are going to edit: ");
            Print(recordObj);
            Console.ForegroundColor = yellowBuffer;

            var updateRecord = new PhoneRecord();

            records[index] = SerializeRecord(updateRecord);

            File.WriteAllLines(DbFilePath, records.Select(x => x.Trim()));
        }
        public void PrintAll()
        {
            var records = GetAllRecord();

            for (int i = 0; i < records.Length; i++)
            {
                string? record = records[i];
                var desirializedRecord = DeserializeRecord(record);
                Print(desirializedRecord, i + 1);
            }
        }
        public void Print(PhoneRecord phoneRecord)
        {
            Console.WriteLine($"+{phoneRecord.PhoneNumber} - {phoneRecord.FirstName} {phoneRecord.LastName}");
        }

        public void Print(PhoneRecord phoneRecord, int orderNumber)
        {
            Console.WriteLine($"[{orderNumber}]: +{phoneRecord.PhoneNumber} - {phoneRecord.FirstName} {phoneRecord.LastName}");
        }

        
        public void Save(PhoneRecord phoneRecord)
        {
            EnsureDbFile();

            File.AppendAllLines(DbFilePath, new[] { SerializeRecord(phoneRecord) });
        }

        private string[] GetAllRecord()
        {
            return File.ReadAllText(DbFilePath).Split('\n', StringSplitOptions.RemoveEmptyEntries);
        }
        private string SerializeRecord(PhoneRecord phoneRecord)
        {
            return $"{phoneRecord.FirstName}{ColumnSeparator}" +
                $"{phoneRecord.LastName}{ColumnSeparator}" +
                $"{phoneRecord.PhoneNumber}{ColumnSeparator}";
        }

        private PhoneRecord DeserializeRecord(string record)
        {
            string[] cellValues = record.Split(ColumnSeparator);

            var parsedRecord = new PhoneRecord(cellValues[0], cellValues[1], cellValues[2]);

            return parsedRecord;
        }

        private void EnsureDbFile()
        {
            if (!File.Exists(DbFilePath))
            {
                using (File.Create(DbFilePath))
                {

                }
            }
        }
    }
}