using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class MainBarViewModel : ViewModelBase
    {
        #region Private members

        private UserControl mUserControl;

        #endregion

        #region Public Properties

        public bool ShowHideMenuProperty { get; set; }

        #endregion

        #region Commands

        public ICommand ShowHideMenuButton { get; set; }

        #endregion

        #region CTORS

        public MainBarViewModel(UserControl userControl)
        {
            mUserControl = userControl;

            ShowHideMenuProperty = true;

            ShowHideMenuButton = new RelayCommand(async () => await ShowMenu());
        }

        #endregion

        #region Methods

        private async Task ShowMenu()
        {

            await Task.Delay(1);
        }

        #endregion

    }
}
