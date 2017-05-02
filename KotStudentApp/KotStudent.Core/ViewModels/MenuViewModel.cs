using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class MenuViewModel : ViewModelBase
    {
        #region Private members

        private UserControl mUserControl;

        #endregion

        #region Command

        public ICommand Dashboard { get; set; }

        public ICommand Groups { get; set; }

        #endregion

        #region CTORS

        public MenuViewModel(UserControl userControl)
        {
            mUserControl = userControl;

            Dashboard = new RelayCommand(async () => await DashboardAsync());
            Dashboard = new RelayCommand(async () => await DashboardAsync());
        }
        #endregion

        private async Task DashboardAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);

            await Task.Delay(1);
        }
    }
}
