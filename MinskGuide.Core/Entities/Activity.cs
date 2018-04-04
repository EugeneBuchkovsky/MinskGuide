using System;
using MinskGuide.Core.Enums;

namespace MinskGuide.Core.Entities
{
	public class Activity
	{
		public string Name { get; set; }

		public ActivityTypeEnum ActivityType { get; set; }

		public string Number { get; set; }

		public string Address { get; set; }

		public double Long { get; set; }

		public double Lat { get; set; }

		public string SiteUrl { get; set; }

		public string ImageUrl { get; set; }
	}
}
