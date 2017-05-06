using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class ProfilViewModel : ViewModelBase
    {
        public static ProfilViewModel Instance { get; set; } = new ProfilViewModel();

        public string Cover { get; set; }

        public string Photo { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime? RegisterTime { get; set; }

        public string Email { get; set; }

        public ProfilViewModel()
        {
            Cover = ModelLists.Instance.user.Cover;
            Photo = ModelLists.Instance.user.Photo;
            Name = ModelLists.Instance.user.Name;
            Gender = ModelLists.Instance.user.Gender;
            RegisterTime = ModelLists.Instance.user.RegisterTime;
            Email = ModelLists.Instance.user.Cover;
        }
    }
}
