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
        public int RoomStatusId { get; set; }

        [Required]
        public string RoomStatusName { get; set; }


    }
}
