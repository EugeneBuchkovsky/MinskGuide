using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MinskGuide.Core.Enums;
using MinskGuide.Core.Services;
using Xamarin.Forms;

namespace MinskGuide.Core.ViewModels
{
	public class ActivityListItemViewModel : BaseViewModel
	{
		private INavigationService _nav;

		public ActivityListItemViewModel()
		{
			_nav = AppContainer.Instance.GetInstance<INavigationService>();
			CallCommand = new Command(DoCallCommand);
			SiteCommand = new Command(DoSiteCommand);
			MapCommand = new Command(DoMapCommand);
		}

		public string Name { get; set; }

		public string Address { get; set; }

		public ActivityTypeEnum ActivityType { get; set; }

		public string Number { get; set; }

		public double Long { get; set; }

		public double Lat { get; set; }

		public string SiteUrl { get; set; }

		public string ImageUrl { get; set; }

		public ICommand CallCommand { get; set; }
		public ICommand SiteCommand { get; set; }
		public ICommand MapCommand { get; set; }

		private async void DoCallCommand()
		{
			await DependencyService.Get<ICallService>()?.Call(Number);
		}

		private void DoSiteCommand()
		{
			Device.OpenUri(new Uri("http://google.com"));
		}

		private void DoMapCommand()
		{
			var vm = new MapViewModel();
			vm.Latitude = Lat;
			vm.Longitude = Long;

			_nav.NavigateTo(vm);
		}
    }
}
