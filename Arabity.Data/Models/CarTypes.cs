namespace Arabity.Data.Models
{
    public class CarType
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "CarType")]
        [RegularExpression("^[a-zA-Z0-9\\s]*$",//White listing only letters or numbers
           ErrorMessage = "Only letters accepted")]
        public string Car_Type { get; set; }

        #region Relationships
        public ICollection<Workshop> Workshops { get; set; }
        public ICollection<StoreM> Stores { get; set; }


        #endregion
    }
}
