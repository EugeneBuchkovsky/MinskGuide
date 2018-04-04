using MinskGuide.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinskGuide.Core.ViewModels;
using Xamarin.Forms;
using MinskGuide.XF.Pages;

namespace MinskGuide.XF.Services
{
    public class NavigationServices : INavigationService
    {
        private readonly Stack<NavigationPage> _navigationPageStack = new Stack<NavigationPage>();
        private NavigationPage CurrentNavigationPage => _navigationPageStack.Peek();

        private NavigationPage MainPage
        {
            get
            {
                return Application.Current.MainPage as NavigationPage;
            }
        }

        //private Page MainPage
        //{
        //    get
        //    {
        //        return Application.Current.MainPage;
        //    }
        //}

        public async Task NavigateTo(BaseViewModel vm)
        {
            var page = GetPage(vm);
            try
            {
                //var a = CurrentNavigationPage;
                //await CurrentNavigationPage.Navigation.PushAsync(page, true);
            

            var mp = MainPage;

            if (mp == null)
            {
                //Application.Current.MainPage = mp = new DashboardPage();
            }

                //mp.Navigation.PushAsync(page);
                //new NavigationPage(page); 
                //await Application.Current.MainPage.Navigation.NavigationStack.Last().Navigation.PushAsync(page);
                //Application.Current.MainPage = new NavigationPage(page);
                await MainPage.PushAsync(page);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public Task NavigateTo(BaseViewModel vm, object parameter)
        {
            throw new NotImplementedException();
        }

        private Page GetPage(BaseViewModel vm)
        {
            if(vm is DashboardViewModel)
            {
                var Page = new DashboardPage();
                Page.BindingContext = new DashboardViewModel();
                return Page;
            }
            if (vm is ActivitiesListViewModel)
            {
                var Page = new ActivitiesListPage();
                Page.BindingContext = vm;
                return Page;
            }
			if(vm is ActivityListItemViewModel)
			{
				var Page = new ActivityPage();
				Page.BindingContext = vm;
				return Page;
			}
			if(vm is MapViewModel)
			{
				var Page = new MapPage();
				Page.BindingContext = vm;
				Page.Longitude = ((MapViewModel)vm).Longitude;
				Page.Latitude = ((MapViewModel)vm).Latitude;
				return Page;
			}

            throw new Exception("Not implemented page");
        }
    }
}
