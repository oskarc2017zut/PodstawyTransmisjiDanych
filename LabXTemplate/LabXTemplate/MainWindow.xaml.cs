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

            a1.ItemsSource = zadania.ChartsData[0];
           // a2.ItemsSource = zadania.ChartsData[1];
           // a3.ItemsSource = zadania.ChartsData[2];
           // a4.ItemsSource = zadania.ChartsData[3];
           // a5.ItemsSource = zadania.ChartsData[4];
           // a6.ItemsSource = zadania.ChartsData[5];

/*
            var x = zadania.ChartsData.Count;

            List<TabItem> items = new List<TabItem>();
            foreach (var dp in zadania.ChartsData)
            {
                TabItem item = new TabItem();
                item.Header = "1";

                PlotModel plot = new PlotModel();
                LineSe

                item.Content = "";
                ChartsControl.Items.Add(item);
            }
            */
            
        }
    }
}


