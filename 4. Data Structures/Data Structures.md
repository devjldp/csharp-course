# Data Structures

Data structures are a way of organizing and storing data.

![imag](images/dataStructures.jpeg)


## Content
1. [Lists](#lists)
2. [Arrays](#arrays)
3. [Linked Lists](#linked-list)
4. [Dictionaries](#dictionaries)
5. [Stacks](#stacks)
6. [Queues](#queues)
7. [Hash Tables](#hash-tables)
8. [Trees](#trees)
9. [Graphs](#graphs)


### Lists

A list in C# is an **ordered collection** of objects. It is a predefined class in the .NET framework, and objects in the list must be of a specified type, such as string, int, etc.  
One of the key features of a list is that it is a `dynamic` data structure, meaning its size can grow or shrink as elements are added or removed.  
This flexibility makes it a powerful tool for handling data collections. Additionally, lists provide various methods to manipulate data, such as adding, removing, and searching for elements, making them ideal for use in many programming scenarios.



Since List is a `class` (you can read the official documentation [here](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0)), we need to create an `instance` of the class to use it. This involves declaring a variable of type `List<T>`, where *T* represents the type of elements the list will hold, and then initializing the list.

**Note:** We will cover the topic of Object-Oriented Programming (OOP) soon, which will help explain how classes and objects work in more detail.

```csharp
// Creating an object of type List (instance of the List class)
List<string> fruits = new List<string>(); // Initialize an empty list

// Creating an object with default values
List<int> numbers = new List<int>{2, 3, 4, 5, 6, 7, 8} // Initialize a list with values
```

We can access to a single elment by its index. The first element in a list has a index = 0.

```csharp
numbers[0] // 2
numbers[1] // 3
number[3] // 5
```
If we want to display the elements of the list we can use a for loop with the `List` *property* `.Count`
```csharp
for(int index = 0; index < numbers.Count; index++) 
{
    Console.WriteLine(numbers[index]); // Display all elements in the list
}
```
**Note:** Count gets the number of elements in the list.

There is a different syntax to iterate over a list. Using the [`foreach`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement) loop.
`foreach` execute a statement or block of statements *for each element* in the list.

```csharp
foreach(int number in numbers) //iterates through each element in the list "numbers"
{
    Console.WriteLine(number);
}
```

#### List Methods

The main methods that we are going to cover are:

**Note:** For the rest of methods check the [documentation](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0#methods)


**Add():** if we want to add an object to the end of the List.

```csharp
fruits.Add("Apple"); // Adds the string Apple to the list.
```

**Contains(element):** Check if the element is in the list or not. Returns true or false
```csharp
Console.WriteLine(fruits.Contains("Apple")); // Displays True
Console.WriteLine(fruits.Contains("Banana")); // Displays False
```

**IndexOf(element):** Returns the index of the first occurence of the element. If the element is not in the list returns `-1`
```csharp
fruits.IndexOf("Apple"); // returns 0
fruits.IndexOf("Banana"); // returns -1
```
**LastIndexOf(element):** Returns the index of the last occurence of the element. If the element is not in the list returns `-1`  

**Remove(element):** Remove the first element occurrence in the list. Returns true if the element is removed and false if the element is not removed.  
Imagine we have a list with the following elements: `Apple`, `Banana`, `Strawberry`, `Orange`, `Mango`

```csharp
fruits.Remove("Banana"); // Now the elements in the list are: "Apple", "Strawberry", "Orange", "Mango"
```

**RemoveAt(index):** Remove the element at the specified index.
```csharp
fruits.Remove(2); // Remove the element in the index 2. Now the elements in the list are: "Apple", "Strawberry", "Orange", "Mango"
```

**Reverse():** Reverses the order of the elements in the List.
```csharp
fruits.Reverse();
```

**Clear():** Removes all elements in the list
```csharp
fruits.Clear();
```

### Arrays
### Linked List
### Dictionaries
### Stacks
### Queues
### Hash Tables
### Trees
### Graphs
