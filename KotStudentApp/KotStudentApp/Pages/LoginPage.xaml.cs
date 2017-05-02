using KotStudentApp.Core;
using System.Windows;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Facebook_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Facebook);
            social.ShowDialog();
        }

        private void Google_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Google);
            social.ShowDialog();
        }

        private void Twitter_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Twitter);
            social.ShowDialog();
        }
    }
}
