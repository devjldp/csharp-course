using System;
using Crud.Controller;

class Program
{
    static int Menu()
    {
        Console.WriteLine(@"Select an action to perform:
        
        1. Insert a new employee.
        2. Display a complete list of employees.
        3. Search and employee.
        4. Update employee's details. (Not implemented)
        5. Remove an employee.
        6. Exit");
        
        return int.Parse(Console.ReadLine());

    }

    static void DisplayEmployee(List<Dictionary<string, object>> employees)
    {
        foreach(Dictionary<string, object> employee in employees)
        {
            string key = null;
            foreach(KeyValuePair<string, object> field in employee)
            {
                key = field.Key;
                if( key == "full_name") key = "Full Name";
                
                key = Capitalize(key);
                Console.Write($"{key}: {field.Value} | ");
            }
            Console.WriteLine();
        }

    }

    static string Capitalize(string str)
    {
        if (String.IsNullOrEmpty(str))
        return "";

        str = str.ToLower();
        return Char.ToUpper(str[0]) + str.Substring(1);
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
                case 3:
                    Console.WriteLine(@"Do you want to search by id or full name
                    1. Id
                    2. Full Name");
                    string userOption = Console.ReadLine();
                    string optionQuery = null;
                    object value = null;
                    if (userOption == "1"){
                        optionQuery = "id";
                        Console.Write("Enter employee's id: ");
                        value= int.Parse(Console.ReadLine());
                    } else if(userOption == "2"){
                        optionQuery = "full_name";
                        Console.Write("Enter employee's full name: ");
                        value = Console.ReadLine();
                    }
                    
                    var results = crud.SearchEmployee(optionQuery, value) as List<Dictionary<string, object>>;
                    DisplayEmployee(results);
                    break;
                case 5:
                    Console.WriteLine("Enter the employee's id: ");
                    int id = int.Parse(Console.ReadLine());
                    crud.DeleteEmployee(id);
                    break;
                default:
                    Console.WriteLine("Option not Valid!");
                    break;

            }

            option = Menu();
        }

        Console.WriteLine("Thanks for using Jose's Software");
        
    }
}