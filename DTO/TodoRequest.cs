using System.ComponentModel.DataAnnotations;

namespace TodoApi.DTO
{
    public class TodoRequest
    {
        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        public bool done { get; set; } = false;
    }
}
