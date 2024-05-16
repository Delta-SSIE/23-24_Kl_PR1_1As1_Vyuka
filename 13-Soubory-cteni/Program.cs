namespace _13_Soubory_cteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!Directory.Exists("data"))
                    Directory.CreateDirectory("data");

                //vratí celý souboru jako jediný řetězec 
                //string input = File.ReadAllText(@"data\text2.txt");
                //Console.WriteLine(input);

                //string[] input2 = File.ReadAllLines(@"data\text2.txt");
                //foreach(string s in input2)
                //    Console.WriteLine(":" + s);


                using (StreamReader sr = new StreamReader(@"data\text2.txt"))
                {
                    string line;
                    //line = sr.ReadLine();
                    //while (line != null)
                    //{
                    //    Console.WriteLine(line);
                    //    line = sr.ReadLine();
                    //}

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                    //for (line = sr.ReadLine(); line != null; line = sr.ReadLine())
                    //{
                    //    Console.WriteLine(line);
                    //}
                }

            }
            catch
            {
                Console.WriteLine("Disk operation failed ");
            }
        }
    }
}
