namespace Arabity.Data.Models
{
    public class Brand
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Brand Name")]
        [MaxLength(100)]
        [RegularExpression("^[a-zA-Z0-9\\s]*$",//White listing only letters or numbers
           ErrorMessage = "Only letters or numbers accepted")]
        public string CarBrand { get; set; }
    }
}
