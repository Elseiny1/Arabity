namespace Arabity.Data.Models
{
    public class Rate
    {
        [Key]
        public string Id { get; set; }

        [Display(Name ="Rate")]
        [Range(typeof(float),"1.0", "5.0",
            ErrorMessage ="Invalid Value")]
        public float RattingValue { get; set; }

        [Display(Name = "Review Text")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
            ErrorMessage = "Invalid symboles only basic punctuation symboles")]
        public string? Review { get; set; }
        
        public DateTime Time { get; set; }

        #region Relationships
        [ForeignKey("Product_Parcode")]
        public string Product_Parcode { get; set; }
        public StoreProduct StoreProduct { get; set; }

        [ForeignKey("Customer_Id")]
        public string Customer_Id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Store_Id")]
        public string? Store_Id { get; set; }
        public StoreM? Store { get; set; }

        [ForeignKey("Workshop_Id")]
        public string Workshop_Id { get; set; }
        public Workshop Workshop { get; set; }



        #endregion

    }
}
