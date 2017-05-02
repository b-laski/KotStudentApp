using KotStudent.Core;
using KotStudentApp.Core;
using System.Windows;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<RegisterViewModel>
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Facebook_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Facebook);
            social.Show();
        }

        private void Google_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Google);
            social.Show();
        }

        private void Twitter_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Twitter);
            social.Show();
        }
    }
}
