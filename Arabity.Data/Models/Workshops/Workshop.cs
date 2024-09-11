namespace Arabity.Data.Models
{
    public class Workshop
    {
        [Key]
        [Display(Name = "Customer Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(70)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
            ErrorMessage = "Only letters accepted")]
        public string Name { get; set; } 

        [Display (Name = "Description")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
            ErrorMessage ="Invalid symboles only basic punctuation symboles")]
        public string Description { get; set; }

        [Display(Name = "Specialty")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
            ErrorMessage = "Only letters accepted")]
        public string Type { get; set; }

        [Display(Name = "Phone Numbre")]
        [StringLength(11),
            RegularExpression("^01[0125][0-9]{8}$"
            , ErrorMessage = "Invalid phone number")]
        public string PhoneNumbre { get; set; } 

        #region Relationships
        public Address Address { get; set; }

        public ICollection<Rate> Rate { get; set; }
        public ICollection<Image> Images { get; set; }


        #endregion
    }
}
