using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First Name os too long.")]
        [MinLength(5, ErrorMessage = "First Name is to short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last Name os too long.")]
        [MinLength(5, ErrorMessage = "Last Name is to short.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
