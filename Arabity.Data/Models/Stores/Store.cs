namespace Arabity.Data.Models
{
    public class StoreM
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(70)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
            ErrorMessage = "Only letters accepted")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
            ErrorMessage = "Invalid symboles only basic punctuation symboles")]
        public string Description { get; set; }

        [Display(Name = "Phone Numbre")]
        [StringLength(11),
           RegularExpression("^01[0125][0-9]{8}$"
           , ErrorMessage = "Invalid phone number")]
        public string PhoneNumbre { get; set; }

        #region Relationships
        public Address Address { get; set; }

        public ICollection<Rate> Rate { get; set; }

        #endregion
    }
}
