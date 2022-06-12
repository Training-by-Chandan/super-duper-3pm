using ECom.Models.ViewModel;
using ECom.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECom.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = categoryService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateViewModel model)
        {
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                var res = categoryService.Create(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Error", res.Item2);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existing = categoryService.GetbyId(id);
            if (existing == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name", existing.CategoryId);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Edit(CategoryListViewModel model)
        {
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                var res = categoryService.Edit(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Error", res.Item2);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var existing = categoryService.GetbyId(id);
            if (existing == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name", existing.CategoryId);
            return View(existing);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int Id)
        {
            var res = categoryService.Delete(Id);
            if (!res.Item1)
            {
                //redirect to some error page
            }
            return RedirectToAction("Index");
        }
    }
}