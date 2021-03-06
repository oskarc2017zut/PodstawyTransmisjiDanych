﻿using System;
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
        public void zad4()
        {
            const double fn = 10000;
            const double duration = 1;//in seconds
            

            List<DataPoint> dataA = new List<DataPoint>();
            List<DataPoint> dataB = new List<DataPoint>();
            List<DataPoint> dataC = new List<DataPoint>();
            for (double t = 0; t < duration; t += 1 / fn)
            {
                double g(double H)
                {
                    double tmp = 0;

                    for (double p = 0; p < H; p++)
                    {
                        tmp += 1 / (2 * p + 1) * Math.Sin(((2 * p + 1) * Math.PI * t) / (0.1 * fn));
                    }

                    

                    return Math.Pow(Math.PI, -1) * tmp;
                }

                dataA.Add(new DataPoint(t, g(1)));
                dataB.Add(new DataPoint(t, g(10)));
                dataC.Add(new DataPoint(t, g(120)));
            }

            ChartsData.Add(plotdft(dataA));
            ChartsData.Add(plotdft(dataB));
            ChartsData.Add(plotdft(dataC));
        }
    }
}
