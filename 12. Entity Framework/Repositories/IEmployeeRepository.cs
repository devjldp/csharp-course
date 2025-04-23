using System.Collections.Generic;
using Employees.Models;

namespace Employees.Repositories
{
    // Interface that defines the contract for employee-related data operations
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees(); // Returns a list of all employees in the database
        // Employee GetEmployeeById(int id); // Returns a single employee based on the given ID
        void AddEmployee(Employee employee); // Adds a new employee to the database
        // void UpdateEmployee(Employee employee); // Updates the data of an existing employee
        //void DeleteEmployee(int id); // Deletes an employee by their ID
    }
}