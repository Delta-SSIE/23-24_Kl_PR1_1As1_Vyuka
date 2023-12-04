namespace _04_For_09_Je_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej řetězec: ");
            string input = Console.ReadLine();

            //odstraním vše kromě znaků, převedu na malá písmena
            string text = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    text += input[i];
            }
            text = text.ToLower();

            bool jePalindrom = true; //předpokládám, že je to palindorm

            ////metoda 1: budu porovnavat odpredu a odzadu, dokud se nepotkaji
            //int predni = 0;
            //int zadni = text.Length - 1;

            //while (predni < zadni)
            //{
            //    if (input[predni] != input[zadni])
            //    {
            //        jePalindrom = false;
            //        break;
            //    }                    

            //    predni++;
            //    zadni--;
            //}

            //Metoda 2: pojedu s i do půlky ...
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    jePalindrom = false;
                    break;
                }
            }

            Console.WriteLine($"Řetězec \"{input}\" {(jePalindrom ? "je" : "není")} palindrom");

        }
    }
}
