using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class GroupItemListViewModel : ViewModelBase
    {
        public static GroupItemListViewModel Instance => new GroupItemListViewModel();

        #region Properties

        public List<GroupItemViewModel> Items { get; set; }

        #endregion

        #region Commands

        public ICommand AddButon { get; set; }

        #endregion

        #region Constructors

        public GroupItemListViewModel()
        {
            AddButon = new RelayCommand(async () => await ShowCard());
            LoadDataContext();
        }

        #endregion

        #region Methods
        public void LoadDataContext()
        {
            Items = new List<GroupItemViewModel>();
            foreach (var item in ModelLists.Instance.groupList)
            {
                Items.Add(new GroupItemViewModel
                {
                    ID = item.GroupId,
                    GroupName = item.GroupName,
                    GroupType = item.GroupType
                });
            }
        }

        private async Task ShowCard()
        {
            await Task.Delay(1);
        }

        #endregion
    }
}

