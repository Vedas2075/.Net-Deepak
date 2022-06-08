using Microsoft.AspNetCore.Mvc;

namespace AssigmentsManagement.Views.College
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
