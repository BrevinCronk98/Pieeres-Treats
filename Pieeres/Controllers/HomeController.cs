using Microsoft.AspNetCore.Mvc;

namespace PieeresTreats.Controllers
{
    public class HomeController : Controllers
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}