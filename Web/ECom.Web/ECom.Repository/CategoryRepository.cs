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
    }
}