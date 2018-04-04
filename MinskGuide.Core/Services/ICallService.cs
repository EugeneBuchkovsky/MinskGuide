using System;
using System.Threading.Tasks;

namespace MinskGuide.Core.Services
{
	public interface ICallService
	{
		Task Call(string phoneNumber);
	}
}
