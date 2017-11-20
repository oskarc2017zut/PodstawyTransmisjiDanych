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

        public void zad1()
        {
            List<DataPoint> data = new List<DataPoint>();


            const double A = 0.92;
            const double f = 1900;
            const double fn = 8000;
            const double fi = Math.PI / 3;

            const double duration = 1; //in seconds

            for (double x = 0; x < duration; x += 1 / fn)
            {
                double y = A * Math.Sin(2 * Math.PI * f * x + fi);
                data.Add(new DataPoint(x, y));
            }
            
            
            ChartsData.Add(plotdft(data));
        }
    }
}
