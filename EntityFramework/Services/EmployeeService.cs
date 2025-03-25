using System.Collections.Generic;
using System.Linq;
using EntityFramework.Data;
using EntityFramework.Models;

namespace EntityFramework.Services
{
    public class EmployeeService
    {
        private readonly EmployeeContext _context;

        // Constructor que recibe el contexto de empleados
        public EmployeeService(EmployeeContext context)
        {
            _context = context; // Asigna el contexto al campo privado
        }

        // Crear un nuevo empleado
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee); // Uso de 'Employees' en vez de 'Employee'
            _context.SaveChanges(); // Guardar cambios de forma síncrona
        }

        // Obtener todos los empleados
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList(); // Uso de 'Employees' en vez de 'Employee'
        }

        // Obtener un empleado por su ID
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id); // Uso de 'Employees' en vez de 'Employee'
        }

        // Actualizar un empleado
        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee); // Uso de 'Employees' en vez de 'Employee'
            _context.SaveChanges(); // Guardar cambios de forma síncrona
        }

        // Eliminar un empleado
        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id); // Uso de 'Employees' en vez de 'Employee'
            if (employee != null)
            {
                _context.Employees.Remove(employee); // Uso de 'Employees' en vez de 'Employee'
                _context.SaveChanges(); // Guardar cambios de forma síncrona
            }
        }
    }
}
