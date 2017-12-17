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

            int value = 1532;
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

            ChartsData.Add(plotdft(data));
        }
    }
}