using System.Text.RegularExpressions;
using Linq.Models;
using LinqDbContext;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Method Syntax
            // Select all authors only name
            // Here we define the query.
            IEnumerable<string> authorNames = DBContext.Authors.Select(author => author.Name); // Query to select the 'Name' property from each 'Author' object in the database context and return it as an IEnumerable of strings

            foreach( string name in authorNames){ // Here is where we execute the query
                Console.WriteLine(name);
            }

            // select all books only title and genre

            IEnumerable<string> booksSimplified = DBContext.Books.Select( book =>$"{book.Title} {book.GenreId}");

             foreach( string name in booksSimplified){ // Here is where we execute the query
                Console.WriteLine(name);
             }

            // Filter: Select all books with authorID = 1
            IEnumerable<string> books1 = DBContext.Books.Where(book => book.AuthorId == 1).Select(book => book.Title);

            foreach(string book in books1 ){
                Console.WriteLine(book);
            }
            
            // order by

            IEnumerable<string> booksOrderByAuthor = DBContext.Books.OrderBy(book => book.AuthorId).Select(book => $"{book.Title} - {book.AuthorId}");

            foreach(string book in booksOrderByAuthor)
            {
                Console.WriteLine(book);
            }


            // Descending order
            Console.WriteLine("Descending order");
            IEnumerable<string> booksOrderByAuthorDesc = DBContext.Books.OrderByDescending(book => book.AuthorId).Select(book => $"{book.Title} - {book.AuthorId}");

            foreach(string book in booksOrderByAuthorDesc)
            {
                Console.WriteLine(book);
            }

            // Group by genre
            var booksByGenre = DBContext.Books.GroupBy(book => book.GenreId);
            Console.WriteLine(booksByGenre.GetType());

            foreach(var group in booksByGenre){
                Console.WriteLine(group.Key);
                foreach(var book in group){
                    Console.WriteLine(book.Title);
                }
            }
            // Distinct
            Console.WriteLine("Genre List");
            IEnumerable<string> genderList = DBContext.Genres.Select(genre => genre.GenreType).Distinct();
            foreach(var genre in genderList){
                Console.WriteLine(genre);
            }

            // select all books only title and genre We are going to join two tables

            var booksJoined = DBContext.Books.Join( // Perform a join between the Books and Genres tables
                DBContext.Genres, // Table we want to join with (Genres table)
                book => book.GenreId,  // Foreign key from the Books table, referencing the GenreId
                genre => genre.Id,  // Primary key from the Genres table
                (book, genre) => new {book.Title, genre.GenreType} // Project the results after the join, creating an anonymous type that temporarily holds the book's title and its corresponding genre.
            );
            
            foreach(var book in booksJoined){
                Console.WriteLine($"{book.Title} - {book.GenreType}");
                Console.WriteLine(book);
            }

            // Select all books only title, genre and author. We are going to join three tables.
            // Using method syntax

            var booksWithDetails = DBContext.Books
                .Join(DBContext.Genres,             // First join with Genres table
                    book => book.GenreId,          // Foreign key in Books
                    genre => genre.Id,             // Primary key in Genres
                    (book, genre) => new { book, genre }) // Temporary result
                .Join(DBContext.Authors,            // Second join with Authors table
                    temp => temp.book.AuthorId,    // Foreign key in Books
                    author => author.Id,           // Primary key in Authors
                    (temp, author) => new          // Final result projection
                    {
                        temp.book.Title,           // Book Title
                        author.Name,               // Author Name
                        temp.genre.GenreType       // Genre Type
                    });

            // Display results
            Console.WriteLine("Books with Details");
            foreach (var book in booksWithDetails)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GenreType}");
            }   

            // using Query Syntax
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


            // More Query Syntax
            // Select all titles of the book.
            IEnumerable<string> booksTitles = 
                from book in DBContext.Books
                select book.Title;
            
            foreach(string title in booksTitles){
                Console.WriteLine(title);
            }

            // Filter
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


            // Select only titles which start with T and A

            IEnumerable<string> titlesSelected = DBContext.Books
                .Where(book => book.Title.StartsWith('T') || book.Title.StartsWith('A'))
                .Select(book => book.Title);
            Console.WriteLine("========== Books Selected ==========");
            Console.WriteLine($"Number of Books: {titlesSelected.Count()}");
            foreach(string title in titlesSelected)
            {
                Console.WriteLine(title);
            }
        }
    }

}
