using KotStudent.Core;
using KotStudentApp.Core;
using System;
using System.Windows;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for LoginSocialWindow.xaml
    /// </summary>
    public partial class LoginSocialWindow : Window
    {
        public LoginSocialWindow(LoginSocialTypes Type)
        {
            InitializeComponent();

            this.DataContext = new LoginSocialWindowViewModel(this, Type);
        }

        private void ChromiumWebBrowser_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
            if (e.Url.Contains("access_token"))
            {
                string[] _tokenSep = new string[] { "=", "&" };
                SignIn(((e.Url).Split(_tokenSep, StringSplitOptions.None)[1]));
            }
        }

        private void SignIn(string accessToken)
        {
            if (StudentAPI.StudentAPI.SetSession("facebook", accessToken))
            {
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);
            }
            else
            {

            }
        }
    }
}
