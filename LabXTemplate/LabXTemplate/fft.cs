using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using System.Numerics;
using MathNet;

namespace LabXTemplate
{
    partial class Zadania
    {
        public List<DataPoint> computeFFT(List<DataPoint> data)
        {
            var z = (from DataPoint dp in data select dp.Y).ToArray();

            List<Complex> s = new List<Complex>();

            foreach (var q in z)
            {
                s.Add(new Complex(q, 0));
            }

            var g = s.ToArray();

            MathNet.Numerics.IntegralTransforms.Fourier.Forward(g);

            data.Clear();

            for (int i = 0; i < g.Length; i++)
            {
                var fn = 1900;
                data.Add(new DataPoint((double)i * fn / g.Length, g[i].Magnitude));
            }

            return data;
        }

        public void lab2zad3()
        {
            List<DataPoint> data = new List<DataPoint>();
            
            const double fs = 1024;

            const double duration = 1; //in seconds

            for (double x = 0; x < duration; x += 1 / fs)
            {
                double y = Math.Sin(200 * Math.PI * x / fs) + 0.5 * Math.Sin(350 * Math.PI * x / fs);
                data.Add(new DataPoint(x, y));
            }

            var z = (from DataPoint dp in data select dp.Y).ToArray();
            
            List<Complex> s = new List<Complex>();

            foreach (var q in z)
            {
                s.Add(new Complex(q,0));
            }

            var g = s.ToArray();

            MathNet.Numerics.IntegralTransforms.Fourier.Forward(g);

            data.Clear();

            for (int i = 0; i < g.Length; i++)
            {
                data.Add(new DataPoint((double)i * 100 / g.Length, g[i].Magnitude));
            }

            ChartsData.Add(data);
        }
    }
}