using BookApp.Models.BaseModels;

namespace BookApp.Models
{
    public class Author : FilterBase
    {
        // Relationships One To Many
        ICollection<Book>? Books { get; set; }
    }
}
