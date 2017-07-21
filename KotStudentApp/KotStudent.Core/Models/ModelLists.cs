using System.Collections.Generic;

namespace KotStudentApp.Core
{
    public class ModelLists
    {
        public static ModelLists Instance { get; set; } = new ModelLists();  

        public StudentAPI.Models.API.User user;

        public List<StudentAPI.Models.API.Group.Groups> groupList = new List<StudentAPI.Models.API.Group.Groups>();

        public List<StudentAPI.Models.API.Collage.College> collagerList = new List<StudentAPI.Models.API.Collage.College>();

        public StudentAPI.Models.API.Threads.ThreadsGroup Threads;

        public List<StudentAPI.Models.API.PostComent.Post> postList = new List<StudentAPI.Models.API.PostComent.Post>();

        public StudentAPI.Models.API.Search searchedModels;
    }
}
