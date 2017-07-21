using System.Collections.ObjectModel;

namespace KotStudentApp.Core
{
    public class DepartmentItemListViewModel : ViewModelBase
    {
        public ObservableCollection<DepartmentItemViewModel> DepartmentsList = new ObservableCollection<DepartmentItemViewModel>();

        public DepartmentItemListViewModel()
        {
            ReloadDepartments();
        }

        private void ReloadDepartments()
        {
            if(ModelLists.Instance.searchedModels.Deparments != null)
            {
                DepartmentsList.Clear();
                foreach (var item in ModelLists.Instance.searchedModels.Deparments)
                {
                    DepartmentsList.Add(new DepartmentItemViewModel
                    {
                        ID = item.ID,
                        Name = item.Name,
                        Description = item.Description
                    });
                }
            }
            else
            {
                DepartmentsList = null;
            }
        }
    }
}
