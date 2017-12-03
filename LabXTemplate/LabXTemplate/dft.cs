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
        public static Complex[] computeDft(double[] input)
        {
            int n = input.Length;
            Complex[] output = new Complex[n];
            for (int k = 0; k < n; k++)
            {
                Complex sum = 0;
                for (int t = 0; t < n; t++)
                {
                    double angle = 2 * Math.PI * t * k / n;
                    sum += input[t] * Complex.Exp(new Complex(0, -angle));
                }
                output[k] = sum;
            }
            return output;
        }


        public List<DataPoint> plotdft(List<DataPoint> data)
        {
            var dft = computeDft((from DataPoint dp in data select dp.Y).ToArray());
            data.Clear();

            for (int i = 0; i < dft.Length; i++)
            {
                data.Add(new DataPoint((double) i * 100 / dft.Length, dft[i].Magnitude));
            }

            return data;
        }
    }
}