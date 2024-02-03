using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkShop.Models;
// ! Session Config Part 2
using Microsoft.AspNetCore.Http;
// !     

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
      
        return View();
    }
    [HttpPost("EnterGame")]
    public IActionResult EnterGame(string player)
    {
        if (string.IsNullOrEmpty(player))
        {
           
            return View("Index"); 
        }

        HttpContext.Session.SetString("player", player);
        return RedirectToAction("Privacy");
    }
    [HttpPost]
    public IActionResult AddOne()
    {
        int number = Convert.ToInt32(HttpContext.Session.GetString("number") ?? "0");
        number += 1;
        HttpContext.Session.SetString("number", number.ToString());
        return RedirectToAction("Privacy"); 
    }

    [HttpPost]
    public IActionResult SubtractOne()
    {
        int number = Convert.ToInt32(HttpContext.Session.GetString("number") ?? "0");
        number -= 1;
        HttpContext.Session.SetString("number", number.ToString());
        return RedirectToAction("Privacy");
    }

    [HttpPost]
    public IActionResult MultiplyByTwo()
    {
        int number = Convert.ToInt32(HttpContext.Session.GetString("number") ?? "0");
        number *= 2;
        HttpContext.Session.SetString("number", number.ToString());
        return RedirectToAction("Privacy");
    }

    [HttpPost]
    public IActionResult AddRandom()
    {
        int number = Convert.ToInt32(HttpContext.Session.GetString("number") ?? "0");
        number += new Random().Next(1, 11); 
        HttpContext.Session.SetString("number", number.ToString());
        return RedirectToAction("Privacy");
    }




    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
