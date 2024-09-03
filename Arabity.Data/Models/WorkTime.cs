namespace Arabity.Data.Models
{
    public class WorkTime
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression("^[Saturday,Sunday,Monday,Tuseday,Wednesday,Thursday,Friday]*$",
            ErrorMessage="Only day of a week accepted")]
        public string DayOfWeek { get; set; }

        public DateTime Open { get; set; }
        public DateTime Close { get; set; }

        #region Relationship
        [ForeignKey("Workshop_Id")]
        public string? Workshop_Id { get; set; }
        public Workshop? Workshop { get; set; }

        [ForeignKey("Store_Id")]
        public string? Store_Id { get; set; }
        public StoreM? Store { get; set; }


        #endregion
    }
}
