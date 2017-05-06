using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class GroupItemListDesign : GroupItemListViewModel
    {
        public static GroupItemListDesign InstanceDesign => new GroupItemListDesign();

        public GroupItemListDesign()
        {
            Items = new List<GroupItemViewModel>
            {
                new GroupItemViewModel
                {
                    GroupName = "Grupa Nijaka",
                    GroupType = "COURSE"
                },
                new GroupItemViewModel
                {
                    GroupName = "Grupa Gangu Albani",
                    GroupType = "COURSE"
                },
                new GroupItemViewModel
                {
                    GroupName = "Grupa Cos tam Cos Tam",
                    GroupType = "COURSE"
                },

            };
        }
    }
}
