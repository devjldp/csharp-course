using System;
using Crud.Controller;

class Program
{
    static void Main()
    {
    /*
        // Pedir datos al usuario
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


        // Insertar en la base de datos

    */
        CrudOperations crud = new CrudOperations();

        // crud.InsertEmployee(fullName,age,city,email,role);
        crud.DisplayEmployees();
    }
}