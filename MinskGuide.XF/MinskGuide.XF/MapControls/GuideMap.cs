using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace MinskGuide.XF.MapControls
{
	public class GuideMap : Map
	{
		public ActivityPin GuidePin { get; set; }

		public GuideMap(MapSpan region) : base(region) { }
	}
}