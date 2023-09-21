namespace _01_Uvod_04_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celeCislo = 5; //int znamená celé číslo
            Console.WriteLine("číslo má hodnotu: " + celeCislo);

            celeCislo = celeCislo - 2;
            Console.WriteLine("číslo má hodnotu: " + celeCislo);

            celeCislo = celeCislo - 20;
            Console.WriteLine("číslo má hodnotu: " + celeCislo);

            int velkeCislo = int.MaxValue;
            Console.WriteLine("číslo má hodnotu: " + velkeCislo);
            velkeCislo = velkeCislo + 1; //přetečení
            Console.WriteLine("číslo má hodnotu: " + velkeCislo);

            int soucin = 5 * 4;
            Console.WriteLine("Součin je "+ soucin);

            int podil = 5 / 4;
            int zbytek = 5 % 4;
            Console.WriteLine("Podíl je " + podil + ", zbytek je " + zbytek);

            double podil2 = 5.0 / 4;
            //double podil2 = 5d / 4; //totéž - "vnutím" mu, že 4 je double
            Console.WriteLine("Podíl v typu double je " + podil2);


        }
    }
}
