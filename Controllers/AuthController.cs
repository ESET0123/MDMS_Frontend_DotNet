using Microsoft.AspNetCore.Mvc;

namespace MDMS_Frontend.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
