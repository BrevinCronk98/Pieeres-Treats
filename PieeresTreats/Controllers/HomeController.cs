using Microsoft.AspNetCore.Mvc;

namespace Pieeres.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}