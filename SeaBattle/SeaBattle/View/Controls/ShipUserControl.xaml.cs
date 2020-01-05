﻿using System;
using System.Collections.Generic;
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

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для ShipUserControl.xaml
    /// </summary>
    public partial class ShipUserControl : UserControl
    {
        public ShipUserControl()
        {
            InitializeComponent();
            DataContext = new SampleDataContext();
        }
    }
}
