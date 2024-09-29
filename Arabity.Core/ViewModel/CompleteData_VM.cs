using Microsoft.AspNetCore.Http;

namespace Arabity.Core.ViewModel
{
    public class CompleteData_VM
    {
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Frist Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$",//White listing only letters
            ErrorMessage = "Only letters accepted, Remove any spaces")]
        public string FristName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$",//White listing only letters
            ErrorMessage = "Only letters accepted, Remove any spaces")]
        public string LastName { get; set; }


        [Display(Name = "Phone Numbre")]
        [StringLength(11),
            RegularExpression("^01[0125][0-9]{8}$"
            , ErrorMessage = "Invalid phone number")]
        public string PhoneNumbre { get; set; }

        [Display(Name ="Personal Image")]
        [FileExtensions(Extensions = ".PNG",
            ErrorMessage = "File Extention is .PNG only")]
        public IFormFile ImageFile { get; set; }
    }
}
