using BookApp.Models.BaseModels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Address { get; set; }
        public string Avatar { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        // Relationships One To Many
        ICollection<Order>? Orders { get; set; }
        ICollection<Rating>? Ratings { get; set; }
        ICollection<Comment>? Comments { get; set; }
    }
}
