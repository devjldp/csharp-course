Console.WriteLine("======= Lists =======");
// Creating an object of type List (instance of the List class)
List<string> fruits = new List<string>(); // Initialize an empty list

// Creating an object with default values
List<int> numbers = new List<int>{2, 3, 4, 5, 6, 7, 8}; // Initialize a list with values

// Access an element by its index
Console.WriteLine("Access to an element using its index");
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[3]);


Console.WriteLine("Using a for loop to display all elements in the list");
for(int index = 0; index < numbers.Count; index++) 
{
    Console.WriteLine(numbers[index]); 
}


foreach(int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("======= List Methods ======");
fruits.Add("Apple"); // Add a new element
Console.WriteLine(fruits.Contains("Apple")); // Displays True
Console.WriteLine(fruits.Contains("Banana")); // Displays False

Console.WriteLine(fruits.IndexOf("Apple"));
Console.WriteLine(fruits.IndexOf("Banana"));

fruits.Add("Banana");
fruits.Add("Strawberry");
fruits.Add("Orange");
fruits.Add("Mango");

Console.WriteLine("Fruit List before removing Banana");
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}

fruits.Remove("Banana"); 

Console.WriteLine("Fruit List after removing Banana");
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}


Console.WriteLine("Fruit List before removing the element at the index 2 (Orange)");
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}
fruits.RemoveAt(2); 

Console.WriteLine("Fruit List after removing the element at the index 2 (Orange)");
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}


Console.WriteLine("Reversing the order of the elements in the list");
fruits.Reverse();
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}


Console.WriteLine("Removing all elements in the list");
fruits.Clear();
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}