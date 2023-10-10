using System.Text.Json;

namespace _02_Podminky_10_Znaky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //změna velikosti znaku
            //char znak = 'c';
            //char maly = char.ToLower(znak); //změní znak na malé písmeno
            //Console.WriteLine(maly);

            char znak = '5';

            int cisloZnaku = znak; //zjištění typu znaku přes Ascii
            Console.WriteLine(cisloZnaku);
            if (cisloZnaku >= 48 && cisloZnaku <= 57)
                Console.WriteLine("Je to číslice");

            if (char.IsDigit(znak)) //zjištění pomocí metod třídy char (IsDigit, IsAscii, ...)
            {
                Console.WriteLine("Je to číslice");
            }
        }
    }
}
