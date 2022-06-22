using ECom.Models.ViewModel;
using ECom.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Web.Api.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        [Route("get-all")]
        [HttpGet]
        public List<CategoryListViewModel> GetAll()
        {
            return categoryService.GetAll();
        }
        [Route("create")]
        [HttpPost]
        public (bool, string) Create(CategoryCreateViewModel model)
        {
            return categoryService.Create(model);
        }
    }
}