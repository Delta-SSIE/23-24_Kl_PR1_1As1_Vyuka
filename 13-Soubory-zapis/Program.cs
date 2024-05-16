using System.IO;

namespace _13_Soubory_zapis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "ABCDE\nFGHIJK";
            string[] output2 = {
                "ABCDEFG",
                "IJKLMNOP"
            };

            try
            {
                //File.WriteAllText(@"C:\temp\text.txt", output);
                if (!Directory.Exists("data"))
                    Directory.CreateDirectory("data");

                //File.WriteAllText(@"data\text.txt", output);
                //File.WriteAllLines(@"data\text2.txt", output2);

                using (StreamWriter sr = new StreamWriter(@"data\text3.txt"))
                {
                    foreach (string s in output2)
                        sr.WriteLine(s);
                }
            }
            catch
            {
                Console.WriteLine("Disk operation failed ");
            }
        }
    }
}
