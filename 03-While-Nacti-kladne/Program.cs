namespace _03_While_Nacti_kladne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej přirozené číslo: ");
            string vstup = Console.ReadLine();
            int cislo = int.Parse(vstup);

            while (cislo <= 0) //cyklus s neznámým počtem opakování
            {
                Console.Write("Řekl jsem PŘIROZENÉ číslo! Zkus to znova: ");
                vstup = Console.ReadLine();
                cislo = int.Parse(vstup);
            }

            string parita;
            if (cislo % 2 == 0)
            {
                parita = "sudé";
            }
            else
            {
                parita = "liché";
            }

            Console.WriteLine($"Číslo je {parita}.");

        }
    }
}
