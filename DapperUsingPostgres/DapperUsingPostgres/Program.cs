using Dapper;
using Npgsql;
using System;
using System.Linq;

namespace DapperUsingPostgres
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=18092000;Database=TimeManagement")) 
            { 
                connection.Open(); 
                connection.Execute("Insert into Employee (first_name, last_name, address) values ('John', 'Smith', '123 Duane St');"); 
                var value = connection.Query("Select first_name from Employee;");
                Console.WriteLine(value.First()); 
            }
            Console.Read(); 
    }
}
}
