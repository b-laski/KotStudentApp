using KotStudentApp.Core;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for GroupSearchItemList.xaml
    /// </summary>
    public partial class GroupSearchItemList : UserControl
    {
        public GroupSearchItemList()
        {
            this.DataContext = null;
            BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            this.DataContext = new SearchedGroupItemListViewModel();
        }
    }
}
