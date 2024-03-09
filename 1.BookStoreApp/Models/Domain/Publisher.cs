using System.ComponentModel.DataAnnotations;

namespace _1.BookStoreApp.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string PublisherName { get; set; }
    }
}
