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
        public void zad2()
        {
            const double A = 0.92;
            const double f = 1900;
            const double fn = 8000;
            const double fi = Math.PI / 3;

            const double duration = 1;//in seconds
            

            List<DataPoint> dataA = new List<DataPoint>();
            List<DataPoint> dataB = new List<DataPoint>();
            for (double n = 0; n < duration; n += 1 / fn)
            {
                double x = A * Math.Sin(2 * Math.PI * f * n + fi);
                double y = Math.Exp(-n / 2);

                double z = x + 0.35 * y;
                dataA.Add(new DataPoint(n, z));

                double v = x * y;
                dataB.Add(new DataPoint(n, v));
            }

            ChartsData.Add(plotdft(dataA));
            ChartsData.Add(plotdft(dataB));
        }
    }
}
