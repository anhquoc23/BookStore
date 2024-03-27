using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Content { get; set; }

        // Relationships Many To One
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
