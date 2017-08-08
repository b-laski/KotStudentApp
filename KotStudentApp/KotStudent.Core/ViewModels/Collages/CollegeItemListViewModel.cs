using System.Collections.ObjectModel;

namespace KotStudentApp.Core
{
    public class CollegeItemListViewModel : ViewModelBase
    {
        public ObservableCollection<CollegeItemViewModel> Colleges { get; set; } = new ObservableCollection<CollegeItemViewModel>();

        public CollegeItemListViewModel()
        {
            LoadColleges();
        }

        private void LoadColleges()
        {
            Colleges.Clear();
            if (ModelLists.Instance.searchedModels.Colleges != null)
            {
                foreach (var item in ModelLists.Instance.searchedModels.Colleges)
                {
                    Colleges.Add(new CollegeItemViewModel
                    {
                        ID = item.ID,
                        Name = item.Name,
                        Description = item.Description
                    });
                }
            }
            else
                Colleges = null;

        }
    }
}
