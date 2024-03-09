using _1.BookStoreApp.Models.Domain;
namespace _1.BookStoreApp.Repositories.Abstract
{
    public interface IAuthorService
    {
        bool Add(Author model);

        bool Update(Author model);

        bool Delete(int id);

        Author FindById(int id);

        IEnumerable<Author> GetAll();
    }
}
