using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    [Table("Booking")]
    public class BookingModel
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int BookingId { get; set; }
        [Required]
        public List<RoomModel> Room { get; set; }
        [Required]
        public CustomerModel Customer { get; set; }
        [Required]
        public BookingStatusModel BookingStatus { get; set; }
		[Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public DateTime BookingTime { get; set; }
        [Required]
        public string PaymentType { get; set; }
        [Required]
        public string PaymentStatus { get; set; }
        public string SpecialRequirements { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsDelete { get; set; } = false;

    }
}
