using System.Web.Mvc;

namespace ToDo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Мои задачи";
			return View();
		}
	}
}
