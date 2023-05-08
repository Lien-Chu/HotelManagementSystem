using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    [Table("BookingStatus")]
    public class BookingStatusModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BookingStatusId { get; set; }

        [Required]
        public string BookingStatusName { get; set; }
    }

}

