using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class GroupThreadItemListViewModel : ViewModelBase
    {
        #region Properties
        public int GroupId { get; set; }
        public string CreateThreadWindow { get; set; } = "Collapsed";
        public string Title { get; set; }
        public ObservableCollection<GroupThreadItemViewModel> Items { get; set; }
        #endregion

        #region Command
        public ICommand AddThread { get; set; }
        public ICommand RemoveThread { get; set; }
        public ICommand CreateThread { get; set; }
        public ICommand CancelAddingThread { get; set; }
        #endregion

        #region Constructors
        public GroupThreadItemListViewModel()
        {
            Items = new ObservableCollection<GroupThreadItemViewModel>();
            GroupId = ModelLists.Instance.Threads.GroupID;
            AddThread = new RelayCommand(() => { CreateThreadWindow = "Visible"; });
            CancelAddingThread = new RelayCommand(() => { CreateThreadWindow = "Collapsed"; });
            RemoveThread = new RelayCommand(async () => await RemoveSelectedThread());
            CreateThread = new RelayCommand(async () => await CreateNewThread());
            Reaload();
        }
        #endregion

        #region Methods
        private async Task RemoveSelectedThread()
        {
            await Task.Delay(1);
        }

        private async Task CreateNewThread()
        {
            StudentAPI.StudentAPI.CreateThread(GroupId, Title, false);
            ModelLists.Instance.Threads = await StudentAPI.StudentAPI.GetThreadsListAsync(GroupId);
            CreateThreadWindow = "Collapsed";
            //MessageBox.Show("STWORZONO!");
            Reaload();
        }

        public void Reaload()
        {
            Items.Clear();
            foreach (var item in ModelLists.Instance.Threads.Thread)
            {
                Items.Add(new GroupThreadItemViewModel
                {
                    GroupID = ModelLists.Instance.Threads.GroupID,
                    ThreadID = item.ID,
                    Title = item.Title,
                    isPinned = item.isPinned,
                    Creator = item.Creator
                });
            }
        }
        #endregion

    }
}
