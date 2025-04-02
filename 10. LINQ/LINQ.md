# LINQ
[`LINQ`](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) Langauge Integrated Query is a technology that integrates queries directly into C#.
The main advantage is it supports multiple types of data sources.

*LINQ can be written in two different styles:*

* **[Query Syntax](#query-syntax):** Similar to SQL, often called "SQL-like syntax."
* **[Method Syntax](#method-syntax):** Uses extension methods on collections to chain different operations.

## Main operations in LINQ.

#### Method Syntax.

* [`Select()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-9.0): Projects data into a new form. It allows you to "select" specific data or shape the results of a query into a different format.  
The Select method takes a projection function and applies it to each element in the collection. 

**notes:** 
1. LINQ queries return an [`IEnumarble<T>`](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-9.0).  
2. [Deferred Execution](#deferred-execution)

*Example*:
```csharp
//// Query to select the 'Name' property from each 'Author' object in the database context and return it as an IEnumerable of strings

IEnumerable<string> authorNames = DBContext.Authors.Select(author => author.Name);

// Display names
foreach( string name in authorNames){
    Console.WriteLine(name);
}
```

In this example, we are retrieving incomplete data because we are only working with foreign keys. We'll learn how to resolve this issue by using joins to combine the related data.

```csharp
IEnumerable<string> booksSimplified = DBContext.Books.Select( book =>$"{book.Title} {book.GenreId}");

foreach( string name in booksSimplified){ // Here is where we execute the query
    Console.WriteLine(name);
}
```

* [`Where()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-9.0): Filters data based on a condition.

```csharp
IEnumerable<string> books1 = DBContext.Books.Where(book => book.AuthorId == 1).Select(book => book.Title);

foreach(string book in books1 ){
    Console.WriteLine(book);
}
```

* [`OrderBy()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-9.0), [`ThenBy()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.thenby?view=net-9.0): Sorts data.

```csharp
IEnumerable<string> booksOrderByAuthor = DBContext.Books.OrderBy(book => book.AuthorId)
    .Select(book => $"{book.Title} - {book.AuthorId}");
```

* [`GroupBy()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.groupby?view=net-9.0): Groups data by a key.

```csharp
var booksByGenre = DBContext.Books.GroupBy(book => book.GenreId);
Console.WriteLine(booksByGenre.GetType());

foreach(var group in booksByGenre){
    Console.WriteLine(group.Key);
    foreach(var book in group){
        Console.WriteLine(book.Title);
    }
}
```

* [`Join()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join?view=net-.0): Combines data from multiple collections based on a key.
```csharp
var booksJoined = DBContext.Books.Join( // Perform a join between the Books and Genres tables
    DBContext.Genres, // Table we want to join with (Genres table)
    book => book.GenreId,  // Foreign key from the Books table, referencing the GenreId
    genre => genre.Id,  // Primary key from the Genres table
    (book, genre) => new {book.Title, genre.GenreType} // Project the results after the join, creating an anonymous type that temporarily holds the book's title and its corresponding genre.
);
            
foreach(var book in booksJoined){
    Console.WriteLine($"{book.Title} - {book.GenreType}");
    // Console.WriteLine(book); output: { Title = Chronicle of a Death Foretold, GenreType = Fiction }
}
```

* [`Take()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take?view=net-9.0), [`Skip()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=net-9.0): Controls the amount of data returned.

* [`Aggregate()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate?view=net-9.0), [`Sum()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=net-9.0), [`Count()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=net-9.0), [`Min()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min?view=net-9.0), [`Max()`](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max?view=net-9.0): Performs calculations on data.

---
#### Query Syntax.
* `Select`:

```csharp
IEnumerable<string> booksTitles = 
    from book in DBContext.Books
    select book.Title;
            
foreach(string title in booksTitles){
    Console.WriteLine(title);
}
```

Note: If we want to select miultiple columns, we need to project the results into an anonymus type.
* `where`:
```csharp
var booksTitleByAuthor =
    from book in DBContext.Books
    where book.AuthorId == 1
    select new
    {
        book.Id,
        book.Title,
    };
foreach(var book in booksTitleByAuthor){
    Console.WriteLine($"Book: {book.Id} - {book.Title}");
}
```

* `Join`:
```csharp
var booksWithDetails2 =
    from book in DBContext.Books
    join genre in DBContext.Genres on book.GenreId equals genre.Id
    join author in DBContext.Authors on book.AuthorId equals author.Id
    select new
    {
        book.Title,
        author.Name,
        genre.GenreType
    };

// Display results
foreach (var book in booksWithDetails2)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GenreType}");
} 
```


---
#### Deferred execution

Deferred execution in LINQ refers to the concept where the query is not actually executed when it is defined, but rather when it is iterated over or accessed.  
This means that the results of the query are not fetched or calculated until you explicitly request them, such as by iterating through the results with a foreach loop or calling a method like ToList() or ToArray().

*Example:*
```csharp
IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// LINQ query using Select
IEnumerable<int> squaredNumbers = numbers.Select(n => n * n);

// At this point, no numbers are squared yet
Console.WriteLine("Query Defined");

// Now, we execute the query and see the results
foreach (int squared in squaredNumbers)
{
    Console.WriteLine(squared);
}
```