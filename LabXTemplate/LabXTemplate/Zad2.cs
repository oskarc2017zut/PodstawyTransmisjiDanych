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
            var ZaFFT = computeFFT(dataZa.Select(d => new DataPoint(d.X, d.Y)).ToList());
            var ZfFFT = computeFFT(dataZf.Select(d => new DataPoint(d.X, d.Y)).ToList());
            var ZpFFT = computeFFT(dataZp.Select(d => new DataPoint(d.X, d.Y)).ToList());

            int x = ZaFFT.Count;
            for (int i = (x-1); i >= (x)/2; i--)
            {
               ZaFFT.RemoveAt(i);
               ZfFFT.RemoveAt(i);
               ZpFFT.RemoveAt(i);
            }

            ChartsData.Add(ZaFFT);
            ChartsData.Add(ZfFFT);
            ChartsData.Add(ZpFFT);
        }
    }
}
