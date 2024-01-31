using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers;

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

    [HttpPost("Home/SubmitDate")]
    public IActionResult Privacy(DateModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        // Custom validation to check if the date is in the past
        if (model.Date > DateTime.Now)
        {
            ModelState.AddModelError("Date", "Please enter a date in the past.");
            return View("Index", model);
        }

        // Process the data (for demonstration, let's just return a success view)
        return View("Privacy");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}