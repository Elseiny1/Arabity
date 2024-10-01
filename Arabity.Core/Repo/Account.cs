using Microsoft.AspNetCore.Identity;

namespace Arabity.Core.Repo
{
    public class Account : IAccount
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public Account( UserManager<IdentityUser> userManager,
                        ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<Customer> GetCustomerAsync(string email)
        {
            var user = await _userManager.FindByNameAsync(email);
            var customer = await _context.Customers.FindAsync(user.Id);
            if(customer == null) 
                return null;

            return customer;
        }
    }
}
