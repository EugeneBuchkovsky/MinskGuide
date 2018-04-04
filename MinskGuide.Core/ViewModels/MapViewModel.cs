using System;
namespace MinskGuide.Core.ViewModels
{
	public class MapViewModel : BaseViewModel
	{
		public MapViewModel()
		{
		}

		public double Latitude { get; set; }

		public double Longitude { get; set; }
	}
}
