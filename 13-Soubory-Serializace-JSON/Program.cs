using System.Collections.Generic;
using System.Text.Json;

namespace _13_Soubory_Serializace_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = [
                new Person() {Name = "Karel", Age = 13},
                new Person() {Name = "Lojza", Age = 29},
            ];

            string filename = "people.json";

            JsonSerializerOptions options = new()
            {
                //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };

            string serialized = JsonSerializer.Serialize(people, options);
            File.WriteAllText(filename, serialized);

            string rawData = File.ReadAllText(filename);
            
            var peopleFromDisk = JsonSerializer.Deserialize<List<Person>>(rawData);
        }
    }
}
