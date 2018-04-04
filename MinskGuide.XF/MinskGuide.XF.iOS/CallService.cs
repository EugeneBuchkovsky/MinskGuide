using System;
using System.Threading.Tasks;
using Foundation;
using MinskGuide.Core.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(MinskGuide.XF.iOS.CallService))]
namespace MinskGuide.XF.iOS
{
	public class CallService : ICallService
	{
		public Task Call(string phoneNumber)
		{
			var nsurl = new NSUrl(new Uri($"tel:{phoneNumber}").AbsoluteUri);
			if (!string.IsNullOrWhiteSpace(phoneNumber) &&
					UIApplication.SharedApplication.CanOpenUrl(nsurl))
			{
				UIApplication.SharedApplication.OpenUrl(nsurl);
			}
			return Task.FromResult(true);
		}
	}
}
