namespace Arabity.Core.IRepo
{
    public interface IAccount
    {
        public Task<Customer> GetCustomerAsync(string email);
        public Task<string> GetUserIdAsync(string email);
    }
}
