using System.Windows;
using System.Windows.Controls;

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для FieldUserControl.xaml
    /// </summary>
    public partial class FieldUserControl : UserControl
    {
        public FieldUserControl()
        {
            InitializeComponent();

            const int fieldSize = 10;
            const int cellSize = 30;

            for (int i = 0; i < fieldSize; ++i)
            {
                StackPanel sp = new StackPanel();

                for (int j = 0; j < fieldSize; ++j)
                {
                    //Rectangle r = new Rectangle();

                    // 1) identify rectangle's/button's name
                    // 2) create this specific button style (fieldcellbutton style)

                    Button b = new Button();

                    b.Height = cellSize;
                    b.Width = cellSize;
                    //b.Background = Brushes.White;
                    //b.BorderBrush = Brushes.Black;
                    b.Style = FindResource("FieldCellButton") as Style;
                    sp.Children.Add(b);
                    
                }
                Field.Children.Add(sp);
            }
        }
    }
}
