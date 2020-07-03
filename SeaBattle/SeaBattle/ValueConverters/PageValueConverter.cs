using SeaBattle.Models;
using SeaBattle.Views.Pages;
using System;
using System.Globalization;

namespace SeaBattle.ValueConverters
{
    public class PageValueConverter : BaseValueConverter<PageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((PageType)value)
            {
                case PageType.Login:
                    return new LoginPage();

                case PageType.Welcome:
                    return new WelcomePage();

                case PageType.ShipAllocation:
                    return new ShipAllocationPage();

                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}