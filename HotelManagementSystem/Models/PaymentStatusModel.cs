using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models
{
    [Table("PaymentStatus")]
    public class PaymentStatusModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PaymentStatusId { get; set; }

        [Required]
        public string PaymentStatusName { get; set; }


    }
}
