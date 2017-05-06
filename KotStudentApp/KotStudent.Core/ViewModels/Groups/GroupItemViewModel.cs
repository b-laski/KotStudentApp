using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class GroupItemViewModel : ViewModelBase
    {
        public int ID { get; set; }

        public string GroupName { get; set; }

        public string GroupType { get; set; }

        public string GroupPhoto { get; set; }
    }
}
