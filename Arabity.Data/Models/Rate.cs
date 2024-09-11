namespace Arabity.Data.Models
{
    public class Rate
    {
        [Key]
        [ForeignKey(nameof(Customer))]
        public string Customer_Id { get; set; }
        public Customer Customer { get; set; }

        [Display(Name ="Rate")]
        [Range(0.0, 5.0)]
        public decimal Ratevalue { get; set; }

        [Display(Name = "Rate")]
        [MaxLength(250)]
        [RegularExpression("^[a-zA-Z0-9\\s.,:;!?]*$",
           ErrorMessage = "Invalid symboles only basic punctuation symboles")]
        public string? Comments { get; set; }

        #region Relationships
        [ForeignKey("StoreId")]
        public string? StoreId { get; set; }
        public StoreM Store { get; set; }

        [ForeignKey("WorkshopId")]
        public string? WorkshopId { get; set; }
        public Workshop Workshop { get; set; }

        [ForeignKey("StoreProductParcode")]
        public string? StoreProductParcode { get; set; }
        public StoreProduct StoreProduct { get; set; }


        #endregion

    }
}
