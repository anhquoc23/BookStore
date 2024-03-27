using BookApp.Models.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApp.Models
{
    public class Category : FilterBase
    {
        // Relationships One To Many
        ICollection<Book>? Books { get; set; }
    }
}
