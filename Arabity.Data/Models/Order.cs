namespace Arabity.Data.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set; }

        [Display(Name ="Total Price")]
        [Range(typeof(double), "0", "999999.99",
            ErrorMessage = "maxmum value is 999999.99")]
        public double TotalPrice { get; set; }

        [Display(Name ="Order Date")]
        public DateTime OrderDate { get; set; }

        #region Relationships
        [ForeignKey("Customer_Id")]
        public string Customer_Id { get; set; }
        public Customer Customer { get; set; }

        public ICollection<StoreProduct> Products { get; set; }


        #endregion
    }
}
