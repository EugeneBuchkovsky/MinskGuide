using MinskGuide.Core.Entities;
using MinskGuide.Core.Enums;
using MinskGuide.Core.Services;
using MinskGuide.Core.Services.Realization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MinskGuide.Core.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService _nav;
		private ILocalData _data;

        public DashboardViewModel()
        {
            _nav = AppContainer.Instance.GetInstance<INavigationService>();
			_data = new DataService();

			ButtonCommand = new Command<string>(DoButtonCommand);
        }

        public ICommand ButtonCommand { get; set; } 

		private async void DoButtonCommand(string param)
        {
			var data = _data.GetActivities(GetActivityType(param));

			var vm = new ActivitiesListViewModel(data);

            _nav.NavigateTo(vm);
        }

		private ActivityTypeEnum GetActivityType(string num)
		{
			int typeNum = int.Parse(num);
			var resultType = (ActivityTypeEnum)typeNum;
			return resultType;
		}
    }
}
