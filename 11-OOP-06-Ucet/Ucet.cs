using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_06_Ucet
{
    internal class Ucet
    {
        private double _zustatek;

        public double Zustatek
        {
            get { return _zustatek; }
        }

        public void Uloz(double ulozka)
        {
            if (ulozka < 0)
                throw new ArgumentOutOfRangeException();

            _zustatek += ulozka;
        }

        public bool Vyber(double castka)
        {
            if (castka < 0)
                throw new ArgumentOutOfRangeException();

            if (_zustatek >= castka)
            {
                _zustatek -= castka;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Urokuj(double urokovaMira)
        {
            //urokovaMira je třeba 1.25 ... znamená 1.25%
            _zustatek += _zustatek * urokovaMira / 100;
        }
    }
}
