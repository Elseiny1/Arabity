namespace Arabity.Data.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//this is for makking id not be generated and get the data from model
        //this id is for Customers, Stores, & Workshops
        public string Id { get; set; }

        public string Governrate { get; set; }

        public string City { get; set; }

        //القريه
        public string Hamlet { get; set; }

        public string Street { get; set; }

        public string Description { get; set; }
    }
}
