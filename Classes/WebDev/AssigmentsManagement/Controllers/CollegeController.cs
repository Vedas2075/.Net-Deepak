using System.Linq;
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

    [HttpGet]
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
        var collgeToEdit = _db.Colleges.Find(id);
        return View(collgeToEdit);
    }

    [HttpPost]
    public IActionResult Edit(College college)
    {
        _db.Colleges.Update(college);
        _db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var collgeToEdit = _db.Colleges.Find(id);
        return View(collgeToEdit);
    }

    [HttpPost]
    public IActionResult Delete(College college)
    {
        _db.Colleges.Remove(college);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}
