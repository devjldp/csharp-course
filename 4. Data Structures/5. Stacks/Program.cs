Stack<int> myStack = new Stack<int>();

// Add objects
Console.WriteLine("Add elements");
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);
myStack.Push(6);
myStack.Push(7);

foreach(int number in myStack)
{
    Console.WriteLine(number);
}

// Remove the last object
Console.WriteLine("Remove elements");
myStack.Pop(); 

Console.WriteLine("Retrieve the last element without removing it");
Console.WriteLine(myStack.Peek()); // 6

Console.WriteLine("Remove all elements");
myStack.Clear();

Console.WriteLine("Check if the stack contains the number 5");
Console.WriteLine(myStack.Contains(5));