using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Data;
using WindowsFormsApp.Models;
using System.Data.Entity;

namespace WindowsFormsApp.Services
{
    public class StudentServices
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<StudentInfo> GetAll() => db.StudentInfos.ToList();

        public StudentInfo GetById(int id) => db.StudentInfos.Find(id);

        public (bool, string) Create(StudentInfo model)
        {
            try
            {
                db.StudentInfos.Add(model);
                db.SaveChanges();
                return (true, "Addedd successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(StudentInfo model)
        {
            try
            {
                var existing = GetById(model.Id);
                if (existing == null) return (false, "Not found");

                existing.Name = model.Name;
                existing.Email = model.Email;

                db.Entry(existing).State = EntityState.Modified;
                db.SaveChanges();
                return (true, "updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int Id)
        {
            try
            {
                var existing = GetById(Id);
                if (existing == null) return (false, "Not found");

                db.StudentInfos.Remove(existing);
                db.SaveChanges();
                return (true, "Deleted successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}