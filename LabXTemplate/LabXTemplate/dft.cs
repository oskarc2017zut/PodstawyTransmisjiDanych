using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using System.Numerics;

namespace LabXTemplate
{
    partial class Zadania
    {
        public List<Complex> calculateDFT(List<Complex> x)
        {
            List<Complex> output = new List<Complex>();

            int n = x.Count;

            for (int k = 0; k < n; k++)
            {
                Complex sum = 0;
                for (int t = 0; t < n; t++)
                {
                    double angle = 2 * Math.PI * t * k / n;
                    sum += x[t] * Complex.Exp(new Complex(0, -angle));
                }
                output.Add(sum);
            }


            return output;
        }
    }
}