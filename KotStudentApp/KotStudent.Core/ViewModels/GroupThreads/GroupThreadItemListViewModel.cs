using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core.ViewModels.GroupThreads
{
    class GroupThreadItemListViewModel : ViewModelBase
    {
        public GroupThreadItemListViewModel Instance { get; set; } = new GroupThreadItemListViewModel();

        public List<GroupThreadItemViewModel> Items { get; set; }

        public GroupThreadItemListViewModel()
        {
            Items = new List<GroupThreadItemViewModel>();
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
