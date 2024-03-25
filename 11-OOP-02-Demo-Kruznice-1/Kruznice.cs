using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_02_Demo_Kruznice_1
{
    internal class Kruznice
    {
        //public double Polomer; //polozka

        private double _polomer; //soukromá položka

        public void SetPolomer(double value) //bezpečnostní rám a kontrola
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();

            _polomer = value;
        }

        public double GetPolomer() //dovolí hodnotu přečíst zvenku, ale nesahá se zvenku přímo
        {
            return _polomer;
        }

        public double Obvod()
        {
            return 2 * Math.PI * _polomer;
        }

        public double Obsah()
        {
            return Math.PI * _polomer * _polomer;
        }
    }
}
