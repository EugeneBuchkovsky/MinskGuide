using System;
using Xamarin.Forms.Maps;

namespace MinskGuide.XF.MapControls
{
	public class ActivityPin
	{
		public Pin Pin { get; set; }

		public string Url { get; set; }

		public string Image { get; set; }

		public string Icon { get; set; }

		public Action SelectPin { get; set; }
	}
}
