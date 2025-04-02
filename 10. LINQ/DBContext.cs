using Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqDbContext
{
    public static class DBContext
    {
        public static List<Book> Books { get; set; }
        public static List<Genre> Genres { get; set; }
        public static List<Author> Authors { get; set; }

        static DBContext()
        {

            Authors =
            [
                new Author { Id = 1, Name = "Gabriel García Márquez", Country = "Colombia" },
                new Author { Id = 2, Name = "J.K. Rowling", Country = "United Kingdom" },
                new Author { Id = 3, Name = "Haruki Murakami", Country = "Japan" },
                new Author { Id = 4, Name = "George Orwell", Country = "United Kingdom" },
                new Author { Id = 5, Name = "Isabel Allende", Country = "Chile" }
            ];

            Genres =
            [
                new Genre { Id = 1, GenreType = "Fiction" },
                new Genre { Id = 2, GenreType = "Fantasy" },
                new Genre { Id = 3, GenreType = "Drama" },
                new Genre { Id = 4, GenreType = "Dystopian" },
                new Genre { Id = 5, GenreType = "Historical Fiction" }
            ];

            Books =
            [
                new Book { Id = 1, Title = "One Hundred Years of Solitude", AuthorId = 1, GenreId = 1 },
                new Book { Id = 2, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 2, GenreId = 2 },
                new Book { Id = 3, Title = "Norwegian Wood", AuthorId = 3, GenreId = 3 },
                new Book { Id = 4, Title = "1984", AuthorId = 4, GenreId = 4 },
                new Book { Id = 5, Title = "The House of the Spirits", AuthorId = 5, GenreId = 5 },
                new Book { Id = 6, Title = "Love in the Time of Cholera", AuthorId = 1, GenreId = 1 },
                new Book { Id = 7, Title = "The Casual Vacancy", AuthorId = 2, GenreId = 2 },
                new Book { Id = 8, Title = "Kafka on the Shore", AuthorId = 3, GenreId = 3 },
                new Book { Id = 9, Title = "Animal Farm", AuthorId = 4, GenreId = 4 },
                new Book { Id = 10, Title = "The Infinite Plan", AuthorId = 5, GenreId = 5 },
                new Book { Id = 11, Title = "Chronicle of a Death Foretold", AuthorId = 1, GenreId = 1 },
                new Book { Id = 12, Title = "Fantastic Beasts and Where to Find Them", AuthorId = 2, GenreId = 2 },
                new Book { Id = 13, Title = "After Dark", AuthorId = 3, GenreId = 3 },
                new Book { Id = 14, Title = "Homage to Catalonia", AuthorId = 4, GenreId = 4 },
                new Book { Id = 15, Title = "Of Love and Shadows", AuthorId = 5, GenreId = 5 }
            ];
        }
    }
}