using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskGuide.Core.ViewModels
{
    public class ActivitiesListViewModel : BaseViewModel
    {
        public ObservableCollection<ActivityListItemViewModel> ActivitiesList { get; set; }

        public ActivitiesListViewModel()
        {
            ActivitiesList = new ObservableCollection<ActivityListItemViewModel>();
            LoadData();
        }

        private void LoadData()
        {
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 1", Address = "Address 1" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 2", Address = "Address 2" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 3", Address = "Address 3" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 4", Address = "Address 4" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 5", Address = "Address 5" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 6", Address = "Address 6" });
            ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 7", Address = "Address 7" });

        }
    }
}
