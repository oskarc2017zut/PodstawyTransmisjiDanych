using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXTemplate
{
    class Modules
    {
        private double am;
        private double fm;
        private double fn;
        private double ka;
        private double kp;

        public Modules(double am, double fm, double fn, double ka, double kp)
        {
            this.am = am;
            this.fm = fm;
            this.fn = fn;
            this.ka = kp;
            this.kp = kp;
        }

        public double M(double t)
        {
            return am * Math.Sin(2 * Math.PI * fm * t);
        }

        public double Za(double t)
        {
            return (ka * M(t) + 1) * Math.Cos(2 * Math.PI * fn * t);
        }

        public double Zp(double t)
        {
            return Math.Cos(2 * Math.PI * t + kp * M(t));
        }
    }
}
