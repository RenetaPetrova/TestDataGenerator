using Bogus;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TestDataGenerator
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int recordCount = GetRecordCount();
            var testDataList = GenerateTestUsers(recordCount);
            ExportToCsv(testDataList, "test_users.csv");
            Console.WriteLine($"The test data was successfully generated and saved with {recordCount} records in: test_users.csv");
        }

        static List<User> GenerateTestUsers(int count)
        {
            var faker = new Faker<User>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("+359 8## ### ###"))
                .RuleFor(u => u.Password, f => f.Internet.Password())
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .RuleFor(u => u.BirthDate, f => f.Date.Past(30, DateTime.Now.AddYears(-18)).ToShortDateString());
            return faker.Generate(count);
        }

        static void ExportToCsv(List<User> data, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }

        static int GetRecordCount()
        {
            Console.Write("Enter the number of records to generate: ");
            int maxLimit = 100000;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int count) && count > 0 && count <= maxLimit)
                {
                    return count;
                }
                Console.Write($"Invalid input. Please enter a positive number (1-{maxLimit}): ");
            }
        }
    }
}