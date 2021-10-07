using Microsoft.AspNetCore.Mvc;

namespace my_projects.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
