namespace Arabity.Data.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//this is for makking id not be generated and get the data from model
        //this id is for Customers, Stores, & Workshops
        public string Id { get; set; }

        [Display(Name = "Governrate")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
           ErrorMessage = "Only letters accepted")]
        public string Governrate { get; set; }

        [Display(Name = "City")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
           ErrorMessage = "Only letters accepted")]
        public string City { get; set; }

        [Display(Name = "Hamlet")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z\\s]*$",//White listing only letters
           ErrorMessage = "Only letters accepted")]
        //القريه
        public string Hamlet { get; set; }

        [Display(Name = "Street")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z0-9\\s]*$",//White listing only letters
           ErrorMessage = "Only letters accepted")]
        public string Street { get; set; }

        [Display(Name = "Description")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
           ErrorMessage = "Invalid symboles only basic punctuation symboles")]
        public string Description { get; set; }
    }
}
