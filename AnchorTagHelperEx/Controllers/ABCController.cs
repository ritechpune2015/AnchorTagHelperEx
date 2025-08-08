using Microsoft.AspNetCore.Mvc;

namespace AnchorTagHelperEx.Controllers
{
	public class ABCController : Controller
	{
		public string Index()
		{
			return "ABC Index";
		}
		public string SayHello(string id, string str)
		{
			return $"id value is:{id} str value is: {str}";
		}
	}
}
