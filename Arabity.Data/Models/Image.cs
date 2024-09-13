namespace Arabity.Data.Models
{
    public class Image
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Image url")]
        public string ImageUrl { get; set; }

        [Display(Name = "Image Size")]
        public double Size { get; set; }

        //this foreingkey made to contain the Id of Workshops, Stores, and Products
        [ForeignKey("Entity Id")]
        public string EntityId { get; set; }

        [Display(Name ="Entity Type")]
        [RegularExpression("^(Workshop|Store|StoreProduct)$")]
        public string EntityType { get; set; }
    }
}
