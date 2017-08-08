using KotStudentApp.Core;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for GroupsPage.xaml
    /// </summary>
    public partial class GroupsPage : BasePage<GroupsPageViewModel>
    {
        public GroupsPage()
        {
            InitializeComponent();

            if(GroupList != null)
            {
                GroupList.Visibility = System.Windows.Visibility.Visible;
                NoGroupMessage.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                NoGroupMessage.Visibility = System.Windows.Visibility.Visible;
                GroupList.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}
