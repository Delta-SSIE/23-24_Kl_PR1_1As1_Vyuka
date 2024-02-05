namespace _05_Array_10_opakovana_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 15, 2, -12, 0, 2, 5, 0, 15, 16, -2, 2, 16, 0, 0, 15, 15, -12 };
            
            int[] opakovana = new int[cisla.Length / 3];
            int pocetUlozenychCisel = 0;

            //projdu všechna čísla
            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = cisla[i];


                bool mamHo = false;
                // když číslo ještě nemám
                for (int j = 0; j < pocetUlozenychCisel; j++)
                {
                    if (opakovana[j] == cislo)
                    {
                        mamHo = true;
                        break;
                    }
                }
                if (mamHo)
                    continue;
                
                // když číslo, které testuju je v původním poli tříkrát
                int vyskyty = 1;
                for (int j = i + 1; j < cisla.Length; j++)
                {
                    if (cisla[j] == cislo)
                        vyskyty++;
                    if (vyskyty > 2)
                        break;
                }

                // tak si ho zapíšu
                if (vyskyty < 3)               
                    continue;
                

                opakovana[pocetUlozenychCisel] = cislo;
                pocetUlozenychCisel++;
            }

            int[] vysledek = new int[pocetUlozenychCisel];
            for (int i = 0; i < pocetUlozenychCisel; i++)
                vysledek[i] = opakovana[i];


            Console.WriteLine($"[{string.Join(", ", vysledek)}]");
        }
    }
}
