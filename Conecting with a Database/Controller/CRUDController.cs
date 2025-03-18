using DbConnect.Data;
using Npgsql;
using System;
using System.Collections.Generic;


namespace Crud.Controller
{
    public class CrudOperations
    {
        private NpgsqlConnection connection;

        public CrudOperations()
        {
            connection =  new DbConnection().GetConnection();
        }

        // insert
        public void InsertEmployee(string fullName, int age, string city, string email, string role)
        {
            connection.Open();
            string query = "INSERT INTO employee (full_name, age, city, email, role) VALUES (@fullName, @age, @city, @email, @role)";

            using (var cmd = new NpgsqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("fullName", fullName);
                cmd.Parameters.AddWithValue("age", age);
                cmd.Parameters.AddWithValue("city", city);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("role", role);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Empleado agregado con éxito.");
            connection.Close();
        }
        // update
        // select
        public void DisplayEmployees()
        {
            connection.Open();

            string query = "SELECT * FROM employee";

            using (var cmd = new NpgsqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
                {
                while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["full_name"]}, Age: {reader["age"]}, City: {reader["city"]}, Email: {reader["email"]}, Role: {reader["role"]}");
                    }
                }

            connection.Close();

        }

        // remove
    }
}