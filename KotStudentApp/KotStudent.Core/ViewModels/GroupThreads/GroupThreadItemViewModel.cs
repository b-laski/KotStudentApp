namespace KotStudentApp.Core
{
    public class GroupThreadItemViewModel : ViewModelBase
    {
        public int ThreadID { get; set; }

        public int GroupID { get; set; }

        public string Title { get; set; }

        public bool isPinned { get; set; }

        public StudentAPI.Models.API.User Creator { get; set; }
    }
}
