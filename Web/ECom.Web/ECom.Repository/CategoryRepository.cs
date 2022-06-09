using ECom.Models.Models;
using ECom.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Repository
{
    public interface ICategoryRepository
    {
        (bool, string) Create(Category model);

        (bool, string) Delete(Category model);

        (bool, string) Edit(Category model);

        IQueryable<Category> GetAll();

        Category? GetById(int id);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category? GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public (bool, string) Create(Category model)
        {
            try
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Category model)
        {
            try
            {
                db.Categories.Update(model);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Category model)
        {
            try
            {
                db.Categories.Remove(model);
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