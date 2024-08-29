
namespace Arabity.Data.Models
{
    public class Customer
    {
        [Key]
        [Display(Name ="Customer Id")]
        public string Id { get; set; } 

        [Display(Name = "Frist Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$",//White listing only letters
            ErrorMessage ="Only letters accepted, Remove any spaces")]
        public string FristName { get; set; } 

        [Display(Name = "Last Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$",//White listing only letters
            ErrorMessage = "Only letters accepted, Remove any spaces")]
        public string LastName { get; set; } 

        public string ImageUrl { get; set; } 

        [Display(Name = "Phone Numbre")]
        [StringLength(11),
            RegularExpression("^01[0125][0-9]{8}$"
            , ErrorMessage = "Invalid phone number")]
        public string PhoneNumbre { get; set; }

        #region Relations


        #endregion
    }
}
