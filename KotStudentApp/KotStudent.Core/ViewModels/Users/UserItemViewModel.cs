using System;

namespace KotStudentApp.Core
{
    public class UserItemViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }

    }
}
