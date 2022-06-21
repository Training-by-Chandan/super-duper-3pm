using AutoMapper;
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

        (bool, string) Delete(int id);

        (bool, string) Edit(CategoryListViewModel model);

        List<CategoryListViewModel> GetAll();

        CategoryListViewModel GetbyId(int Id);
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
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
                var cat = mapper.Map<CategoryCreateViewModel, Category>(model);

                return categoryRepository.Create(cat);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public CategoryListViewModel GetbyId(int Id)
        {
            var data = categoryRepository.GetById(Id);
            if (data != null)
            {
                return new CategoryListViewModel()
                {
                    Id = data.Id,
                    Name = data.Name,
                    Description = data.Description,
                    CategoryId = data.CategoryId,
                    ParentCategoryName = data.ParentCategory == null ? "" : data.ParentCategory.Name
                };
            }
            else
            {
                return null;
            }
        }

        public (bool, string) Edit(CategoryListViewModel model)
        {
            try
            {
                var existing = categoryRepository.GetById(model.Id);
                if (existing == null) return (false, "Record not found");

                existing.Name = model.Name;
                existing.Description = model.Description;
                existing.CategoryId = model.CategoryId;

                return categoryRepository.Edit(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = categoryRepository.GetById(id);
                if (existing == null) return (false, "Record not found");

                return categoryRepository.Delete(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}