namespace KotStudentApp.Core
{
    public class GroupThreadItemViewModel : ViewModelBase
    {
        public int ThreadID { get; set; }

        public string Title { get; set; }

        public bool isPinned { get; set; }

        public int? CreatorId { get; set; }

        public string CreatorName { get; set; }

        public string CreatorPhoto { get; set; }
    }
}
