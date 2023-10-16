namespace _02a_Random_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvořím generátor náhodných čísel
            Random random = new Random();
            //Random random = new Random(1568794521); //vložím "semínko" - seed, pak se budou čísla při příštím spuštění opakovat

            Console.WriteLine(random.NextDouble()); //vytvoří "náhodné" číslo v intervalu <0, 1)
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            int nahodne = random.Next(1,7); //1 ... první, které chci
                                            //7 ... první, které už nechci

            Console.WriteLine(nahodne);
            
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
        }
    }
}
