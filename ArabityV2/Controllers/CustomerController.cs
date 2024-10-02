using Arabity.Core.IRepo;
using Arabity.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ArabityV2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerInfo _customerInfo;
        public CustomerController(ICustomerInfo customerInfo)
        {
            _customerInfo = customerInfo;
        }
        [HttpGet]
        public async Task<IActionResult> CompleteCustomer(string email)
        {
            if (email == null)
                return RedirectToAction("Index", "Home");
            CompleteData_VM vm = new CompleteData_VM { Email = email };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteCustomer(CompleteData_VM customer)
        {
            if (!ModelState.IsValid)
                return View(customer);

            var result = await _customerInfo.CompleteDataAsync(customer, customer.Email);

            if (!result)
                return View(customer);

            return RedirectToAction("Index", "Home");
        }
    }
}
