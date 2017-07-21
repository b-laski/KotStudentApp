using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class PostItemViewModel
    {
        public int PostID { get; set; }

        public int ThreadID { get; set; }

        public string Content { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? userID { get; set; }

        public string UserName { get; set; }

        public ICommand DeleteCommand { get; set; }

        public PostItemViewModel()
        {
            DeleteCommand = new RelayCommand(async () => await DeleteMethod());
        }

        private async Task DeleteMethod()
        {
            await Task.Delay(1);
            var result = MessageBox.Show("Czy na pewno chcesz usunąć ten post?", "Ostrzeżenie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                StudentAPI.StudentAPI.DeletePost(PostID);
            }
        }
    }
}
