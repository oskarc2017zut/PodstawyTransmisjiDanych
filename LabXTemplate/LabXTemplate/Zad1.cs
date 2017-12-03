using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using OxyPlot;
using System.Linq;
using System.Numerics;

namespace LabXTemplate
{
    partial class Zadania
    {
        enum Z
        {
            a,
            p
        }

        public void zad1()
        {
            const double A = 1;
            const double fm = 4000;
            const double fn = 8000;

            double ka;
            double kp;

            const double fs = 2000;
            const double duration = 1; //in seconds

            List<DataPoint> modulating(Z z)
            {
                List<DataPoint> data = new List<DataPoint>();

                var mod = new Modulation(A, fm, fn, ka, kp);
                Func<double, double> func;
                switch (z)
                {
                    case Z.a:
                        func = mod.Za;
                        break;
                    case Z.p:
                        func = mod.Zp;
                        break;
                    default:
                        throw new NotImplementedException();
                }



                for (double x = 0; x < duration; x += 1 / fs)
                {
                    double y = func(x);
                    data.Add(new DataPoint(x, y));
                }


                return data;
            }

            void k(double a, double p)
            {
                ka = a; kp = p;

                void computeMods(Z z)
                {
                var mod = modulating(z);
                //var modFFT = computeFFT(mod.Select(d => new DataPoint(d.X, d.Y)).ToList());
               // var modDB = modFFT.Select(d => new DataPoint(d.X, d.Y)).ToList();

                ChartsData.Add(mod);
               // ChartsData.Add(modFFT);
                //ChartsData.Add(modDB);
                }

                computeMods(Z.a);
                //computeMods(Z.p);
            }

            k(80, 45);
        }

    }
}
