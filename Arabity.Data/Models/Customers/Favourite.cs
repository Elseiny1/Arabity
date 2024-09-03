namespace Arabity.Data.Models
{
    public class Favourite
    {

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
