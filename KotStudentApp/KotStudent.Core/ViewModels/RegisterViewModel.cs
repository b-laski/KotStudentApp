using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class RegisterViewModel : ViewModelBase
    {

        #region Command

        public ICommand SignUp { get; set; }

        public ICommand SignIn { get; set; }

        #endregion

        public RegisterViewModel()
        {
            SignIn = new RelayCommand(async () => await SignInAsync());
            SignUp = new RelayCommand(async () => await SingUpAsync());
        }

        private async Task SingUpAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.RegisterScreen);
            await Task.Delay(200);
        }

        private async Task SignInAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.LoginScreen);
            await Task.Delay(200);
        }
    }
}
