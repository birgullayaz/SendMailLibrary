using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime MembershipDate { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<BookLoan> BookLoans { get; set; }
    }
}
