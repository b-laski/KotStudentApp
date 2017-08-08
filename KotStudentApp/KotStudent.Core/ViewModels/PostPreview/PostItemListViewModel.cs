using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KotStudentApp.Core
{
    public class PostItemListViewModel : ViewModelBase
    {
        #region Properties
        public static int ThreadID { get; set; }
        public string CreatePostWindow { get; set; } = "Collapsed";
        public string Title { get; set; }

        public ObservableCollection<PostItemViewModel> Items { get; set; } = new ObservableCollection<PostItemViewModel>();
        #endregion

        #region Command
        public ICommand CreatePost { get; set; }
        public ICommand AddPost { get; set; }
        public ICommand RemovePost { get; set; }
        public ICommand CancelAddingPost { get; set; }
        #endregion

        #region Constructors
        public PostItemListViewModel()
        {
            CreatePost = new RelayCommand(() => { CreatePostWindow = "Visible"; });
            CancelAddingPost = new RelayCommand(() => { CreatePostWindow = "Collapsed"; });
            RemovePost = new RelayCommand(async () => await RemoveSelectedPosts());
            AddPost = new RelayCommand(async () => await CreateNewPost());

            ReloadContent();
        }

        private async Task RemoveSelectedPosts()
        {
            MessageBox.Show(Items[0].ThreadID.ToString());
            await Task.Delay(1);
        }

        private async Task CreateNewPost()
        {
            StudentAPI.StudentAPI.CreatePost(ApplicationViewModel.ThreadID, Title);
            ModelLists.Instance.postList = await StudentAPI.StudentAPI.GetPostListAsync(ApplicationViewModel.ThreadID,0);          
            CreatePostWindow = "Collapsed";
            //MessageBox.Show("STWORZONO!");
            ReloadContent();
        }
        #endregion

        #region Methods
        private void ReloadContent()
        {
            if (ModelLists.Instance.postList != null)
            {
                Items.Clear();
                foreach (var item in ModelLists.Instance.postList)
                {
                    Items.Add(new PostItemViewModel
                    {
                        ThreadID = ApplicationViewModel.ThreadID,
                        PostID = item.ID,
                        Content = item.Content,
                        CreateDate = item.CreateDate,
                        userID = item.Creator.UserID,
                        UserName = item.Creator.Name
                    });
                }
            }
            else
                Items = null;
        }

        #endregion

    }
}
