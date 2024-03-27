using BookApp.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Promotion : FilterBase
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }


        // Relationships One To Many
        ICollection<Book>? Books { get; set; }
    }
}
