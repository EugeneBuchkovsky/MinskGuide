using System;
using System.Collections.Generic;
using MinskGuide.Core.Entities;
using MinskGuide.Core.Enums;

namespace MinskGuide.Core.Services
{
	public interface ILocalData
	{
		IEnumerable<Activity> GetActivities(ActivityTypeEnum type);
	}
}
