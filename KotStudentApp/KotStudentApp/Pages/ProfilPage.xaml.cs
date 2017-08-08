using KotStudentApp.Core;

namespace KotStudentApp
{
    /// <summary>
    /// Interaction logic for UserProfilPage.xaml
    /// </summary>
    public partial class ProfilPage : BasePage<PageViewModel>
    {
        public ProfilPage()
        {
            InitializeComponent();
            this.DataContext = StudentAPI.StudentAPI.GetUserObject();
        }
    }
}
