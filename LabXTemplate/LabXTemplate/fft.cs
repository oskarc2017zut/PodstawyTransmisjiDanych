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
                s.Add(new Complex(q,0));
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
    }
}