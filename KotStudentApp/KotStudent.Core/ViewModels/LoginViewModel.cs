using System.Threading.Tasks;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class LoginViewModel : ViewModelBase
    {
        #region Public properties

        public string Nickname { get; set; }

        #endregion

        #region Commands

        public ICommand SignInCommand { get; set; }

        public ICommand SignUpCommand { get; set; }

        #endregion

        public LoginViewModel()
        {
            SignInCommand = new RelayCommand(async () => await LoginAsync());
            SignUpCommand = new RelayCommand(async () => await RegisterAsync());
        }

        public async Task LoginAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.LoadingScreen);

            await Task.Delay(1);
        }

        public async Task RegisterAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.RegisterScreen);

            await Task.Delay(1);
        }
    }
}
