using Microsoft.AspNetCore.Mvc;

namespace DeviceShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
