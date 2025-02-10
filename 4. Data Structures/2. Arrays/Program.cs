// Create an array of strings
string[] fruits = {"Apple", "Banana", "Orange", "Mango"};

foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Create an array of numbers
int[] numbers = new int[] {7, 1, 2, 5};

foreach(int number in numbers)
{
    Console.WriteLine(number);
}


// Defining a two dimension array
int[,] matrix = new int[4,3]{{2,3,5}, {4,5,6}, {7,8,9}, {1,3,5}};

// Properties

Console.WriteLine(matrix.Length); // 12 elements
Console.WriteLine(matrix.Rank); // 2

// Methods
// Fill
int[] myArray = new int[25];
Array.Fill(myArray, 6); // Fills an array of 25 elements with value 6

foreach (int number in myArray)
{
    Console.Write($"{number} "); // 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6
}

Console.WriteLine();
Array.Fill(myArray,3,5,9);

foreach (int number in myArray)
{
    Console.Write($"{number} "); // 6 6 6 6 6 3 3 3 3 3 3 3 3 3 6 6 6 6 6 6 6 6 6 6 6
}

Console.WriteLine();
Console.WriteLine(matrix.GetLength(0)); // Returns the number of rows.
Console.WriteLine(matrix.GetLength(1)); // Returns the number of rows.

// Clear an array
Array.Clear(matrix);

foreach (int row in matrix)
{
    Console.Write($"{row} "); // 6 6 6 6 6 3 3 3 3 3 3 3 3 3 6 6 6 6 6 6 6 6 6 6 6
}