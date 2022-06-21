using AutoMapper;
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
        private readonly IMapper mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public List<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll().ToList();

            var ret = mapper.Map<List<Product>, List<ProductViewModel>>(data);

            return ret.ToList();
        }

        public (bool, string) Create(ProductViewModel model)
        {
            try
            {
                var product = mapper.Map<ProductViewModel, Product>(model);

                return productRepository.Create(product);
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
                return mapper.Map<Product, ProductViewModel>(data);
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

                existing = mapper.Map<ProductViewModel, Product>(model, existing);

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