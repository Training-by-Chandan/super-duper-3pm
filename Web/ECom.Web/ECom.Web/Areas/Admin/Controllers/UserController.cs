using ECom.Models.ViewModel;
using ECom.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(
            IUserService userService
            )
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AdminUserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = userService.CreateUser(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}