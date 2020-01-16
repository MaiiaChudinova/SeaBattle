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
        private int size = 0;
        private const int cellSize = 30;

        public ShipUserControl()
        {
            InitializeComponent();
            DataContext = new SampleDataContext();
        }

        public int Size
        {
            get => size;
            set
            {
                if (value < 1 || value > 4)
                    throw new Exception("Ship size should be from 1 to 4");

                foreach (UIElement child in Ship.Children)
                    Ship.Children.Remove(child);

                size = value;

                for (int i = 0; i < size; ++i)
                {
                    Button b = new Button();
                    b.Height = cellSize;
                    b.Width = cellSize;
                    b.Style = FindResource("ShipCellButton") as Style;
                    Ship.Children.Add(b);
                }
            }
        }
    }
}
