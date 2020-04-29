using System.ComponentModel.DataAnnotations;

namespace Renova.ViewModels.Contact
{
    public class EmailViewModel
    {
        [Required]
        public string SenderName { get; set; }
        
        [Required]
        public string SenderEmailAddress { get; set; }        

        [Required]
        public string Message { get; set; }
    }
}