using ConsoleApp.EF.Models;
using ConsoleApp.EF.Services;
using System;

namespace ConsoleApp.EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                Console.Clear();
                Console.WriteLine("Press \n1 to get all resords from table");
                Console.WriteLine("2 to get by Id");
                Console.WriteLine("3 to create record");
                Console.WriteLine("4 to edit record");
                Console.WriteLine("5 to delete record");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetAll();
                        break;

                    case 2:
                        GetById();
                        break;

                    case 3:
                        Create();
                        break;

                    case 4:
                        Edit();
                        break;

                    case 5:
                        Delete();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static InfomationService info = new InfomationService();

        private static void GetAll()
        {
            foreach (var item in info.GetAll())
            {
                System.Console.WriteLine($"Id = {item.Id}");
                System.Console.WriteLine($"Full Name = {item.FirstName} {item.LastName}");
                System.Console.WriteLine($"Email = {item.Email}");
                System.Console.WriteLine("=====================================================");
            }
        }

        private static void GetById()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());
            var item = info.GetById(id);

            try
            {
                System.Console.WriteLine($"Id = {item.Id}");
                System.Console.WriteLine($"Full Name = {item.FirstName} {item.LastName}");
                System.Console.WriteLine($"Email = {item.Email}");
                System.Console.WriteLine("=====================================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data not found");
            }
        }

        private static void Create()
        {
            var infomation = new Infomation();
            Console.WriteLine("Enter the First Name");
            infomation.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            infomation.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            infomation.Email = Console.ReadLine();

            var res = info.Create(infomation);
        }

        private static void Edit()
        {
            var infomation = new Infomation();
            Console.WriteLine("Enter the Id");
            infomation.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First Name");
            infomation.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            infomation.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            infomation.Email = Console.ReadLine();

            var res = info.Edit(infomation);
        }

        private static void Delete()
        {
            Console.WriteLine("Enter the Id");
            var Id = Convert.ToInt32(Console.ReadLine());

            var res = info.Delete(Id);
        }
    }
}