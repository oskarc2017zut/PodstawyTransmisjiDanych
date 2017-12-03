using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXTemplate
{
    class Modulation
    {
        private double am;
        private double fm;
        private double fn;
        private double ka;
        private double kp;

        public Modulation(double am, double fm, double fn, double ka, double kp)
        {
            this.am = am;
            this.fm = fm;
            this.fn = fn;
            this.ka = kp;
            this.kp = kp;
        }

        private double M(double t)
        {
            return (double)1 * (double)Math.Sin((double)2 * (double)Math.PI * (double)4000 * (double)t);
            //return am * Math.Sin(2 * Math.PI * fm * t);
        }

        public double Za(double t)
        {
            return ((double)80 * (double)M(t) + (double)1) * (double)Math.Cos((double)2 * (double)Math.PI * (double)8000 * (double)t);
            //return (ka * M(t) + 1) * Math.Cos(2 * Math.PI * fn * t);
        }

        public double Zp(double t)
        {
            return Math.Cos(2 * Math.PI * t + kp * M(t));
        }
    }
}
