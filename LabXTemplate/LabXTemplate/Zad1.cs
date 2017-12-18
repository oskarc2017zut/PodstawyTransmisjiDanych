using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using OxyPlot;
using System.Linq;
using System.Numerics;
using MathNet.Numerics;

namespace LabXTemplate
{
    partial class Zadania
    {
        List<DataPoint> dataBin = new List<DataPoint>();
        List<DataPoint> dataZa = new List<DataPoint>();
        List<DataPoint> dataZf = new List<DataPoint>();
        List<DataPoint> dataZp = new List<DataPoint>();

        public void zad1()
        {
            int value = 15422;
            string binary = Convert.ToString(value, 2);

            bool[] m = new bool[binary.Length];
            for (int i = 0; i < binary.Length; i++)
            {
                switch (binary[i])
                {
                    case '0':
                        m[i] = false;
                        break;
                    case '1':
                        m[i] = true;
                        break;
                }
            }

            double N = 10;
            double Tb = 0.001;
            double fs = 1000;

            double duration = 1; //in seconds


            var kluczowanie = new Kluczowanie(1, 3, N / Tb, (N + 1) / Tb, (N + 1) / Tb);

            int mi(bool mb)
            {
                switch (mb)
                {
                    case false:
                        return 0;
                    case true:
                        return 1;
                }
                throw new NotImplementedException();
            }

            for (double i = 0; i < duration; i += duration / fs)
            {
                bool mb = m[(int) (m.Length * i)];

                dataBin.Add(new DataPoint(i, mi(mb)));
                dataZa.Add(new DataPoint(i, kluczowanie.Za(i, mb)));
                dataZf.Add(new DataPoint(i, kluczowanie.Zf(i, mb)));
                dataZp.Add(new DataPoint(i, kluczowanie.Zp(i, mb)));
            }

            ChartsData.Add(dataBin);
            ChartsData.Add(dataZa);
            ChartsData.Add(dataZf);
            ChartsData.Add(dataZp);
        }
    }
}