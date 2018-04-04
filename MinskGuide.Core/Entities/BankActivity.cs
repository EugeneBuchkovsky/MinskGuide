using System;
namespace MinskGuide.Core.Entities
{
	public class BankActivity : Activity
	{
		public BankActivity()
		{
			ActivityType = Enums.ActivityTypeEnum.Banks;
		}
	}
}
