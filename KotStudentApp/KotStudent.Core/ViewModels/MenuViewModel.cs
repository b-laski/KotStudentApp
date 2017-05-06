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

        public ICommand Favourite { get; set; }

        public ICommand Group { get; set; }

        public ICommand Settings { get; set; }

        public ICommand Feedback { get; set; }

        public ICommand Logout { get; set; }

        #endregion

        #region CTORS

        public MenuViewModel(UserControl userControl)
        {
            mUserControl = userControl;

            Dashboard = new RelayCommand(async () => await DashboardAsync());
            Favourite = new RelayCommand(async () => await FavouriteAsync());
            Group = new RelayCommand(async () => await GroupsPageAsync());
            Settings = new RelayCommand(async () => await FavouriteAsync());
            Feedback = new RelayCommand(async () => await FavouriteAsync());
            Logout = new RelayCommand(async () => await FavouriteAsync());
        }

        #endregion

        private async Task DashboardAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);
            await Task.Delay(150);
            IoC.Get<ApplicationViewModel>().OpenHideMenu(false);
        }
        private async Task FavouriteAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.FavouriteGroups);
            await Task.Delay(150);
            IoC.Get<ApplicationViewModel>().OpenHideMenu(false);
        }
        private async Task GroupsPageAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Group);
            await Task.Delay(150);
            IoC.Get<ApplicationViewModel>().OpenHideMenu(false);
        }
    }
}
