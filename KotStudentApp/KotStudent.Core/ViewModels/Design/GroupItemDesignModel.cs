using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class GroupDesignViewModel : GroupItemViewModel
    {
        public static GroupDesignViewModel Instance => new GroupDesignViewModel();

        public GroupDesignViewModel()
        {
            GroupName = "Grupa Nijaka";
            GroupType = "COURSE";
        }
    }
}
