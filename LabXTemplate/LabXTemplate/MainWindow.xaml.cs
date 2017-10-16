using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using MahApps.Metro.Controls;
using OxyPlot;

namespace LabXTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            //timer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        DispatcherTimer timer = null;
        Random rnd = new Random();
        Stopwatch stopwatch = new Stopwatch();

        private void Timer_Tick(object sender, EventArgs e)
        {
            double time = ((double)stopwatch.ElapsedMilliseconds)/ 1000;
            double frequency = 1;
            double phase = 0;
            double t = frequency * time + phase;
            Data.Add(new DataPoint(time, 2f * (t - (float)Math.Floor(t + 0.5f))));
        }

        public ObservableCollection<DataPoint> Data
        {
            get { return (ObservableCollection<DataPoint>)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(ObservableCollection<DataPoint>), typeof(MainWindow), new PropertyMetadata(new ObservableCollection<DataPoint>()));

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (timer == null)
            {
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(10);
                timer.Tick += Timer_Tick;
                stopwatch.Start();
                timer.Start();
            }
        }
    }
}

/*
 * public float GetValue(float time)
			#else
			private float GetValue(float time)
			#endif
		{
			float value = 0f;
			float t = frequency * time + phase;
			switch (signalType)
			{ // http://en.wikipedia.org/wiki/Waveform
				case SignalType.Sine: // sin( 2 * pi * t )
					value = (float)Math.Sin(2f*Math.PI*t);
					break;
				case SignalType.Square: // sign( sin( 2 * pi * t ) )
					value = Math.Sign(Math.Sin(2f*Math.PI*t));
					break;
				case SignalType.Triangle: // 2 * abs( t - 2 * floor( t / 2 ) - 1 ) - 1
					value = 1f-4f*(float)Math.Abs( Math.Round(t-0.25f)-(t-0.25f) );
					break;
				case SignalType.Sawtooth: // 2 * ( t/a - floor( t/a + 1/2 ) )
					value = 2f*(t-(float)Math.Floor(t+0.5f));
					break;
					

				case SignalType.Pulse: // http://en.wikipedia.org/wiki/Pulse_wave
					value = (Math.Abs(Math.Sin(2*Math.PI*t)) < 1.0 - 10E-3) ? (0) : (1);
					break;
				case SignalType.WhiteNoise: // http://en.wikipedia.org/wiki/White_noise
					value = 2f *(float)random.Next(int.MaxValue) / int.MaxValue - 1f;
					break;
				case SignalType.GaussNoise: // http://en.wikipedia.org/wiki/Gaussian_noise
					value = (float)StatisticFunction.NORMINV((float)random.Next(int.MaxValue) / int.MaxValue, 0.0, 0.4);
					break;
				case SignalType.DigitalNoise: //Binary Bit Generators
					value = random.Next(2);
					break;
					
				case SignalType.UserDefined:
					value = (getValueCallback==null) ? (0f): getValueCallback(t);
					break;
			}

			return(invert*amplitude*value+offset);
		}
 */
