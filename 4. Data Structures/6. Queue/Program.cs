// Create a new Queue of numbers

Queue<int> myQueue = new Queue<int>();



myQueue.Enqueue(3);
myQueue.Enqueue(4);
myQueue.Enqueue(5);
myQueue.Enqueue(6);
myQueue.Enqueue(7);


foreach(int number in myQueue)
{
    Console.WriteLine(number);
}


Console.WriteLine("Removing the first Element");

Console.WriteLine(myQueue.Dequeue());
foreach(int number in myQueue)
{
    Console.WriteLine(number);
}
 
Console.WriteLine("Retrieving the first Element without removing it");
Console.WriteLine(myQueue.Peek());
foreach(int number in myQueue)
{
    Console.WriteLine(number);
}

Console.WriteLine("Checking if the queue contains a specified element or not");
Console.WriteLine(myQueue.Contains(5)); // true


Console.WriteLine("Removing all objects from the Queue");
myQueue.Clear();

// Elements in the queue
Console.WriteLine($"Elements in the queue: {myQueue.Count}");