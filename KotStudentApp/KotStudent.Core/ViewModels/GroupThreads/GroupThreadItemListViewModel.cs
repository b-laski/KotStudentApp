using System.Collections.Generic;

namespace KotStudentApp.Core
{
    public class GroupThreadItemListViewModel : ViewModelBase
    {
        public static GroupThreadItemListViewModel Instance { get; set; } = new GroupThreadItemListViewModel();

        public List<GroupThreadItemViewModel> Items { get; set; } = new List<GroupThreadItemViewModel>();

        public GroupThreadItemListViewModel()
        {
            Items.Clear();
            foreach (var item in ModelLists.Instance.threadList)
            {
                Items.Add(new GroupThreadItemViewModel
                {
                    ThreadID = item.ID,
                    Title = item.Title,
                    CreatorId = item.CreatorID,
                    CreatorName = item.CreatorName,
                    CreatorPhoto = item.CreatorPhoto,
                    isPinned = item.isPinned

                });
            }
        }
    }
}
