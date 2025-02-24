using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public string Biography { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
