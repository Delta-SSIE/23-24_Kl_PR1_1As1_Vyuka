namespace _09_EnumEx_01_Demo_Enum
{
    enum Obdobi : byte { Jaro = 1, Leto, Podzim, Zima };
    enum Barva { Srdce, Kary, Piky, Krize, Trefy = Krize };
    enum Stav { Voda, Lod, Trosky, Minul };

    internal class Program
    {
        static void Main(string[] args)
        {
            Barva moje = Barva.Krize;
            Barva tvoje = Barva.Trefy;
            if (moje == tvoje) Console.WriteLine("Máme stejnou barvu");
            else Console.WriteLine("Každý máme jinou barvu");



            //Obdobi prvni = Obdobi.Jaro;
            //Console.WriteLine(prvni);
            //prvni++;
            //Console.WriteLine(prvni);
            //prvni += 2;
            //Console.WriteLine(prvni);
            //prvni++;
            //Console.WriteLine(prvni);

            //Obdobi chladne = (Obdobi)3;
            //Console.WriteLine(chladne);
        }
    }
}
