using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = @"Server=PSILENL084;Database=adonet;Trusted_Connection=True;";
        string query = "SELECT Id, Name, Age FROM Students";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server database");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Id\tName\tAge");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         
                        string name = reader.GetString(1);   
                        int age = reader.GetInt32(2);       

                        Console.WriteLine($"{id}\t{name}\t{age}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
