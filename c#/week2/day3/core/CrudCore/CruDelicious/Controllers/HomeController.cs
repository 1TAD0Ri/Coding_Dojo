#pragma warning disable CS8618

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CruDelicious.Models;

namespace CruDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;

        _db = db;

    }


    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Index()
    {
        List<Dishe> allDishes = _db.Dishes.ToList();
        return View(allDishes);
    }

        public IActionResult Edit(int disheId)
    {
        Dishe dishe = _db.Dishes.FirstOrDefault(a => a.DisheId == disheId);
        return View(dishe);
    }



    //!! Create create create  create 
    [HttpPost]
    public IActionResult CreateDishe(Dishe newDishe)
    {
        if (ModelState.IsValid)
        {

            //Insert New new Dishe into database (2steps)
            //1 Add
            _db.Add(newDishe);
            //2 Save 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            //display Error messsages
            return View("Create");
        }
    }

    //!! Edit Edit Edit  Edit 


    [HttpPost]
    public IActionResult UpdateDishe(Dishe disheToUpdate)
    {
        System.Console.WriteLine($"Dishe Id : {disheToUpdate.DisheId}\n CreatedAt : {disheToUpdate.CreatedAt}");
        if (ModelState.IsValid)
        {
            // 1- Update
            Dishe dishe = _db.Dishes.FirstOrDefault(x => x.DisheId == disheToUpdate.DisheId);
            // Mapping
            dishe.Name = disheToUpdate.Name;
            dishe.Chef = disheToUpdate.Chef;
            dishe.Tastiness = disheToUpdate.Tastiness;
            dishe.Description = disheToUpdate.Description;
            dishe.Calories = disheToUpdate.Calories;
            dishe.UpdatedAt = DateTime.Now;
            //  2 - Save
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Edit");

    }
    [HttpPost]
    public IActionResult DeleteDishe(int disheId)
    {
        Dishe? disheToDelete = _db.Dishes.FirstOrDefault(a => a.DisheId == disheId);
        //  1 Delete
        _db.Dishes.Remove(disheToDelete);
        //  2 Save
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult ShowOne(int disheId)
{
    Dishe dishe = _db.Dishes.FirstOrDefault(a => a.DisheId == disheId);

    if (dishe == null)
    {
        return RedirectToAction("Index"); // Or handle the case when the dish is not found.
    }

    return View(dishe);
}



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
