using CsvHelper;
using System.Globalization;

namespace _13_Soubory_Serializace_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "data.csv";

            using StreamReader sr = new StreamReader(filename);
            using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>();
                foreach(Person p in records)
                {
                    Console.WriteLine($"{p.Name} : {p.Age}");
                }
            }
        }
    }
}
