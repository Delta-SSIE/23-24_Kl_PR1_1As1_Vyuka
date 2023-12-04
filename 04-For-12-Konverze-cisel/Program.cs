namespace _04_For_12_Konverze_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bin2dec

            //string bin = "10110110";
            //int dec = 0;

            //int baze = 2;            

            //for (
            //    int i = 0, hodnotaBitu = 1; //inicializace - 2 proměnné oddělené čárkou
            //    i < bin.Length; //kontrola běhu
            //    i++, hodnotaBitu *= baze //iterace - na konci cyklu zvyšuji dvě proměnné
            //)
            //{
            //    char znak = bin[bin.Length - 1 - i]; //í-tý znak od konce
            //    if (znak == '1')
            //        dec += hodnotaBitu;
            //}

            //Console.WriteLine(dec);


            // any to dec

            //string zaklad = "10210210";
            //int dec = 0;

            //int baze = 3;

            //for (
            //    int i = 0, hodnotaPozice = 1; //inicializace - 2 proměnné oddělené čárkou
            //    i < zaklad.Length; //kontrola běhu
            //    i++, hodnotaPozice *= baze //iterace - na konci cyklu zvyšuji dvě proměnné
            //)
            //{
            //    char znak = zaklad[zaklad.Length - 1 - i]; //í-tý znak od konce

            //    int cislo = znak - '0'; //jaké číslo je na pozici i
            //    dec += cislo * hodnotaPozice;
            //}

            //Console.WriteLine(dec);


            // dec to bin

            //int dec = 39;
            //string bin = "";

            ////děl se zbytkem - zbytek si zapiš, pak opakuj s podílem, dokud něco zbývá
            //while (dec > 0)
            //{
            //    int zbytek = dec % 2;
            //    bin = zbytek + bin; //přidám na začátek binárního řetězce
            //    dec /= 2; //vydělím číslo dvema a opakuju
            //}

            //Console.WriteLine(bin);

            //dec to any under 10

            //int dec = 39;
            //int baze = 4;
            //string prevedeno = "";

            ////děl se zbytkem - zbytek si zapiš, pak opakuj s podílem, dokud něco zbývá
            //while (dec > 0)
            //{
            //    int zbytek = dec % baze;
            //    prevedeno = zbytek + prevedeno; //přidám na začátek binárního řetězce
            //    dec /= baze; //vydělím číslo dvema a opakuju
            //}

            //Console.WriteLine(prevedeno);


            //dec to any

            //string znaky = "0123456789ABCDEF";
            //int dec = 637;
            //int baze = znaky.Length;
            //string prevedeno = "";

            ////děl se zbytkem - zbytek si zapiš, pak opakuj s podílem, dokud něco zbývá
            //while (dec > 0)
            //{
            //    int zbytek = dec % baze;
            //    prevedeno = znaky[zbytek] + prevedeno; //přidám na začátek binárního řetězce
            //    dec /= baze; //vydělím číslo dvema a opakuju
            //}

            //Console.WriteLine(prevedeno);

            Console.WriteLine(Convert.ToString(637, 16));
            Console.WriteLine(Convert.ToInt32("27d", 16));

        }
    }
}
