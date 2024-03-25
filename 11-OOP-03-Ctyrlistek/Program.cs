using System.Security.Cryptography;

namespace _11_OOP_03_Ctyrlistek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KomiksovaPostava[] ctyrlistek = new KomiksovaPostava[] {

                new KomiksovaPostava
                {
                    Jmeno = "Bobík",
                    Rasa = Rasa.Prase,
                    OblibenaJidla = new string[] { "Tlačenka", "Guláš", "Vajíčka" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Fifinka",
                    Rasa = Rasa.Pes,
                    OblibenaJidla = new string[] { "Salát" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Pinďa",
                    Rasa = Rasa.Zajíc,
                    OblibenaJidla = new string[] { "Salát", "Mrkev", "Rohlík" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Myšpulín",
                    Rasa = Rasa.Kočka,
                    OblibenaJidla = new string[] { "Konzerva", "Párek", "Kuře", "Pilulky" }
                }
            };

            for (int i = 0; i < ctyrlistek.Length; i++)
            {
                KomiksovaPostava kp = ctyrlistek[i];
                Console.WriteLine($"{kp.Jmeno}: {kp.SeznamJidel()}");
            }

            foreach (KomiksovaPostava kp in ctyrlistek)
            {
                Console.WriteLine($"{kp.Jmeno}: {kp.SeznamJidel()}");
            }


        }
    }

    enum Rasa { Pes, Kočka, Zajíc, Prase };

    class KomiksovaPostava
    {
        public string Jmeno;
        public Rasa Rasa; public bool JeStastny;
        public string[] OblibenaJidla;
        public int[] StastnaCisla;
        public string SeznamJidel()
        {
            return string.Join(", ", OblibenaJidla);
        }
    }

}
