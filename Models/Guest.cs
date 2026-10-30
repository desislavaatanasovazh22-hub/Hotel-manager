using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string IdentificationDocument { get; set; }
            = string.Empty;

        public ICollection<Reservation> Reservations { get; set; }
            = new List<Reservation>();
    }
}
