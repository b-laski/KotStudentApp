using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class GroupItemViewModel : ViewModelBase
    {
        public int GroupID { get; set; }

        public string GroupName { get; set; }

        public string GroupType { get; set; }

        public string GroupPhoto { get; set; }

        public int MemberId { get; set; }


        public ICommand LeaveCommand { get; set; }

        public GroupItemViewModel()
        {
            LeaveCommand = new RelayCommand(async () => await GroupLeave());
        }

        private async Task GroupLeave()
        {
            MessageBoxResult result = MessageBox.Show("Czy chcesz opuścić grupe?","Pytanie", MessageBoxButton.YesNo,MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                StudentAPI.StudentAPI.LeaveFromGroup(GroupID, MemberId);
                await Task.Delay(1);
            }
        }
    }
}
