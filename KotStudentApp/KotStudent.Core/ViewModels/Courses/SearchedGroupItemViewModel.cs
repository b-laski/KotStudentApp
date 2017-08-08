using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class SearchedGroupItemViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public ICommand JoinCommand { get; set; }

        public SearchedGroupItemViewModel()
        {
            JoinCommand = new RelayCommand(async () => await JoinToGroup());
        }

        private async Task JoinToGroup()
        {
            try
            {
                StudentAPI.StudentAPI.JoinToGroup(ID);
                MessageBox.Show("Dołączyłeś!");
                await Task.Delay(1);
            }
            catch
            {
                MessageBox.Show("Jesteś już w grupie lub nie możesz do niej dołączyć!");
            }

        }
    }
}
