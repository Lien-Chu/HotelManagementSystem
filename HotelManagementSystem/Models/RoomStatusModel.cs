using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    [Table("RoomStatus")]
    public class RoomStatusModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Room Status Id")]
        public int RoomStatusId { get; set; }

        [Required]
        [Display(Name = "Room Status Name")]
        public string RoomStatusName { get; set; }

    }
}
