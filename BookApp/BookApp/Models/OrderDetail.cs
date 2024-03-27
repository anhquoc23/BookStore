using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApp.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public float Discount { get; set; }

        // Relationships Many To One
        [ForeignKey("Book")]
        public string? BookId { get; set; }
        public Book? Book { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
