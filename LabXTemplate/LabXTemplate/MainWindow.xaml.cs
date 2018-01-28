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

            z1c.ItemsSource = zadania.ChartsData[0];
            z2c.ItemsSource = zadania.ChartsData[1];
            z3c.ItemsSource = zadania.ChartsData[2];
            z4c.ItemsSource = zadania.ChartsData[3];
            z5c.ItemsSource = zadania.ChartsData[4];
            z6c.ItemsSource = zadania.ChartsData[5];
            z7c.ItemsSource = zadania.ChartsData[6];
            z8c.ItemsSource = zadania.ChartsData[7];
            z9c.ItemsSource = zadania.ChartsData[8];
            z10c.ItemsSource = zadania.ChartsData[9];
            z11c.ItemsSource = zadania.ChartsData[10];
            z12c.ItemsSource = zadania.ChartsData[11];
            z13c.ItemsSource = zadania.ChartsData[12];
            z14c.ItemsSource = zadania.ChartsData[13];
            z15c.ItemsSource = zadania.ChartsData[14];
            z16c.ItemsSource = zadania.ChartsData[15];
        }
    }
}


