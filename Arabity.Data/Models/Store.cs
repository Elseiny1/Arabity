namespace Arabity.Data.Models
{
    public class Store
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

        [MaxLength(80)]
        public string WorkTime { get; set; }

        public string ImageUrl { get; set; }

        #region Relationships
        public ICollection<WorkTime> WorkTimes { get; set; }


        #endregion
    }
}
