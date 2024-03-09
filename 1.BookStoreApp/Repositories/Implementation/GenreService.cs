using _1.BookStoreApp.Models.Domain;
using _1.BookStoreApp.Repositories.Abstract;

namespace _1.BookStoreApp.Repositories.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly DatabaseContext context;

        public GenreService(DatabaseContext context)
        {
            this.context = context;
        }
        public bool Add(Genre model)
        {
            try
            {
                context.Genres.Add(model);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex) { 
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

                context.Genres.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre FindById(int id)
        {
            return context.Genres.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return context.Genres.ToList();
        }

        public bool Update(Genre model)
        {
            try
            {
                context.Genres.Update(model);
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
