using BookApp.Models.BaseModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookApp.Models
{
    public class Book : DateBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BookId { get; set; }
        [Required]
        [Length(15, 255)]
        public string BookName { get; set; }
        [MaxLength]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        [Range(10000, float.MaxValue)]
        public float UnitPrice { get; set; }
        [Range(0, 1)]
        [DefaultValue(0)]
        public float Discount { get; set; }
        [Required]
        public string TypeBook { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        // Relationships Many To One
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        [ForeignKey("Publishing")]
        public int? PublishingId { get; set; }
        public Publishing? Publishing { get; set; }
        [ForeignKey("Promotion")]
        public int? PromotionId { get; set; }
        public Promotion? Promotion { get; set; }

        // Relationships One To Many
        ICollection<OrderDetail>? OrderDetails { get; set; }

        public Book()
        {
            this.CreatedDate = DateTime.Now;
            this.UpdateDate = DateTime.Now;
        }

    }
}
