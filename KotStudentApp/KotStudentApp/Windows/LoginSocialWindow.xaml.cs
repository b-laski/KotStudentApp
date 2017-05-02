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
        public delegate void LoginStatus(object sender, LoginStatusTypes Type);
        public event LoginStatus Status;

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

        private async void SignIn(string accessToken)
        {
            if (await StudentAPI.StudentAPI.SetSessionAsync("facebook", accessToken))
            {
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);
                Status?.Invoke(this, LoginStatusTypes.Success);
            }
            else
            {
                Status?.Invoke(this, LoginStatusTypes.Fail);
            }
        }
    }
}
