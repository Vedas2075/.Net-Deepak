using AssigmentsManagement.Data;
using AssigmentsManagement.Models;
using Microsoft.AspNetCore.Mvc;

public class CollegeController : Controller
{
    private readonly AssignmentMgmtDb _db;

    public CollegeController(AssignmentMgmtDb db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var colleges = _db.Colleges.ToList();
        return View(colleges);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(College college)
    {
        // Save college
        _db.Colleges.Add(college);
        _db.SaveChanges();

        return RedirectToAction(nameof(Index)); 
    }

    public IActionResult Edit(int id)
    {
        var collegeToEdit = _db.Colleges.Find(id);
        return View(collegeToEdit);
    }

    [HttpPost]
    public IActionResult Edit(College college)
    {
        // Save college
        _db.Colleges.Update(college);
        _db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
