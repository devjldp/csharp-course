// import the namespace DbConnect.Data from the file DBConnection.cs
using DbConnect.Data; 
using Npgsql;
using System;
using System.Collections.Generic;


namespace Crud.Controller
{
    public class CrudOperations
    {
        private NpgsqlConnection _connection;

        public CrudOperations()
        {
            _connection =  new DbConnection().GetConnection();
        }

        // insert
        public void InsertEmployee(string fullName, int age, string city, string email, string role)
        {
            _connection.Open();

            // Define the query
            string query = "INSERT INTO employee (full_name, age, city, email, role) VALUES (@fullName, @age, @city, @email, @role)";

            // Create a SQL command
            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("fullName", fullName);
                cmd.Parameters.AddWithValue("age", age);
                cmd.Parameters.AddWithValue("city", city);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("role", role);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Employee added.");
            _connection.Close();
        }

        // update
        // select all employees
        public void DisplayEmployees()
        {
            _connection.Open();

            string query = "SELECT * FROM employee";

            using (var cmd = new NpgsqlCommand(query, _connection))
            using (var reader = cmd.ExecuteReader())
                {
                while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]} | Name: {reader["full_name"]} | Age: {reader["age"]} | City: {reader["city"]} | Email: {reader["email"]} | Role: {reader["role"]}");
                    }
                }

            _connection.Close();

        }

        // select by option
        public object SearchEmployee(string option, object value)
        {
            _connection.Open();

            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            string query = $"SELECT * FROM employee WHERE {option} = {value}";

            using(var cmd = new NpgsqlCommand(query, _connection))
            using(var reader = cmd.ExecuteReader())
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                
                while (reader.Read())
                {
                    // Iterate over all columns of the current row and store the column name as the key and the cell value as the value
                    for(int i=0; i < reader.FieldCount; i++)
                    {
                        data[reader.GetName(i)] = reader.GetValue(i);
                    }
                    results.Add(data);
                }
            }
           
            _connection.Close();

            return results;
        }

        // remove
        public void DeleteEmployee(int id)
        {
            _connection.Open();

            string query = "DELETE FROM employee WHERE id = @id";
            using(var cmd = new NpgsqlCommand(query, _connection))
            {
               cmd.Parameters.AddWithValue("id", id);
               cmd.ExecuteNonQuery();
            }
            Console.WriteLine($"Employee with ID: {id} has been removed");
            _connection.Close();
        }
    }
}