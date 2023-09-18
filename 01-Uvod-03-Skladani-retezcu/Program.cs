namespace _01_Uvod_03_Skladani_retezcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Karolín";
            Console.WriteLine("Ať žije " + jmeno + "!");

            string pozdrav = "Ať žije " + jmeno + "!";
            Console.WriteLine(pozdrav);

            string retezec = "A";
            retezec = retezec + "B";
            //retezec += "B"; //zkratka za totéž co předchozí řádek
            Console.WriteLine(retezec);

            //retezec = retezec - "B"; //minus se pro retezce nepouziva
        }
    }
}
