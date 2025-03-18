using System;
using Crud.Controller;

class Program
{
    static int Menu()
    {
        Console.WriteLine(@"Select an action to perform:
        
        1. Insert a new employee.
        2. Display a complete list of employees.
        3. Search and employee. (Not implemented)
        4. Update employee's details. (Not implemented)
        5. Remove an employee. (Not implemented)
        6. Exit");
        
        return int.Parse(Console.ReadLine());

    }
    static void Main()
    {

        Console.WriteLine("Welcome to Employee Database."); 
        int option = Menu();
        
        // Create a new instance of CRUDOperations
        CrudOperations crud = new CrudOperations();
        
        while(option != 6)
        {
            switch(option)
            {
                case 1:
                    // user data
                    Console.Write("Full Name: ");
                    string fullName = Console.ReadLine();

                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Role: ");
                    string role = Console.ReadLine(); 
                    crud.InsertEmployee(fullName,age,city,email,role);
                    break;

                case 2:
                    crud.DisplayEmployees();
                    break;
            }

            option = Menu();
        }

        Console.WriteLine("Thanks for using Jose's Software");
    /*
        // Pedir datos al usuario
        


        // Insertar en la base de datos

    */
        

        // c
        
    }
}