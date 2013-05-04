using System.Web.Mvc;
using TestModule.Site.Common.Constants;

namespace TestModule.Site.Presentation.Controllers
{
    public class MenuController : Controller
    {
        public const string Name = "menu";

        [HttpGet]
        public ActionResult Menu()
        {
            return View(Views.Menu);
        }
    }
}
