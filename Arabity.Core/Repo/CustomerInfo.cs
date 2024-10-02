namespace Arabity.Core.Repo
{
    public class CustomerInfo : ICustomerInfo
    {
        private readonly ApplicationDbContext _context;
        private readonly IAccount _account;
        public CustomerInfo(ApplicationDbContext context, 
                            IAccount account)
        {
            _context = context;
            _account = account;
        }

        //Validating Images
        private async Task<string> ImageCheckAsync(IFormFile file)
        {
            if (file == null)
                return "~//image//userimage.png";
            else
                return "~//image//userimage.png";

        }

        public async Task<bool> CompleteDataAsync(CompleteData_VM customer, string email)
        {
            if (customer is null)
                return false;

            try
            {
                string imageUrl = await ImageCheckAsync(customer.ImageFile);
                string customerId=await _account.GetUserIdAsync(email);

                var user = new Customer
                {
                    Id= customerId,
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
