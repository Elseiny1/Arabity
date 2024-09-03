namespace Arabity.Data.Models
{
    public class Cart
    {
        [Display(Name ="Product Quantity")]
        [Range(typeof(int),"0", "9999",
            ErrorMessage ="maximum value is 9999")]
        public int Quanitity { get; set; }

        #region Relationships
        [Key]
        [ForeignKey("Customer_Id")]
        public string Customer_Id { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product_Parcode")]
        public string Product_Parcode { get; set; }
        public StoreProduct StoreProduct { get; set; }


        #endregion
    }
}
