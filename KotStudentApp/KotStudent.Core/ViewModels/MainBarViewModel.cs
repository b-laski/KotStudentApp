using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class MainBarViewModel : ViewModelBase
    {
        private UserControl mUserControl;

        public bool ShowHideMenuProperty { get; set; }

        public ICommand ShowHideMenuButton { get; set; }

        public MainBarViewModel(UserControl userControl)
        {
            mUserControl = userControl;

            ShowHideMenuProperty = true;

            ShowHideMenuButton = new BoolenRelayCommand(async (parameter) => await DoSomething(parameter));
        }

        private async Task DoSomething(object parameter)
        {
            ShowHideMenuProperty ^= ShowHideMenuProperty;

            await Task.Delay(1);
        }
    }
}
