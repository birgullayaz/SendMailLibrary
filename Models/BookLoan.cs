using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookLoan
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public int MemberId { get; set; }
        public Member Member { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool IsReturned { get; set; } = false;

        public decimal? FineAmount { get; set; }
    }
}
