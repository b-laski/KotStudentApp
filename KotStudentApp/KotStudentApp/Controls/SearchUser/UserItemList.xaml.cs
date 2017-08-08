using KotStudentApp.Core;
using System;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for UserItemList.xaml
    /// </summary>
    public partial class UserItemList : UserControl
    {
        public UserItemList()
        {
            this.DataContext = null;
            BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            this.DataContext = new UserItemListViewModel();
        }
    }
}
