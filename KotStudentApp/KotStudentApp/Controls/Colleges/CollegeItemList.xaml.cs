using System.Windows.Controls;
using KotStudentApp.Core;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for CollegeItemList.xaml
    /// </summary>
    public partial class CollegeItemList : UserControl
    {
        public CollegeItemList()
        {
            this.DataContext = null;
            BindData();
            InitializeComponent();
        }

        private void BindData()
        {
            this.DataContext = new CollegeItemListViewModel();
        }
    }
}
