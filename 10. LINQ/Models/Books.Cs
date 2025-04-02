   namespace Linq.Models
   {
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }

            // (Foreign Keys)
            public int AuthorId { get; set; }
            public int GenreId { get; set; }
        }
}