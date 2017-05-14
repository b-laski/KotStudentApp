using KotStudentApp.Core;
using System.Windows.Controls;
using System.Windows.Input;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for GroupItemList.xaml
    /// </summary>
    public partial class GroupItemList : UserControl
    {
        public GroupItemList()
        {
            InitializeComponent();
        }

        private async void GroupItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await IoC.Get<ApplicationViewModel>().LoadThread(((sender as GroupItem).DataContext as GroupItemViewModel).ID);
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.ThreadPage);
        }
    }
}
