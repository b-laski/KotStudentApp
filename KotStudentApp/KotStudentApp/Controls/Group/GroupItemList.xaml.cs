using KotStudentApp.Core;
using System.Windows.Controls;
using System.Windows.Input;
using System;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for GroupItemList.xaml
    /// </summary>
    public partial class GroupItemList : UserControl
    {
        public GroupItemList()
        {
            this.DataContext = null;
            BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            this.DataContext = new GroupItemListViewModel();
        }

        private async void GroupItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await IoC.Get<ApplicationViewModel>().LoadThread(((sender as GroupItem).DataContext as GroupItemViewModel).GroupID);
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.ThreadPage);
        }
    }
}
