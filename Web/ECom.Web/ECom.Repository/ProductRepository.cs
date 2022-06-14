using ECom.Models.Models;
using ECom.Web.Data;

namespace ECom.Repository
{
    public interface IProductRepository
    {
        (bool, string) Create(Product model);

        (bool, string) Delete(Product model);

        (bool, string) Edit(Product model);

        IQueryable<Product> GetAll();

        Product? GetById(int id);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Product> GetAll()
        {
            return db.Products;
        }

        public Product? GetById(int id)
        {
            return db.Products.Find(id);
        }

        public (bool, string) Create(Product model)
        {
            try
            {
                db.Products.Add(model);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Product model)
        {
            try
            {
                db.Products.Update(model);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Product model)
        {
            try
            {
                db.Products.Remove(model);
                db.SaveChanges();
                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}