using Microsoft.AspNetCore.Mvc;

public class CollegeController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}