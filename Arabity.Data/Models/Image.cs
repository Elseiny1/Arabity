namespace Arabity.Data.Models
{
    public class Image
    {
        [Key]
        public string Id { get; set; }

        public string ImageUrl { get; set; }


        #region Relationships
        [ForeignKey("Product_Parcode")]
        public string Product_Parcode { get; set; }
        public StoreProduct Product { get; set; }

        #endregion
    }
}
