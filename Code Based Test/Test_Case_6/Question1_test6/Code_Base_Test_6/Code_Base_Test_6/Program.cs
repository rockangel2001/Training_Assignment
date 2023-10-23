//Test the procedure
//c. Using Ado.net classes/methods, insert employee record in the table by invoking the procedure

using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-BMQ0LQ3;Database=CodeBased_Test_6;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@empname", "Shreya Mishra");
                    command.Parameters.AddWithValue("@empsal", 12345.00);
                    command.Parameters.AddWithValue("@emptype", "F");

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Employee added successfully.");

            // Display all records
            DisplayAllEmployeeRecords(connectionString);
        }

        // Define the DisplayAllEmployeeRecords method outside of Main
        static void DisplayAllEmployeeRecords(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Code_Employee", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Employee ID: {reader["empno"]}, Name: {reader["empname"]}, Salary: {reader["empsal"]}, Type: {reader["emptype"]}");
                    }
                }
            }
        }
    }
}
