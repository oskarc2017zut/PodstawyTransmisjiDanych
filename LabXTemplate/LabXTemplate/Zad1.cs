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
        public void zad1()
        {
            List<DataPoint> Data = new List<DataPoint>();
            
            Data.Add(new DataPoint(1,1));
            Data.Add(new DataPoint(1,2));
            Data.Add(new DataPoint(1,3));
            
            ChartsData.Add(Data);
        }
    }
}
