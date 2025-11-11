using Microsoft.AspNetCore.Mvc;

namespace MDMS_Frontend.Controllers
{
    public class ConsumerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult MyMeters()
        {
            return View();
        }

        public IActionResult DailyMeterReading()
        {
            return View();
        }

        public IActionResult MonthlyBill()
        {
            return View();
        }
    }
}