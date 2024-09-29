namespace Arabity.Core.Repo
{
    public class CustomerInfo : ICustomerInfo
    {
        private readonly ApplicationDbContext _context;
        public CustomerInfo(ApplicationDbContext context)
        {
            _context = context;
        }

        //Validating Images
        private async Task<string> ImageCheckAsync(IFormFile file)
        {
            if (file == null)
                return "~//image//userimage.png";
            else
                return "~//image//userimage.png";

        }

        public async Task<bool> CompleteDataAsync(CompleteData_VM customer)
        {
            if (customer is null)
                return false;

            try
            {
                string imageUrl = await ImageCheckAsync(customer.ImageFile);
                var user = new Customer
                {
                    FristName = customer.FristName,
                    LastName = customer.LastName,
                    PhoneNumbre = customer.PhoneNumbre,
                    ImageUrl = imageUrl,
                };
                _context.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
