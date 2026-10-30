using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public Reservation? Reservation { get; set; }

        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
            = DateTime.Now;

        [Required]
        public string PaymentMethod { get; set; }
            = string.Empty;
    }
}
