namespace Arabity.Data.Models
{
    public class StoreProduct
    {
        [Key]
        public string Parcode { get; set; }

        [Display(Name = "Name")]
        [MaxLength(100)]
        [RegularExpression("^[a-zA-Z0-9\\s]*$",//White listing only letters or numbers
           ErrorMessage = "Only letters accepted")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
           ErrorMessage = "Invalid symboles only basic punctuation symboles")]
        public string Discreption { get; set; }

        [Display(Name ="Price")]
        [Range(typeof(double), "0", "999999.99",
            ErrorMessage ="maxmum value is 999999.99")]
        public double Price { get; set; }

        [Display(Name="Discount")]
        [Range(typeof(int), "0","100")]
        public int? Discount { get; set; }

        [Display(Name="Product Amount")]
        [Range(typeof(int),"0","99999")]
        public int NumberOfPeices { get; set; }

        public bool Status { get; set; }

        public DateTime DateOfPublish { get; set; }
        
        [Display(Name="Model")]
        [RegularExpression("^[a-zA-Z0-9\\s]*$",//White listing only letters or numbers
           ErrorMessage = "Only letters accepted")]
        public string Model { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Price")]
        [Range(typeof(double), "0", "999999.99",
            ErrorMessage = "maxmum value is 999999.99")]
        public double PriceAfterDiscount { get; set; }

        [Display(Name="Made In")]
        [Range(typeof(double), "0", "999999.99",
            ErrorMessage = "maxmum value is 999999.99")]
        public string MadeIn { get; set; }

        #region Relationships
        [ForeignKey("Store_Id")]
        public string Store_Id { get; set; }
        public StoreM Store { get; set; }

       


        #endregion
    }
}
