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
                    // 1) identify rectangle's/button's name

                    Button b = new Button();

                    b.Height = cellSize;
                    b.Width = cellSize;
                    b.Style = FindResource("FieldCellButton") as Style;
                    sp.Children.Add(b);
                    
                }
                Field.Children.Add(sp);
            }
        }
    }
}
