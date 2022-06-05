using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}