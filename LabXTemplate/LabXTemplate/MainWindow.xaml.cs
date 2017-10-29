using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
    public partial class MainWindow : MetroWindow
    {
        

        public MainWindow()
        {
            InitializeComponent();
            var zadania = new Zadania();
            ChartsControl = _generateCharts(zadania);
        }

        private TabControl _generateCharts(Zadania zadania)
        {
            TabControl control = new TabControl();
            List<TabItem> controlItems = new List<TabItem>();
            foreach (var chartdata in zadania.ChartsData)
            {
                var item = new TabItem();
                var subControl = new TabControl();
                var subControlItems = new List<TabItem>();

                var itemChart = new TabItem();
                var chart = new PlotModel();
                var linearSeries = new OxyPlot.Series.LineSeries();
                linearSeries.ItemsSource = chartdata;
                chart.Series.Add(linearSeries);



                subControl.ItemsSource = subControlItems;
                item.Content = subControl;
                controlItems.Add(item);
            }
            control.ItemsSource = controlItems;

            return control;
        }

        
    }
}


