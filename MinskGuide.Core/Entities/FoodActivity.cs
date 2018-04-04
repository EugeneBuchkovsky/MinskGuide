using System;
namespace MinskGuide.Core.Entities
{
	public class FoodActivity : Activity
	{
		public FoodActivity()
		{
			ActivityType = Enums.ActivityTypeEnum.Food;
		}
	}
}
