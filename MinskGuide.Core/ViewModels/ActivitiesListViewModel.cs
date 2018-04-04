using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinskGuide.Core.Entities;
using MinskGuide.Core.Helpers;
using MinskGuide.Core.Services;
using Xamarin.Forms;

namespace MinskGuide.Core.ViewModels
{
    public class ActivitiesListViewModel : BaseViewModel
    {
		private INavigationService _nav;

		public ActivitiesListViewModel(IEnumerable<Activity> list)
		{
			AddList(list);
			_nav = AppContainer.Instance.GetInstance<INavigationService>();
		}

		private ObservableCollection<ActivityListItemViewModel> _activitiesList;
        public ObservableCollection<ActivityListItemViewModel> ActivitiesList 
		{ 
			get { return _activitiesList; }
			set
			{
				_activitiesList = value;
				OnPropertyChanged("ActivitiesList");
			}
		}

		private ActivityListItemViewModel _selectedItem;
		public ActivityListItemViewModel SelectedItem
		{
			get { return _selectedItem; }
			set
			{
				_selectedItem = value;
				OnPropertyChanged("SelectedItem");
				DoSelectItem();
			}
		}

        private void LoadData()
        {
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 1", Address = "Address 1" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 2", Address = "Address 2" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 3", Address = "Address 3" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 4", Address = "Address 4" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 5", Address = "Address 5" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 6", Address = "Address 6" });
            //ActivitiesList.Add(new ActivityListItemViewModel { Name = "Activity 7", Address = "Address 7" });

        }

		public void AddList(IEnumerable<Activity> list)
		{
			var vmList = MapHelper.MapToViewModel(list);
			ActivitiesList = new ObservableCollection<ActivityListItemViewModel>(vmList);

			OnPropertyChanged("ActivitiesList");
		}

		private void DoSelectItem()
		{
			_nav.NavigateTo(SelectedItem);
		}
		//public new event PropertyChangedEventHandler PropertyChanged;

		//protected override void OnPropertyChanged(string propertyName)
		//{
		//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		//}
    }
}
