using SeaBattle.Models;
using System;
using System.Globalization;
using System.Windows.Media;

namespace SeaBattle.ValueConverters
{
    public class FieldCellStateToColorBrushConverter : BaseValueConverter<FieldCellStateToColorBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((FieldCellState)value)
            {
                case FieldCellState.Unknown:
                    return new SolidColorBrush(Colors.Blue);

                case FieldCellState.Known:
                    return new SolidColorBrush(Colors.Red);

                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = ((SolidColorBrush)value).Color;

            if (color == Colors.Red)
                return FieldCellState.Known;

            if (color == Colors.Blue)
                return FieldCellState.Unknown;

            return null;
        }
    }
}
