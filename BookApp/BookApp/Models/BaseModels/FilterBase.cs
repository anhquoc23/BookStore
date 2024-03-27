using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models.BaseModels
{
    public abstract class FilterBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Length(5, 100)]
        public string Name { get; set; }
    }
}
