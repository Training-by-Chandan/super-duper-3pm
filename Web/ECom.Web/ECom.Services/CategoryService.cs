using ECom.Models.Models;
using ECom.Models.ViewModel;
using ECom.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Services
{
    public interface ICategoryService
    {
        (bool, string) Create(CategoryCreateViewModel model);

        List<CategoryListViewModel> GetAll();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<CategoryListViewModel> GetAll()
        {
            var data = categoryRepository.GetAll();
            var ret = data.Select(p => new CategoryListViewModel()
            {
                Id = p.Id,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                ParentCategoryName = p.ParentCategory == null ? "" : p.ParentCategory.Name
            });
            return ret.ToList();
        }

        public (bool, string) Create(CategoryCreateViewModel model)
        {
            try
            {
                var cat = new Category()
                {
                    Name = model.Name,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                };
                return categoryRepository.Create(cat);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}