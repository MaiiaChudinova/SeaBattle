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
                // Every child StackPanel is VERTICAL, i.e. the number i represents COLUMN
                StackPanel sp = new StackPanel();

                for (int j = 0; j < fieldSize; ++j)
                {
                    Button b = new Button();

                    //b.Name = "FieldCell ({j},{i})"; // ArgumentException - why?
                    b.Tag = $"FieldCell ({j},{i})";
                    b.Height = cellSize;
                    b.Width = cellSize;
                    b.Style = FindResource("FieldCellButton") as Style;
                    b.Click += new RoutedEventHandler(OnClick);
                    sp.Children.Add(b);
                }
                Field.Children.Add(sp);
            }
        }

        // Debug method (to be deleted)
        void OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((string)(((Button)sender).Tag));
        }
    }
}
