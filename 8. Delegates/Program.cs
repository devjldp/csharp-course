using System;

namespace Delegate{

    // We create two classes that will each have only one method 
    // to display a message on the screen:
    // Welcome or farewell.

    class WelcomeMessage{
        public static void Message(){
            Console.WriteLine("Welcome to my course");
        }
    }

    class FarewellMessage{
        public static void Message(){
            Console.WriteLine("Hasta la vista baby!");
        }
    }

    class Program{
        /* We define the delegate object
        * Syntax: It can only call methods with the same structure.
            - delegate type DelegateName(parameters)
        */
        delegate void DelegateObject();

        // In this case, it has no parameters:  
        //  * This means that any method assigned to this delegate must match this signature.
        //  In other words: It must be a method that does not take arguments. 
        //  The methods we will associate with this delegate have no parameters.

        static void Main(){
            // Creating the delegate object
            DelegateObject myDelegate = new DelegateObject(WelcomeMessage.Message);
            // Parentheses are not used because we are not invoking the method,
            // we are only passing a reference to the method.
            // ======== Simplified syntax: DelegateObject myDelegate = WelcomeMessage.Message;
            
            // Using the delegate
            myDelegate();

            // Assigning a new method to this delegate
            myDelegate = FarewellMessage.Message;

            // Using the delegate.
            myDelegate();

            // Continuation: Example 2 of using a delegate

            Delegate myDelegate2 = AddTwo;
            Console.WriteLine(myDelegate2(3,5));
            myDelegate2 = MultiplyTwo;
            Console.WriteLine(myDelegate2(3,5));
        }

        // Example 2
        delegate int Delegate(int num1, int num2);
        public static int AddTwo(int num1, int num2){
            return num1 + num2;
        }

        public static int MultiplyTwo(int num1, int num2){
            return num1 * num2;
        }
    }
}

/*
Advantage:
Instead of creating two objects, we can dynamically change the method 
we want to invoke without modifying the flow.

Flow summary:
    * Definition: Declare the delegate type to define the structure 
      of the methods that can be associated.
    * Creation: Instantiate a delegate and assign it a method 
      that matches its signature.
    * Invocation: Call the delegate as if it were a method; 
      this executes the referenced method.
*/