// Creating a new dictionary
Dictionary<string, int> ages = new Dictionary<string, int>{
    {"Tom", 34},
    {"Bob", 56},
    {"Charlie", 34},
    {"Sarah", 29}
};

// Get keys and values
foreach(KeyValuePair<string, int> data in ages)
{
    Console.WriteLine($"Key: {data.Key} - Value: {data.Value}");
}

// ===== Properties ======
// Retrieve all keys and vlaues.
List<string> names = ages.Keys.ToList();
foreach (string name in names)
{
    Console.WriteLine($"Name: {name}");
}

List<int> peopleAges = ages.Values.ToList();
foreach (int age in peopleAges)
{
    Console.WriteLine($"Age: {age}");
}

// Get the number of elements
Console.WriteLine($"Number of elements: {ages.Count}");


// ====== Methods ======
// Add a new eleemnt
ages.Add("Ruben", 30);
foreach(KeyValuePair<string, int> data in ages)
{
    Console.WriteLine($"Key: {data.Key} - Value: {data.Value}");
}

// contains key
Console.WriteLine(ages.ContainsKey("Ruben"));

// Contains value
Console.WriteLine(ages.ContainsValue(25));

// Remove an element
ages.Remove("Bob");
foreach(KeyValuePair<string, int> data in ages)
{
    Console.WriteLine($"Key: {data.Key} - Value: {data.Value}");
}