using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodoApi.Model
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        public bool done { get; set; } = false;

        public string UserId { get; set; }
        public IdentityUser User { get; set; }


    }
}
