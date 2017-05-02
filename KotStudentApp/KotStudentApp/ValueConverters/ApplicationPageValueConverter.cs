using KotStudentApp.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace KotStudentApp
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
                case ApplicationPage.LoginScreen:
                    return new LoginPage();

                case ApplicationPage.RegisterScreen:
                    return new RegisterPage();

                case ApplicationPage.DashboardScreen:
                    return new DashboardPage();

                case ApplicationPage.Profile:
                    return new UserProfilPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
