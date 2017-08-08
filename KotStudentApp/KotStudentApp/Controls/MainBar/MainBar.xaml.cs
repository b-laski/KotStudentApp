using KotStudentApp.Core;
using System.Windows;
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

        private async void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Enter)
            {
                if(SearchingBox.Text.Length >= 3)
                    await IoC.Get<ApplicationViewModel>().Search(SearchingBox.Text);
            }
        }
    }
}
