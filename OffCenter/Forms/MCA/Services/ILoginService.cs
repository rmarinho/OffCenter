using System;
using System.Threading.Tasks;

namespace MCA
{
	public interface ILoginService
	{
		Task<bool> LoginAsync(string username, string password);
	}
}
