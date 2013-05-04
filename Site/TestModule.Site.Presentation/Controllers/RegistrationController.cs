using System.Web.Mvc;
using TestModule.Site.Common.Constants;
using TestModule.Site.Presentation.Models;

namespace TestModule.Site.Presentation.Controllers
{
    public class RegistrationController : Controller
    {
        public const string Name = "registration";

        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View(Views.Registration);
        }

        [HttpPost]
        public ActionResult RegisterUser(UserRegistrationModel model)
        {

            if (ModelState.IsValid)
            {
                ////TODO: User registration task

                return View(Views.Home);
            }

            return View(Views.Registration, model);
        }
    }
}