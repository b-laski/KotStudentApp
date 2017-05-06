using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core.ViewModels.GroupThreads
{
    class GroupThreadItemViewModel : ViewModelBase
    {
        public int ThreadID { get; set; }

        public string Title { get; set; }

        public bool isPinned { get; set; }

        public int? CreatorId { get; set; }

        public string CreatorName { get; set; }

        public string CreatorPhoto { get; set; }
    }
}
