using System;
using System.Threading.Tasks;
using Android.Content;
using MinskGuide.Core.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(MinskGuide.XF.Droid.CallService))]
namespace MinskGuide.XF.Droid
{
	public class CallService : ICallService
	{
		public Task Call(string phoneNumber)
		{
			var packageManager = Android.App.Application.Context.PackageManager;
			Android.Net.Uri telUri = Android.Net.Uri.Parse($"tel:{phoneNumber}");
			var callIntent = new Intent(Intent.ActionCall, telUri);

			callIntent.AddFlags(ActivityFlags.NewTask);
			// проверяем доступность
			var result = null != callIntent.ResolveActivity(packageManager);

			if (!string.IsNullOrWhiteSpace(phoneNumber) && result == true)
			{
				Android.App.Application.Context.StartActivity(callIntent);
			}

			return Task.FromResult(true);
		}
	}
}
