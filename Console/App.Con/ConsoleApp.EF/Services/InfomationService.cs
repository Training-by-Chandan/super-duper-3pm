using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.EF.Models;

namespace ConsoleApp.EF.Services
{
    public class InfomationService
    {
        private TestDbNewContext db = new TestDbNewContext();

        public List<Infomation> GetAll()
        {
            return db.Infomations.ToList();
        }

        public Infomation GetById(int Id)
        {
            return db.Infomations.Find(Id);
        }

        public bool Create(Infomation model)
        {
            try
            {
                db.Infomations.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(Infomation model)
        {
            try
            {
                var existing = GetById(model.Id);
                if (existing == null) return false;

                existing.FirstName = model.FirstName;
                existing.LastName = model.LastName;
                existing.Email = model.Email;
                existing.Country = model.Country;
                existing.Gender = model.Gender;
                existing.Ipaddress = model.Ipaddress;

                db.Infomations.Update(existing);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var existing = GetById(id);
                if (existing == null) return false;

                db.Infomations.Remove(existing);
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