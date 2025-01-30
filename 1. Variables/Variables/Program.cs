 using System;
             
 namespace Variables
 {
 internal class Program 
    {
        static void Main(string[] args)
         {
             Console.WriteLine("hello world!");
            // Creating my first variable

            // string fullName = 'Jose'; No => ' ' is used for characters
            string fullName = "Jose"; // OK

            // ====== Types ======
            // In the following example, I use two literals of type int: 12 and 30
            // Declaring a variable of type int: x
            int x = 12 * 30;
            Console.WriteLine(x);
            
            // Reassing value
            x = 1_000_000;
            Console.WriteLine(x);

            // Getting the type of the variable x
            Console.WriteLine(x.GetType()); // Output: System.Int32

            // float myFloat = 4.7; Output: error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type

            float myFloat = 4.7f;
            Console.WriteLine(myFloat);


            // numeric conversion
            x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integral type
            short z = (short)x; // Explicit conversion to 16-bit integral type


            // Interacting with the console
            fullName = Console.ReadLine();
            Console.WriteLine(fullName);

            // String interpolation   

            Console.WriteLine("Hello" + fullName); // No space
            Console.WriteLine("Hello " + fullName); // Space after Hello 

            Console.WriteLine("Introduce your age");
            int age = int.Parse(Console.ReadLine()); // Read the input from the user and convert it to an integer
            Console.WriteLine($"I am {age} years old."); // Display the age entered by the user

          }
     }
}
