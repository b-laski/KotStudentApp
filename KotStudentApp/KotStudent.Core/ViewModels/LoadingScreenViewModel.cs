using System;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class LoadingScreenViewModel : ViewModelBase
    {
        public LoadingScreenViewModel()
        {
            LoadAll();
        }

        private async void LoadAll()
        {
            await Task.Delay(1000);
            await IoC.Get<ApplicationViewModel>().LoadAll();
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);
        }
    }
}
