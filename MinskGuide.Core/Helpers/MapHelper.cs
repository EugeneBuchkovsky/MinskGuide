using System;
using System.Collections.Generic;
using MinskGuide.Core.Entities;
using MinskGuide.Core.ViewModels;

namespace MinskGuide.Core.Helpers
{
	public static class MapHelper
	{
		public static List<ActivityListItemViewModel> MapToViewModel(IEnumerable<Activity> list)
		{
			var resultList = new List<ActivityListItemViewModel>();
			foreach (var i in list)
			{
				resultList.Add(new ActivityListItemViewModel 
				{ 
					Name = i.Name, 
					Number = i.Number, 
					ActivityType = i.ActivityType, 
					Address = i.Address, 
					Lat =i.Lat,
					Long = i.Long,
					SiteUrl = i.SiteUrl,
					ImageUrl = i.ImageUrl
				});
			}

			return resultList;
		}
	}
}
