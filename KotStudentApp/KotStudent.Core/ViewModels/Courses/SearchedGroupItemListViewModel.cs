using System.Collections.ObjectModel;

namespace KotStudentApp.Core
{
    public class SearchedGroupItemListViewModel : ViewModelBase
    {
        public ObservableCollection<SearchedGroupItemViewModel> GroupList { get; set; } = new ObservableCollection<SearchedGroupItemViewModel>();

        public SearchedGroupItemListViewModel()
        {
            LoadModels();
        }

        private void LoadModels()
        {
            if(ModelLists.Instance.searchedModels.Groups != null)
            {
                GroupList.Clear();
                foreach (var item in ModelLists.Instance.searchedModels.Groups)
                {
                    GroupList.Add(new SearchedGroupItemViewModel
                    {
                        ID = item.ID,
                        GroupName = item.Name,
                        Description = item.Description
                    });
                }

            }
            else
            {
                GroupList = null;
            }
        }
    }
}
