using ECom.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECom.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            SeedRoles(builder);
            SeedUsers(builder);
            SeedUserRole(builder);
        }

        //seed roles
        private void SeedRoles(ModelBuilder builder)
        {
            var adminRole = new IdentityRole()
            {
                Id = "0a75caa2-88e6-43e0-90c9-e47d96becd21",
                ConcurrencyStamp = "587575f7-ea6d-4882-a2b8-54a7c71ec3f7",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            var employeeRole = new IdentityRole()
            {
                Id = "2af27e81-088b-459a-9c1b-382ff2cba5b6",
                ConcurrencyStamp = "7ecfe4ae-826a-4eff-9b29-584adc4fdd59",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            };

            builder.Entity<IdentityRole>().HasData(adminRole, employeeRole);
        }

        //seed  user
        private void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser()
            {
                Id = "77b3cd96-0821-410b-a240-ce7f2a356d44",
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                NormalizedUserName = "admin@admin.com".ToUpper(),
                NormalizedEmail = "admin@admin.com".ToUpper(),
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "ba159e3d-44f8-4b3b-9aa6-877e0a3a77e6"
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@123");

            var employeeUser = new IdentityUser()
            {
                Id = "f49467fd-3fdb-4d9f-8bff-f676f2606cd6",
                UserName = "employee@employee.com",
                Email = "employee@employee.com",
                NormalizedUserName = "employee@employee.com".ToUpper(),
                NormalizedEmail = "employee@employee.com".ToUpper(),
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "d28844de-e5fb-434d-998c-f5c38d818394"
            };
            employeeUser.PasswordHash = hasher.HashPassword(employeeUser, "Employee@123");

            builder.Entity<IdentityUser>().HasData(adminUser, employeeUser);
        }

        //seed users roles
        private void SeedUserRole(ModelBuilder builder)
        {
            var adminUserRole = new IdentityUserRole<string>() { RoleId = "0a75caa2-88e6-43e0-90c9-e47d96becd21", UserId = "77b3cd96-0821-410b-a240-ce7f2a356d44" };
            var employeeUserRole = new IdentityUserRole<string>() { RoleId = "2af27e81-088b-459a-9c1b-382ff2cba5b6", UserId = "f49467fd-3fdb-4d9f-8bff-f676f2606cd6" };

            builder.Entity<IdentityUserRole<string>>().HasData(adminUserRole, employeeUserRole);
        }
    }
}