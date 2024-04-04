using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_05_Kruznice_property
{
    internal class Kruznice
    {
        //public double Polomer; //polozka

        private double _polomer; //soukromá položka

        public double Polomer
        {
            get
            {
                return _polomer;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _polomer = value;
            }
        }

        public Kruznice()
        {
        }

        public Kruznice(double polomer)
        {
            Polomer = polomer;
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
