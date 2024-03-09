using System.ComponentModel.DataAnnotations;

namespace _1.BookStoreApp.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
