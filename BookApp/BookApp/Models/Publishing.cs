using BookApp.Models.BaseModels;

namespace BookApp.Models
{
    public class Publishing : FilterBase
    {
        // Relationships One To Many
        ICollection<Book>? Books { get; set; }
    }
}
