namespace Arabity.Data.Models
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//this is for makking id not be generated and get the data from model
        //this id is for StoreProducts, Stores, & Workshops
        public string Id { get; set; }

        [Display(Name = "Image url")]
        public string ImageUrl { get; set; }

        [Display(Name = "Image Size")]
        public double Size { get; set; }
    }
}
