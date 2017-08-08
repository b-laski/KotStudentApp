using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    /// <summary>
    /// The application state as a view model
    /// </summary>
    public class ApplicationViewModel : ViewModelBase
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.LoginScreen;

        public bool MainBar { get; set; }

        public bool Drawer { get; set; }

        public static int ThreadID { get; set; }

        public int PostID { get; set; }


        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page">The page to go to</param>
        public void GoToPage(ApplicationPage page)
        {
            // Set the current page
            CurrentPage = page;

            if (CurrentPage == ApplicationPage.LoginScreen)
                MainBar = false;
            else if (CurrentPage == ApplicationPage.RegisterScreen)
                MainBar = false;
            else if (CurrentPage == ApplicationPage.LoadingScreen)
                MainBar = false;
            else
                MainBar = true;
        }

        public void OpenHideMenu(bool value)
        {
            Drawer = value;
        }

        public async Task LoadAll()
        {
            ModelLists.Instance.user = await StudentAPI.StudentAPI.GetUserObjectAsync();
            ModelLists.Instance.groupList = await StudentAPI.StudentAPI.GetMyGroupsListAsync();
            ModelLists.Instance.collagerList = await StudentAPI.StudentAPI.GetCollegeListAsync();
        }

        public async Task LoadThread(int threadID)
        {
            ModelLists.Instance.Threads = await StudentAPI.StudentAPI.GetThreadsListAsync(threadID);
            await Task.Delay(1);
        }

        public async Task LoadPosts(int postID)
        {
            ModelLists.Instance.postList = await StudentAPI.StudentAPI.GetPostListAsync(postID,0);
            ThreadID = postID;
            await Task.Delay(1);
        }

        public async Task Search(string searchString)
        {
            ModelLists.Instance.searchedModels = await StudentAPI.StudentAPI.Search(searchString);
            await Task.Delay(1);
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.SearchPage);
        }
    }
}
