using System;

namespace Lambda{
    class Program{

        // Define a delegate.
        delegate int Delegado(int num1, int num2);

        static void Main(){
            //Create expresions lambda
            Action sayHello = () => Console.WriteLine("Hello World!");
            Action<string> greet = name => Console.WriteLine(name);

            sayHello();
            greet("Jose");

            Func<int, int, int> addTwo = (number1, number2) => number1 +number2;
            Console.WriteLine($"The result of add 3 and 6 is: {addTwo(3,6)}");



            // Define delegate and using a lambda expression.
            Delegado myDelegado = (int num1, int num2) => num1+num2;
            Console.WriteLine(myDelegado(3,5));

            // Define delegate icion del delegado otra vez con una funcion lambda diferente
            myDelegado = (int num1, int num2) => num1*num2;
            Console.WriteLine(myDelegado(3,5));

            
            // Using an expression lambda in an Array method
            List<int> numbers = new List<int>{1,2,3,4,5,6,7,8}; // Define an array
            List<int> numbersFiltered = numbers.FindAll(number => number > 5 );
            
            foreach(int number in numbersFiltered){
                Console.WriteLine(number);
            }

            // Using a lambda expression inside a ForEach method
            numbersFiltered.ForEach(numero => Console.WriteLine(numero));

        }
    }
}
