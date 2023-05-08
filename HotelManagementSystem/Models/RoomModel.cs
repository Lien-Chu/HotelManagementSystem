using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    [Table("Room")]
    public class RoomModel
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int RoomNumber { get; set; }
		[Required]
		public string RoomType { get; set; }
		[Required]
		public decimal RoomPrice { get; set; }

		public string? RoomDescription { get; set; }
		public string? RoomImage { get; set; }
		public RoomStatusModel RoomStatus { get; set; }

    }
}
