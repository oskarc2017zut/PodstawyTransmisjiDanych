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

            //xamlZad1Chart.ItemsSource = zadania.ChartsData[0];
            //xamlZad1Data.ItemsSource = zadania.ChartsData[0];


            //xamlZad2AChart.ItemsSource = zadania.ChartsData[1];
            //xamlZad2AData.ItemsSource = zadania.ChartsData[1];

            //xamlZad2BChart.ItemsSource = zadania.ChartsData[2];
            //xamlZad2BData.ItemsSource = zadania.ChartsData[2];


            //xamlZad3Chart.ItemsSource = zadania.ChartsData[3];
            //xamlZad3Data.ItemsSource = zadania.ChartsData[3];


            //xamlZad4AChart.ItemsSource = zadania.ChartsData[4];
            //xamlZad4AData.ItemsSource = zadania.ChartsData[4];

            //xamlZad4BChart.ItemsSource = zadania.ChartsData[5];
            //xamlZad4BData.ItemsSource = zadania.ChartsData[5];

            //xamlZad4CChart.ItemsSource = zadania.ChartsData[6];
            //xamlZad4CData.ItemsSource = zadania.ChartsData[6];

            //xamlfftChart.ItemsSource = zadania.ChartsData[7];
            //xamlfftData.ItemsSource = zadania.ChartsData[7];
        }
    }
}


