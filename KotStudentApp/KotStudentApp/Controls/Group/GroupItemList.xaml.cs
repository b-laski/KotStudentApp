using KotStudentApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void GroupItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show((((sender as GroupItem).DataContext as GroupItemViewModel).ID).ToString());
        }
    }
}
