using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using OxyPlot;

namespace LabXTemplate
{
    partial class Zadania
    {
        public void zad3()
        {
            const double fn = 4000;
            const double duration = 1;//in seconds

            List<DataPoint> data = new List<DataPoint>();
            for (double t = 0; t < duration; t += 1 / fn)
            {
                double u = 0;
                if (t < 0.2)
                {
                    u = 0.5 * Math.Cos(12 * Math.PI * (t - 0.7) / fn);
                    
                }
                else if (t < 0.7)
                {
                    u = Math.Pow(t, -1);
                }
                else if (t < 1)
                {
                    u = t * Math.Sin(5 * Math.PI / fn);
                }

                data.Add(new DataPoint(t, u));
            }

            ChartsData.Add(plotdft(data));
        }
    }
}
