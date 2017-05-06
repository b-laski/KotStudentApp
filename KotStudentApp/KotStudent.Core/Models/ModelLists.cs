using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotStudentApp.Core
{
    public class ModelLists
    {
        public static ModelLists Instance { get; set; } = new ModelLists();  

        public StudentAPI.Models.API.User user;

        public List<StudentAPI.Models.API.Group.Groups> groupList;

        public List<StudentAPI.Models.API.Collage.College> collagerList;

        public List<StudentAPI.Models.API.Threads.Thread> threadList;
    }
}
