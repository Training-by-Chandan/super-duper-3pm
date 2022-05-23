using System;
using System.Data.SqlClient;

namespace ConsoleApp.Data
{
    public class DbConnector
    {
        private string conString = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=TestDbNew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void GetAll()
        {
            //1 Create a connection object
            SqlConnection con = new SqlConnection(conString);
            //2. Create a query to run
            string query = "select * from infomation";
            //3. Create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //4. open the connection
            con.Open();
            //5. execute the command
            var result = cmd.ExecuteReader();
            //6. Process the result
            while (result.Read())
            {
                System.Console.WriteLine($"Id = {result.GetFieldValue<int>(0)}");
                System.Console.WriteLine($"Full Name = {result.GetFieldValue<string>(1)} {result.GetFieldValue<string>(2)}");
                System.Console.WriteLine($"Email = {result.GetFieldValue<string>(3)}");
                System.Console.WriteLine("=====================================================");
            }

            //7. close the connection
            con.Close();
        }

        public void GetById()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());
            //1 Create a connection object
            SqlConnection con = new SqlConnection(conString);
            //2. Create a query to run
            string query = $"select * from infomation where id='{id}'";
            //3. Create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //4. open the connection
            con.Open();
            //5. execute the command
            var result = cmd.ExecuteReader();
            //6. Process the result
            while (result.Read())
            {
                System.Console.WriteLine($"Id = {result.GetFieldValue<int>(0)}");
                System.Console.WriteLine($"Full Name = {result.GetFieldValue<string>(1)} {result.GetFieldValue<string>(2)}");
                System.Console.WriteLine($"Email = {result.GetFieldValue<string>(3)}");
                System.Console.WriteLine("=====================================================");
            }

            //7. close the connection
            con.Close();
        }

        public void Create()
        {
            Console.WriteLine("Enter the First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();
            //1 Create a connection object
            SqlConnection con = new SqlConnection(conString);
            //2. Create a query to run
            string query = $"insert into infomation (FirstName, LastName, Email) values ('{firstName}','{lastName}','{email}')";
            //3. Create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //4. open the connection
            con.Open();
            //5. execute the command
            var result = cmd.ExecuteNonQuery();
            //6. Process the result

            //7. close the connection
            con.Close();
        }

        public void Edit()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();
            //1 Create a connection object
            SqlConnection con = new SqlConnection(conString);
            //2. Create a query to run
            string query = $"update infomation set firstName ='{firstName}',lastname='{lastName}',email='{email}' where id='{id}'";
            //3. Create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //4. open the connection
            con.Open();
            //5. execute the command
            var result = cmd.ExecuteNonQuery();
            //6. Process the result

            //7. close the connection
            con.Close();
        }

        public void Delete()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();

            //1 Create a connection object
            SqlConnection con = new SqlConnection(conString);
            //2. Create a query to run
            string query = $"delete from infomation where id='{id}'";
            //3. Create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //4. open the connection
            con.Open();
            //5. execute the command
            var result = cmd.ExecuteNonQuery();
            //6. Process the result

            //7. close the connection
            con.Close();
        }
    }
}