using KotStudentApp.Core;
using System.Windows;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for GroupThreadItemsList.xaml
    /// </summary>
    public partial class GroupThreadItemsList : UserControl
    {
        public GroupThreadItemsList()
        {
            //this.DataContext = null;
            //BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            //this.DataContext = new GroupThreadItemListViewModel();
        }

        private async void GroupThreadItem_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            await IoC.Get<ApplicationViewModel>().LoadPosts(((sender as GroupThreadItem).DataContext as GroupThreadItemViewModel).ThreadID);
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.PostPage);
        }
    }
}
