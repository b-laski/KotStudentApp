using System.Collections.ObjectModel;

namespace KotStudentApp.Core
{
    public class UserItemListViewModel : ViewModelBase
    {
        public ObservableCollection<UserItemViewModel> UsersList { get; set; } = new ObservableCollection<UserItemViewModel>();

        public UserItemListViewModel()
        {
            ReloadUsers();
        }

        private void ReloadUsers()
        {
            if(ModelLists.Instance.searchedModels.Users != null)
            {
                UsersList.Clear();
                foreach (var item in ModelLists.Instance.searchedModels.Users)
                {
                    UsersList.Add(new UserItemViewModel
                    {
                        ID = item.UserID,
                        Name = item.Name,
                        Birthday = item.Birthday
                    });
                }

            }
            else
            {
                UsersList = null;
            }
        }
    }
}
