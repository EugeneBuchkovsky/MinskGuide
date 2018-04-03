using MinskGuide.Core.Services;
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

        public DashboardViewModel()
        {
            _nav = AppContainer.Instance.GetInstance<INavigationService>();
            var n = _nav;
            ButtonCommand = new Command<string>(DoButtonCommand);
        }

        public ICommand ButtonCommand { get; set; } 

        private async void DoButtonCommand(string text)
        {
            var vm = new ActivitiesListViewModel();
            _nav.NavigateTo(vm);
        }
    }
}
