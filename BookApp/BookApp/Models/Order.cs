using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        // Relationships Many To One
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }

        // Relationships One To Many
        ICollection<OrderDetail>? OrderDetails { get; set; }

        public Order() 
        { 
            this.CreatedDate = DateTime.Now;
        }
    }
}
