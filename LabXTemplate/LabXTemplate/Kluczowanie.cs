using System;

namespace LabXTemplate
{
    class Kluczowanie
    {
        public Kluczowanie(double a1, double a2, double fn, double fn1, double f2)
        {
            this._a1 = a1;
            this._a2 = a2;
            this._fn = fn;
            this._fn1 = fn1;
            this._fn2 = f2*10; //*10 dla wzmocnienia efektu wizualnego
        }

        private readonly double _a1;
        private readonly double _a2;
        private readonly double _fn;
        private readonly double _fn1;
        private readonly double _fn2;

        public double Za(double t, bool m)
        {
            switch (m)
            {
                case false:
                    return _a1 * Math.Sin(2 * Math.PI * _fn * t/1000);
                case true:
                    return _a2 * Math.Sin(2 * Math.PI * _fn * t/1000);
            }

            throw new NotImplementedException();
        }

        public double Zf(double t, bool m)
        {
            switch (m)
            {
                case false:
                    return Math.Sin(2 * Math.PI * _fn1 * (t/1000));
                case true:
                    return Math.Sin(2 * Math.PI * _fn2 * (t/1000));
            }

            throw new NotImplementedException();
        }

        public double Zp(double t, bool m)
        {
            switch (m)
            {
                case false:
                    return Math.Sin(2 * Math.PI * _fn * (t / 1000));
                case true:
                    return Math.Sin(2 * Math.PI * _fn * (t / 1000) + Math.PI);
            }

            throw new NotImplementedException();
        }
    }
}