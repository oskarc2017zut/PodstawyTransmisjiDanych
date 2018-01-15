using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using OxyPlot;
using System.Linq;
using System.Numerics;
using System.Windows;
using MathNet.Numerics;

namespace LabXTemplate
{
    partial class Zadania
    {
        private void demod_ask(double t)
        {
            double h = 190;
            //double Ts = 0.0715;
            double Ts = 0.07142;
            double z = 0;


            double duration = 1;
            double fs = 1000;

            double integralResoult = 0;
            double s = 0;

            double t0 = Math.Floor(t / Ts);
            for (double i = t0 * Ts; i < t0 * Ts + Ts; i += duration / fs)
            {
                if (((int) (i * fs)) < fs)
                {
                    z = dataZa[((int) (i * fs))].Y;
                    s = kluczowanie.sa(i);
                    integralResoult += z * s;
                }
            }
            
            dataZa_p.Add(new DataPoint(t, integralResoult));
            dataZa_m.Add(integralResoult > h ? new DataPoint(t, 1) : new DataPoint(t, 0));
        }


        private void demod_psk(double t)
        {
            double h = 0;
            //double Ts = 0.0715;
            double Ts = 0.07142;
            double z = 0;


            double duration = 1;
            double fs = 1000;

            double integralResoult = 0;
            double s = 0;

            double t0 = Math.Floor(t / Ts);
            for (double i = t0 * Ts; i < t0 * Ts + Ts; i += duration / fs)
            {
                if (((int) (i * fs)) < fs)
                {
                    z = dataZp[((int) (i * fs))].Y;

                    s = kluczowanie.sp(i);
                    integralResoult += z * s;
                }
            }
            
            dataZp_p.Add(new DataPoint(t, integralResoult));
            dataZp_m.Add(integralResoult > h ? new DataPoint(t, 0) : new DataPoint(t, 1));
        }

        private void demod_fsk(double t)
        {
            double h = 0;
            //double Ts = 0.0715;
            double Ts = 0.07142;
            double z = 0;


            double duration = 1;
            double fs = 1000;

            double integralResoult1 = 0;
            double integralResoult2 = 0;
            double s = 0;

            double t0 = Math.Floor(t / Ts);
            for (double i = t0 * Ts; i < t0 * Ts + Ts; i += duration / fs)
            {
                if (((int) (i * fs)) < fs)
                {
                    z = dataZf[((int) (i * fs))].Y;

                    s = kluczowanie.sf1(i);
                    integralResoult1 += z * s;
                }
            }

            for (double i = t0 * Ts; i < t0 * Ts + Ts; i += duration / fs)
            {
                if (((int) (i * fs)) < fs)
                {
                    z = dataZf[((int) (i * fs))].Y;

                    s = kluczowanie.sf2(i);
                    integralResoult2 += z * s;
                }
            }
            
            dataZf_p.Add(new DataPoint(t, integralResoult1 - integralResoult2));
            dataZf_m.Add(integralResoult1 - integralResoult2 > h ? new DataPoint(t, 0) : new DataPoint(t, 1));
        }
    }
}