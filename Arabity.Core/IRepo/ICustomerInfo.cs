namespace Arabity.Core.IRepo
{
    public interface ICustomerInfo
    {
        public Task<bool> CompleteDataAsync(CompleteData_VM customer, string email);

    }
}
