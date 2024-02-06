using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;




namespace ChefDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;

    }

    public IActionResult Chefs()
    {
        List<Chef> allChefs = _db.Chefs.Include(d=>d.ChefDishes).ToList();
        
        return View(allChefs);
    }

    public IActionResult Dishes()
    {
         List<Dish> allDishes = _db.Dishes.Include(a=>a.Chef).ToList();
        return View(allDishes);
    }
    public IActionResult AddChef()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateChef(Chef newChef)
    {
        
        if (ModelState.IsValid)
        {
            _db.Add(newChef);
            _db.SaveChanges();
            return RedirectToAction("Chefs");
        }
        // Display Error messages
        return View("AddChef");
    }
    [HttpPost]
    public IActionResult CreateDish(Dish newDish)
    {
              
        
        if (ModelState.IsValid)
        {
            _db.Add(newDish);
            _db.SaveChanges();
            return RedirectToAction("Dishes");

        }
        // Display Error messages
        return View("AddDishe");
    }
    //  public IActionResult Chefs()
    // {
    // }
    public IActionResult AddDishe()
    {
        List<Chef> chefs = _db.Chefs.ToList();
        // AddChefViewModel addDishModel = new AddChefViewModel(){Chefs=chefs, Dish= new Dish(){}};
        ViewBag.chefs = chefs;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
