namespace _14_Rekurze_05_JePalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JePalindrom("KUNANESENANUK"));
            Console.WriteLine(JePalindrom("ABBA"));
            Console.WriteLine(JePalindrom("howgh"));
        }

        static bool JePalindrom(string retezec)
        {
            bool stejneKonce = retezec[0] == retezec[^1]; //rovná se první poslednímu

            if (!stejneKonce)
                return false;

            if (retezec.Length < 3)
                return true;

            string podretezec = retezec[1..^1]; //odříznu první a poslední
            return JePalindrom(podretezec);
        }
    }
}
