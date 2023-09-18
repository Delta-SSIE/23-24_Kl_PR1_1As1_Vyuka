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

        }
    }
}
