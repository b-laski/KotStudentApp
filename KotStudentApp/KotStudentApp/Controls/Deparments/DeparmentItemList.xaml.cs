using KotStudentApp.Core;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for DeparmentItemList.xaml
    /// </summary>
    public partial class DeparmentItemList : UserControl
    {
        public DeparmentItemList()
        {
            this.DataContext = null;
            BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            this.DataContext = new DepartmentItemListViewModel();
        }
    }
}
