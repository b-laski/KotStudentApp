using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core.ViewModels.Design
{
    public class ProfileDesignViewModel : ProfilViewModel
    {
        public static ProfileDesignViewModel Instance => new ProfileDesignViewModel();

        public ProfileDesignViewModel()
        {
            new ProfilViewModel
            {
                Name = "Bartłomiej Łaski",
                Gender = "Mężczyzna",
                Email = "tajfun695@gmail.com",
                RegisterTime = DateTime.Today
            };
        }
    }
}
