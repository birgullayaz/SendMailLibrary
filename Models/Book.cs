using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        public int PublicationYear { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsAvailable { get; set; } = true;

        public ICollection<BookLoan> BookLoans { get; set; }
    }
}
