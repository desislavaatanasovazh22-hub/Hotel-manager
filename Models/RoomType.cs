using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models

{
    public class RoomType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, 20)]
        public int Capacity { get; set; }

        [Range(0, 100000)]
        public decimal PricePerNight { get; set; }

        public ICollection<Room> Rooms { get; set; }
            = new List<Room>();
    }
}
