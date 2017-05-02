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
            social.Show();
            social.Status += Social_Status;
        }

        private void Google_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Google);
            social.Show();
            social.Status += Social_Status;
        }

        private void Twitter_LoginButton(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginSocialWindow social = new LoginSocialWindow(LoginSocialTypes.Twitter);
            social.Show();
            social.Status += Social_Status;
        }

        private void Social_Status(object sender, LoginStatusTypes Type)
        {
            switch(Type)
            {
                case LoginStatusTypes.Success:
                    this.Dispatcher.Invoke(() =>{ (sender as Window).Close(); });
                    break;
                case LoginStatusTypes.Fail:
                    this.Dispatcher.Invoke(() => { (sender as Window).Close(); });
                    MessageBox.Show("Serwer nie odpowiada");
                    break;
            }
        }
    }


}
