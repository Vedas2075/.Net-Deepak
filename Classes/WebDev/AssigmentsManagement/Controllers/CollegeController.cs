using AssigmentsManagement.Models;
using Microsoft.AspNetCore.Mvc;

public class CollegeController: Controller
{
    List<College> colleges = new()
    {
        new College() { Name = "Vedas", Description = "IT college, affiliated to TU", Address = "Lalitpur", EstablishedDate = DateTime.Now, Rank = 7 },
        new College() { Name = "Himalayan", Description = "IT college, affiliated to TU", Address = "Bhaktapur", EstablishedDate = DateTime.Now, Rank = 3 },
        new College() { Name = "Vedas1", Description = "IT college, affiliated to TU", Address = "Lalitpur", EstablishedDate = DateTime.Now, Rank = 1 },
        new College() { Name = "Vedas2", Description = "IT college, affiliated to TU", Address = "Bhaktapur", EstablishedDate = DateTime.Now, Rank = 4 },
        new College() { Name = "Vedas3", Description = "IT college, affiliated to TU", Address = "Kathmandu", EstablishedDate = DateTime.Now, Rank = 10 }
    };

    public IActionResult Index()
    {
        return View(colleges);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add()
    {
        colleges.Add(college);
        return RedirectToAction(nameof(Index));
    }
}