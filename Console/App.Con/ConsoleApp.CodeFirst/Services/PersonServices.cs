using ConsoleApp.CodeFirst.Data;
using ConsoleApp.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CodeFirst.Services
{
    public class PersonServices
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<PersonInfo> GetAll()
        {
            return db.PersonInfos.ToList();
        }

        public PersonInfo GetById(int Id)
        {
            return db.PersonInfos.Find(Id);
        }

        public bool Create(PersonInfo model)
        {
            try
            {
                db.PersonInfos.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(PersonInfo model)
        {
            try
            {
                var existing = db.PersonInfos.Find(model.Id);
                if (existing == null) return false;
                existing.Name = model.Name;
                existing.Email = model.Email;
                db.PersonInfos.Update(existing);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var existing = db.PersonInfos.Find(Id);
                if (existing == null) return false;

                db.PersonInfos.Remove(existing);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}