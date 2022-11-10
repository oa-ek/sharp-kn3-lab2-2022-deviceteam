using DeviceShop.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeviceShop.Controllers
{
    public class CartController : Controller
    {
        private readonly DeviceShopContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CartController(DeviceShopContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var currentUser = _context.Users.Include(x => x.Devices).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (currentUser != null)
            {
                return View(currentUser.Devices.ToList());
            }
            return View();
        }
    }
}
