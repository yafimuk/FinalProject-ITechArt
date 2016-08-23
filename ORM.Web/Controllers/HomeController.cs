using System.Web.Mvc;
using ORM.BusinessLogic.Common;

namespace ORM.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICarService _carService;

		public HomeController(ICarService carService)
		{
			_carService = carService;
		}

		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
	}
}