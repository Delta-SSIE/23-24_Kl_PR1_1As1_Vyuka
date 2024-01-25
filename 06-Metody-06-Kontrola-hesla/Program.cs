namespace _06_Metody_06_Kontrola_hesla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static bool ValidujHeslo(string heslo)
        {
            return heslo.Length > 8
                && ObsahujeZnakMezi(heslo, 'A', 'Z')
                && ObsahujeZnakMezi(heslo, 'a', 'z')
                && ObsahujeZnakMezi(heslo, '0', '9');

        }

        //static bool ObsahujeVelke(string heslo)
        //{
        //    return ObsahujeZnakMezi(heslo, 'A', 'Z');
        //}

        static bool ObsahujeZnakMezi(string retezec, char spodni, char horni)
        {
            for (int i = 0; i < retezec.Length; i++)
            {
                char znak = retezec[i];
                if (znak >= spodni && znak <= horni)
                    return true;
            }
            return false;
        }
        //static bool ObsahujeVelke(string heslo)
        //{
        //    for (int i = 0; i < heslo.Length; i++)
        //    {
        //        char znak = heslo[i];
        //        if (char.IsUpper(znak))
        //            return true;
        //    }
        //    return false;
        //}
        //static bool ObsahujeMale(string heslo)
        //{
        //    for (int i = 0; i < heslo.Length; i++)
        //    {
        //        char znak = heslo[i];
        //        if (char.IsLower(znak))
        //            return true;
        //    }
        //    return false;
        //}
        //static bool ObsahujeCislo(string heslo)
        //{
        //    for (int i = 0; i < heslo.Length; i++)
        //    {
        //        char znak = heslo[i];
        //        if (char.IsNumber(znak))
        //            return true;
        //    }
        //    return false;
        //}
    }
}
