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
            z1d.ItemsSource = zadania.ChartsData[0];

            z2c.ItemsSource = zadania.ChartsData[1];
            z2d.ItemsSource = zadania.ChartsData[1];

            z3c.ItemsSource = zadania.ChartsData[2];
            z3d.ItemsSource = zadania.ChartsData[2];

            z4c.ItemsSource = zadania.ChartsData[3];
            z4d.ItemsSource = zadania.ChartsData[3];

            z5c.ItemsSource = zadania.ChartsData[4];
            z5d.ItemsSource = zadania.ChartsData[4];

            z6c.ItemsSource = zadania.ChartsData[5];
            z6d.ItemsSource = zadania.ChartsData[5];

            z7c.ItemsSource = zadania.ChartsData[6];
            z7d.ItemsSource = zadania.ChartsData[6];
        }
    }
}


