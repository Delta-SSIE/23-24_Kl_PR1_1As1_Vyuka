namespace _10_EnumEx_020_karty {
    enum Karta:byte { Sedma = 7, Osma, Devitka, Desitka, Spodek, Svrsek, Filek = Svrsek, Kral, Eso }

    //Vytvořte datový typ Enum pro hodnoty hracích karet(sedma, osma, … , eso)
    //Kromě slova „svršek“ se také někdy používá slovo „filek“ – změňte váš enum tak, aby podporoval obě hodnoty současně.
    //Nejnižší kartou je sedmička, bylo by rozumné, aby jí odpovídala hodnota 7.
    //Výšek karet je málo, na jejich uložení stačí jeden byte – změňte podkladový datový typ vašeho Enum na byte

    internal class Program {
        static void Main(string[] args) {

            //Uložte si jednu kartu do proměnné karta a vypište ji
            Karta karta = Karta.Sedma;
            Console.WriteLine(karta);

            //Vyzkoušejte inkrementaci(karta++) a znovu ji vypište
            karta++;
            Console.WriteLine(karta);

            //Vyzkoušejte přesažení nejvyšší karty
            karta = Karta.Eso;
            karta++;
            Console.WriteLine(karta);

            //test metody
            Karta jeden = Karta.Svrsek;
            Karta druhy = Karta.Filek;
            KdoJeVyssi(jeden, druhy);
        }

        //Napište metodu KdoJeVyssi(kartaA, kartaB), která dostane předány dvě výšky karet a vypíše buď
        //kartaA je vyšší než kartaB(svršek je vyšší než sedmička)
        //kartaA je nižší než kartaB
        //Oba dva mají stejně vysokou kartu
        
        public static void KdoJeVyssi(Karta kartaA, Karta kartaB) 
        {
            if (kartaA > kartaB)
                Console.WriteLine("Karta A je větší, než karta B.");
            else if (kartaA < kartaB)
                Console.WriteLine("Karta B je větší, než karta A.");
            else
                Console.WriteLine("Oba dva mají stejně vysokou kartu.");
        }


    }
}