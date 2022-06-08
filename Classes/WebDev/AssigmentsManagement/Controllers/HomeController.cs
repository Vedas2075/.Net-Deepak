using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AssigmentsManagement.Models;

namespace AssigmentsManagement.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
