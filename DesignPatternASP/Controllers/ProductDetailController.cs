using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private LocalEarnFactory _localEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
        }
        public IActionResult Index(decimal total)
        {
            //factories
            //LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);


            //products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);


            return View();
        }
    }
}
