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
        List<DataPoint> dataCoddedBin = new List<DataPoint>();

        List<DataPoint> dataDeBin = new List<DataPoint>();
        List<DataPoint> dataDeCoddedBin = new List<DataPoint>();

        List<DataPoint> dataZa = new List<DataPoint>();
        List<DataPoint> dataZa_x = new List<DataPoint>();
        List<DataPoint> dataZa_p = new List<DataPoint>();
        List<DataPoint> dataZa_m = new List<DataPoint>();

        List<DataPoint> dataZp = new List<DataPoint>();
        List<DataPoint> dataZp_x = new List<DataPoint>();
        List<DataPoint> dataZp_p = new List<DataPoint>();
        List<DataPoint> dataZp_m = new List<DataPoint>();

        List<DataPoint> dataZf = new List<DataPoint>();
        List<DataPoint> dataZf_x1 = new List<DataPoint>();
        List<DataPoint> dataZf_x2 = new List<DataPoint>();
        List<DataPoint> dataZf_p = new List<DataPoint>();
        List<DataPoint> dataZf_m = new List<DataPoint>();

        private Kluczowanie kluczowanie;

        public void zad1()
        {
            int value = 11;
            string binary = Convert.ToString(value, 2);

            char[] binarycharArray = binary.ToArray();
            int[] binaryIntArray = new int[binary.Length];
            for (int i = 0; i < binaryIntArray.Length; i++)
            {
                binaryIntArray[i] = Int32.Parse(binarycharArray[i].ToString());
            }
            var binaryInt = getCodded(binaryIntArray);

            bool[] m = new bool[binaryInt.Length];
            for (int i = 0; i < binaryInt.Length; i++)
            {
                switch (binaryInt[i])
                {
                    case 0:
                        m[i] = false;
                        break;
                    case 1:
                        m[i] = true;
                        break;
                }
            }



            double N = 10;
            double Tb = 0.001;
            double fs = 1000;

            double duration = 1; //in seconds


            kluczowanie = new Kluczowanie(1, 3, N / Tb, (N + 1) / Tb, (N + 1) / Tb);

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
                dataZa_x.Add(new DataPoint(i, kluczowanie.Za(i, mb) * kluczowanie.sa(i)));

                dataZf.Add(new DataPoint(i, kluczowanie.Zf(i, mb)));
                dataZf_x1.Add(new DataPoint(i, kluczowanie.Zf(i, mb) * kluczowanie.sf1(i)));
                dataZf_x2.Add(new DataPoint(i, kluczowanie.Zf(i, mb) * kluczowanie.sf2(i)));

                dataZp.Add(new DataPoint(i, kluczowanie.Zp(i, mb)));
                dataZp_x.Add(new DataPoint(i, kluczowanie.Zp(i, mb) * kluczowanie.sp(i)));
            }

            for (double i = 0; i < duration; i += duration / fs)
            {
                demod_ask(i);
            }

            List<int> demodList = new List<int>();
            for (double i = duration / 8; i < duration; i += duration / 8)
            {
                demodList.Add((int)Math.Round(dataZa_m.FirstOrDefault(x => x.X >= i).Y));
            }
            //demodList[1] = 1;
            var demodArray = demodList.ToArray();
            var decoded = getDecoded(demodArray);

            List<DataPoint> tmp = new List<DataPoint>();
            for (int j = 0; j < decoded.Length; j++)
            {
                    tmp.Add(new DataPoint(j,decoded[j]));
            }

            for (double i = 0; i < duration; i += duration / fs)
            {
                dataCoddedBin.Add(new DataPoint(i, demodArray[(int)(Math.Floor(i * demodArray.Length))]));

                dataDeCoddedBin.Add(new DataPoint(i,decoded[(int)(Math.Floor(i*decoded.Length))]));
            }



            ChartsData.Add(dataBin);

            ChartsData.Add(dataZa);
            ChartsData.Add(dataZa_x);
            ChartsData.Add(dataZa_p);
            ChartsData.Add(dataZa_m);

            ChartsData.Add(dataZp);
            ChartsData.Add(dataZp_x);
            ChartsData.Add(dataZp_p);
            ChartsData.Add(dataZp_m);

            ChartsData.Add(dataZf);
            ChartsData.Add(dataZf_x1);
            ChartsData.Add(dataZf_x2);
            ChartsData.Add(dataZf_p);
            ChartsData.Add(dataZf_m);

            ChartsData.Add(dataCoddedBin);
            ChartsData.Add(dataDeCoddedBin);
        }
    }
}