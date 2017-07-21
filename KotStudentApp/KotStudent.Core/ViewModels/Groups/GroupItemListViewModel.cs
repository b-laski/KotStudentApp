using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class GroupItemListViewModel : ViewModelBase
    {
        public static GroupItemListViewModel Instance => new GroupItemListViewModel();

        #region Properties

        public bool Searched { get; set; } = false;

        public ObservableCollection<GroupItemViewModel> Items { get; set; } = new ObservableCollection<GroupItemViewModel>();

        #endregion

        #region Constructors

        public GroupItemListViewModel()
        {
            LoadDataContext();
        }

        #endregion

        #region Methods
        public void LoadDataContext()
        {
            if(ModelLists.Instance.groupList != null)
            {
                Items.Clear();
                foreach (var item in ModelLists.Instance.groupList)
                {
                    Items.Add(new GroupItemViewModel
                    {
                        GroupID = item.GroupId,
                        GroupName = item.GroupName,
                        GroupType = item.GroupType,
                        MemberId = item.MemberId

                    });
                }
            }
            else
            {
                Items = null;
            }

        }

        public void LoadSearchedGroup()
        {
            if (ModelLists.Instance.searchedModels.Groups != null)
            {
                Items.Clear();
                foreach (var item in ModelLists.Instance.searchedModels.Groups)
                {
                    Items.Add(new GroupItemViewModel
                    {
                        GroupID = item.ID,
                        GroupName = item.Name,
                        GroupType = item.Description

                    });
                }
            }
            else
            {
                Items = null;
            }
        }

        #endregion
    }
}

