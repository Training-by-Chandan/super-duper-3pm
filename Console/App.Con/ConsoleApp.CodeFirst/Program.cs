using ConsoleApp.CodeFirst.Models;
using ConsoleApp.CodeFirst.Services;

var res = "n";
do
{
    Console.Clear();
    Console.WriteLine("Press \n1 to get all records from table");
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

static void GetAll()
{
    var info = new PersonServices();
    foreach (var item in info.GetAll())
    {
        System.Console.WriteLine($"Id = {item.Id}");
        System.Console.WriteLine($"Name = {item.Name}");
        System.Console.WriteLine($"Email = {item.Email}");
        System.Console.WriteLine("=====================================================");
    }
}

static void GetById()
{
    var info = new PersonServices();
    Console.WriteLine("Enter the id");
    var id = Convert.ToInt32(Console.ReadLine());
    var item = info.GetById(id);

    try
    {
        System.Console.WriteLine($"Id = {item.Id}");
        System.Console.WriteLine($"Name = {item.Name}");
        System.Console.WriteLine($"Email = {item.Email}");
        System.Console.WriteLine("=====================================================");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Data not found");
    }
}

static void Create()
{
    var info = new PersonServices();
    var person = new PersonInfo();
    Console.WriteLine("Enter the Name");
    person.Name = Console.ReadLine();

    Console.WriteLine("Enter the Email");
    person.Email = Console.ReadLine();
    Console.WriteLine("Enter the phone number");
    person.PhoneNumber = Console.ReadLine();

    var res = info.Create(person);
}
static void Edit()
{
    var person = new PersonInfo();
    var info = new PersonServices();

    Console.WriteLine("Enter the Id");
    person.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Full Name");
    person.Name = Console.ReadLine();
    Console.WriteLine("Enter the Email");
    person.Email = Console.ReadLine();

    var res = info.Edit(person);
}

static void Delete()
{
    var info = new PersonServices();
    Console.WriteLine("Enter the Id");
    var Id = Convert.ToInt32(Console.ReadLine());

    var res = info.Delete(Id);
}