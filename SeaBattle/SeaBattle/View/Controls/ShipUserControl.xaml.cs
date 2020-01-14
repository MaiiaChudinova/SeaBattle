using System;
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
        private static int curSize = 4;

        public ShipUserControl()
        {
            InitializeComponent();
            DataContext = new SampleDataContext();


            const int cellSize = 30;

            for (int i = 0; i < curSize; ++i)
            {
                Button b = new Button();

                b.Height = cellSize;
                b.Width = cellSize;
                b.Style = FindResource("FieldCellButton") as Style;
                Ship.Children.Add(b);
            }
            --curSize;

        }
    }
}
