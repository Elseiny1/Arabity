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
        public IActionResult GetCompleteCustomer(string email)
        {
            return View(new {email});
        }

        [HttpPost]
        public async Task<IActionResult> CompleteDataAsync(CompleteData_VM customer)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("GetCompleteCustomer", new {});

            var result = await _customerInfo.CompleteDataAsync(customer);

            if (!result)
                return View();

            return RedirectToAction("Index");
        }
    }
}
