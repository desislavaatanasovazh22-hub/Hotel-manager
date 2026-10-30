using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string RoomNumber { get; set; } = string.Empty;

        public int Floor { get; set; }

        public bool IsActive { get; set; } = true;

        public int RoomTypeId { get; set; }

        public RoomType? RoomType { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
            = new List<Reservation>();
    }
}
