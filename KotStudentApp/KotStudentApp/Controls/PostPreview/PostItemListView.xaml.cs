using KotStudentApp.Core;
using System;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for PostPreviewList.xaml
    /// </summary>
    public partial class PostItemListView : UserControl
    {
        public PostItemListView()
        {
            try
            {
                this.DataContext = null;
                BindData();
            }
            finally
            {
                InitializeComponent();
            }

        }

        private void BindData()
        {
            if (new PostItemListViewModel() != null)
                this.DataContext = new PostItemListViewModel();
            else
                this.DataContext = null;
        }
    }
}
