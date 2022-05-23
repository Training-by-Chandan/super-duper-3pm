using System;

namespace ConsoleApp.Data
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
                DbConnector db = new DbConnector();
                switch (choice)
                {
                    case 1:
                        db.GetAll();
                        break;

                    case 2:
                        db.GetById();
                        break;

                    case 3:
                        db.Create();
                        break;

                    case 4:
                        db.Edit();
                        break;

                    case 5:
                        db.Delete();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }
    }
}