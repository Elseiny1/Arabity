namespace Arabity.Core.IRepo
{
    public interface IAccount
    {
        public Task<Customer> GetCustomerAsync(string email);
    }
}
