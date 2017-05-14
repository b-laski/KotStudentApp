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
                    return new ProfilPage();

                case ApplicationPage.FavouriteGroups:
                    return new FavouriteGroupsPage();

                case ApplicationPage.Group:
                    return new GroupsPage();

                case ApplicationPage.LoadingScreen:
                    return new LoadingScreen();

                case ApplicationPage.ThreadPage:
                    return new ThreadPage();

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
