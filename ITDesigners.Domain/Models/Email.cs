using System.ComponentModel.DataAnnotations;

namespace ITDesigners.Models
{
    public class Email
    {
        [Required(ErrorMessage = "Email not correct")]
        public string EmailString { get; set; }
        public string Message { get; set; }
    }
}
