using System;
using System.Diagnostics;
using System.Globalization;

namespace SeaBattle
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Game:
                    return new GamePage();

                case ApplicationPage.Results:
                    return new ResultsPage();

                case ApplicationPage.Welcome:
                    return new WelcomePage();

                case ApplicationPage.ShipAllocation:
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
