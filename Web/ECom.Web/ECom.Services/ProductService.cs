using ECom.Models.Models;
using ECom.Models.ViewModel;
using ECom.Repository;

namespace ECom.Services
{
    public interface IProductService
    {
        (bool, string) Create(ProductViewModel model);

        (bool, string) Delete(int id);

        (bool, string) Edit(ProductViewModel model);

        List<ProductViewModel> GetAll();

        ProductViewModel GetbyId(int Id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(
            IProductRepository productRepository
            )
        {
            this.productRepository = productRepository;
        }

        public List<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll();
            var ret = data.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                CategoryName = p.Category == null ? "" : p.Category.Name,
                PicturePath = p.PicturePath,
                Price = p.Price,
                Stock = p.Stock,
                Units = p.Units
            });
            return ret.ToList();
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var cat = new Product()
                {
                    Name = model.Name,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                    Units = model.Units,
                    Stock = model.Stock,
                    Price = model.Price,
                    PicturePath = model.PicturePath
                };
                return productRepository.Create(cat);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public ProductViewModel GetbyId(int Id)
        {
            var data = productRepository.GetById(Id);
            if (data != null)
            {
                return new ProductViewModel()
                {
                    Id = data.Id,
                    Name = data.Name,
                    Description = data.Description,
                    CategoryId = data.CategoryId,
                    CategoryName = data.Category == null ? "" : data.Category.Name,
                    PicturePath = data.PicturePath,
                    Price = data.Price,
                    Stock = data.Stock,
                    Units = data.Units
                };
            }
            else
            {
                return null;
            }
        }

        public (bool, string) Edit(ProductViewModel model)
        {
            try
            {
                var existing = productRepository.GetById(model.Id);
                if (existing == null) return (false, "Record not found");

                existing.Name = model.Name;
                existing.Description = model.Description;
                existing.CategoryId = model.CategoryId;
                existing.Units = model.Units;
                existing.Price = model.Price;
                existing.Stock = model.Stock;
                existing.PicturePath = model.PicturePath;

                return productRepository.Edit(existing);
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
                var existing = productRepository.GetById(id);
                if (existing == null) return (false, "Record not found");

                return productRepository.Delete(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}