using System;
using MinskGuide.XF.MapControls;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MinskGuide.XF.Pages
{
	public class MapPage : ContentPage
	{
		public MapPage()
		{
			//Content = new StackLayout
			//{
			//	Children = {
			//		new Label { Text = "Hello ContentPage" }
			//	}
			//};

			//var map = new Map(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(0.3)))
			//{
			//	IsShowingUser = true,
			//	HeightRequest = 100,
			//	WidthRequest = 960,
			//	VerticalOptions = LayoutOptions.FillAndExpand
			//};
		}

		private double latitude;
		public double Latitude
		{
			get { return latitude; }
			set
			{
				latitude = value;
				SetMap();
			}
		}
		private double longitude;
		public double Longitude
		{
			get { return longitude; }
			set
			{
				longitude = value;
				SetMap();
			}
		}

		public GuideMap CustomMap { get; set; }

		private void SetMap()
		{
			Content = null;
			CustomMap = null;

			CustomMap = new GuideMap(
			MapSpan.FromCenterAndRadius(
			new Xamarin.Forms.Maps.Position(Latitude, Longitude), Distance.FromMiles(1)))
			{
				//IsShowingUser = false,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand,
				MapType = MapType.Hybrid
			};

			var pin = new ActivityPin
			{
				Pin = new Pin
				{
					Type = PinType.Place,
					Position = new Position(Latitude, Longitude),
					Label = "Xamarin San Francisco Office",
					Address = "394 Pacific Ave, San Francisco CA"
					//Label = "Photo zona",
					//Address = "Take photo here!"
				},
				Url = "http://xamarin.com/about/",
				Image = "Markers/map_markers_z2.png",
				Icon = "Icons/icons_colored_z2.png"
			};

			//pin.SelectPin += SelectPin;

			//CustomMap.CustomPins = new List<CustomPin> { pin, pin2, pin3, pin4, pin5 };
			CustomMap.GuidePin = pin;
			CustomMap.Pins.Add(pin.Pin);

			Content = CustomMap;
		}
	}
}


