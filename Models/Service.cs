using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100000)]
        public decimal Price { get; set; }

        public ICollection<ReservationService> ReservationServices
        { get; set; } = new List<ReservationService>();
    }
}
