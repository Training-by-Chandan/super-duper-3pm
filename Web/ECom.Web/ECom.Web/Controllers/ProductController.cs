using ECom.Models.ViewModel;
using ECom.Repository;
using ECom.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ECom.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController(
            IProductService productService,
             ICategoryService categoryService,
             IHostingEnvironment hostingEnvironment
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model, IFormFile productPic)
        {
            ViewBag.categoryList = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                var filename = Guid.NewGuid().ToString();

                if (productPic.Length > 0)
                {
                    var extension = Path.GetExtension(productPic.FileName);
                    var paths = Path.GetFullPath(hostingEnvironment.WebRootPath);
                    var file = Path.Combine(paths, "uploads", "products", filename + extension);

                    using (var stream = System.IO.File.Create(file))
                    {
                        productPic.CopyTo(stream);
                    }
                    model.PicturePath = "/uploads/products/" + filename + extension;
                    var res = productService.Create(model);
                    if (res.Item1)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(model);
        }
    }
}