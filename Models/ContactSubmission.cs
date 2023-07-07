using System.ComponentModel.DataAnnotations;

namespace DESIGNOX.Models
{
    public class ContactSubmission
    {
        [MinLength(3, ErrorMessage ="Name too short!")]
        [Required(ErrorMessage ="Can't be empty!")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Can't be empty!")]
        public string Email { get; set; }
        public string? Phone { get; set; }
        [MinLength(10, ErrorMessage ="Message too short!")]
        public string Message { get; set; }
    }
}
