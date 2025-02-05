 using System;
             
 namespace ConditionalStatements
 {
 internal class Program 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("===== Conditional Statements: if =====");
            
            int age = 20;

            if(age > 18) 
            {
                // Condition is true. The code will be executed
                Console.WriteLine("You have access");
            }

            age = 16;

            if(age > 18) 
            {
                // Condition is false. The code will not be executed
                Console.WriteLine("You have access");
            }


            Console.WriteLine("===== Conditional Statements: if - else =====");

            if(age > 18) 
            {
                // Condition is false. The code will not be executed
                Console.WriteLine("You have access");
            }
            else
            {
                Console.WriteLine("You don't have access");
            }


            Console.WriteLine("===== Conditional Statements: else if =====");
            if(age > 18) // 16 > 18 = false.
            {
                Console.WriteLine("You have access");
            } 
            else if (age >= 16 && age < 18 )// Since the first condition is false and the second one is true, this block of code will be executed.
            {
                Console.WriteLine("You have limited access");
            }
            else
            {
                Console.WriteLine("You don't have access");
            }




            Console.WriteLine("===== Conditional Statements: switch =====");
            switch (age > 18) // 16 > 18 = false.
            {
                case true:
                    Console.WriteLine("You have access");
                    break;
                case false:
                    Console.WriteLine("You don't have access");
                    break;
            }   

            Console.WriteLine("Enter a day of the week");
            string day = Console.ReadLine();

            switch(day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Work from office");
                    break;
                case "tuesday":
                    Console.WriteLine("Work from home");
                    break;
                case "wednesday":
                    Console.WriteLine("Work from home");
                    break;
                case "thursday":
                    Console.WriteLine("Work from office");
                    break;
                case "friday":
                    Console.WriteLine("Work from site");
                    break;
                default:
                    Console.WriteLine("Day off!");
                    break;
            }
        }
     }
}