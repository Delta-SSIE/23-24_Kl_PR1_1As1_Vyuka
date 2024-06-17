namespace _14_Rekurze_04_Vypis_adresare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VypisAdresar(@"D:\capture");
        }

        static void VypisAdresar(string cesta)
        {
            string[] files = Directory.GetFiles(cesta);
            //vypiš všechny soubory v adresáři
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            string[] subdirs = Directory.GetDirectories(cesta);
            //vypiš každý podadresář
            foreach(string subdir in subdirs)
            {
                VypisAdresar(subdir);
            }
        }
    }
}
