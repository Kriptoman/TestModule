using System.Web.Mvc;
using TestModule.Site.Common.Constants;

namespace TestModule.Site.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public const string Name = "home";

        [HttpGet]
        public ActionResult Index()
        {
            return View(Views.Home);
        }
    }
}
