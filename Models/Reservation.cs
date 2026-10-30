using System.ComponentModel.DataAnnotations;

namespace Hotel_manager.Models
{
    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        CheckedIn,
        CheckedOut,
        Cancelled
    }

    public class Reservation
    {
        public int Id { get; set; }

        public int GuestId { get; set; }

        public Guest? Guest { get; set; }

        public int RoomId { get; set; }

        public Room? Room { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Range(1, 20)]
        public int NumberOfGuests { get; set; }

        [Range(0, 1000000)]
        public decimal TotalPrice { get; set; }

        public ReservationStatus Status { get; set; }
            = ReservationStatus.Pending;

        public ICollection<ReservationService> ReservationServices
        { get; set; } = new List<ReservationService>();

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();
    }
}
