using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApp.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rate { get; set; }

        // Relationships Many To One
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
