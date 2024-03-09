using _1.BookStoreApp.Models.Domain;
using _1.BookStoreApp.Repositories.Abstract;


namespace _1.BookStoreApp.Repositories.Implementation
{
    public class BookService : IBookService
    {
        private readonly DatabaseContext context;
        public BookService(DatabaseContext context)
        {
            this.context = context;
        }
        public bool Add(Book model)
        {
            try
            {
                context.Books.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Books.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Book FindById(int id)
        {
            return context.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            var data = (from Book in context.Books
                        join Author in context.Authors
                        on Book.AuthorId equals Author.Id
                        join Publisher in context.Publishers on Book.PublisherId equals Publisher.Id
                        join Genre in context.Genres on Book.GenreId equals Genre.Id
                        select new Book
                        {
                            Id = Book.Id,
                            AuthorId = Book.AuthorId,
                            GenreId = Book.GenreId,
                            Isbn = Book.Isbn,
                            PublisherId = Book.PublisherId,
                            Title = Book.Title,
                            TotalPages = Book.TotalPages,
                            GenreName = Genre.Name,
                            AuthorName = Author.AuthorName,
                            PublisherName = Publisher.PublisherName
                        }
                        ).ToList();
            return data;
        }

        public bool Update(Book model)
        {
            try
            {
                context.Books.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}