using KotStudentApp.Core;
using System.Windows.Controls;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for MainBar.xaml
    /// </summary>
    public partial class MainBar : UserControl
    {
        public MainBar()
        {
            InitializeComponent();
            this.DataContext = new MainBarViewModel(this);
        }
    }
}
