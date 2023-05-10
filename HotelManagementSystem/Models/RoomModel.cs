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
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
		[Required]
        [Display(Name = "Room Type")]
        public string RoomType { get; set; }
		[Required]
        [Display(Name = "Room Price")]
        public decimal RoomPrice { get; set; }
        [Display(Name = "Room Description")]
        public string? RoomDescription { get; set; }
        [Display(Name = "Room Image")]
        public string? RoomImage { get; set; }
		public RoomStatusModel RoomStatus { get; set; }

    }
}
