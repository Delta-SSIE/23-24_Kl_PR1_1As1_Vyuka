namespace _04_For_06_caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char znak = 'f';
            //int kod = (int)znak;
            //Console.WriteLine(kod);
            //kod += 1;
            //Console.WriteLine(kod);
            //znak = (char)kod;
            //Console.WriteLine(znak);


            //načíst řetězec
            Console.WriteLine("Co chceš zašifrovat: ");
            string vstup = Console.ReadLine();
            vstup = vstup.ToUpper();

            int klic = -3;

            //připravím proměnnou pro výstup
            string vystup = "";

            char znak;
            int kodZnaku;

            //projít znak po znaku
            for (int i = 0; i < vstup.Length; i++)
            {
                znak = vstup[i];
                kodZnaku = znak;

                if (kodZnaku > 64 && kodZnaku < 91)
                {
                    //pro písmena přičtu klíč
                    kodZnaku += klic;

                    //pokud jsem mimo abecedu, odečtu 26 (délku abecedy)
                    if (kodZnaku > 90)
                        kodZnaku -= 26;
                    else if (kodZnaku < 65)
                        kodZnaku += 26;

                }
                //jinka neměním



                //přidám zašifrovaný znak do výstupu
                vystup += (char)kodZnaku;
            }

            //vypíšu výstup
            Console.WriteLine(vystup);

        }
    }
}
