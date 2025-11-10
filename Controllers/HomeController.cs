using System.Diagnostics;
using MDMS_Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MDMS_Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Meter()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult UploadMeter()
        {
            return View();
        }
        public IActionResult OrgUnit()
        {
            return View();
        }
        public IActionResult Consumer()
        {
            return View();
        }
        public IActionResult Tariff()
        {
            return View();
        }
        public IActionResult TariffSlab()
        {
            return View();
        }
        public IActionResult TodRule()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }
        public IActionResult Manufacturer()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
