using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.controllers;

public class DojoController : Controller
{
    [HttpGet("")]
    public ViewResult Dojosurvey()
    {
        return View();
    }
    // remember to use [HttpPost]
    [HttpGet("results")]
    public ViewResult Results()
    {

        return View("Results");
    }
    [HttpPost("process")]
    public IActionResult Process(string Name, string location, string language, string comment)
    {
        ViewBag.Name = Name;
        ViewBag.location = location;
         ViewBag.language = language;
         ViewBag.comment = comment;
        // Do something with form input
        // Console.WriteLine($"Name: {Name}");
        // Console.WriteLine($"Location: {location}");
        // System.Console.WriteLine($"Favorite Language: {language}");
        // System.Console.WriteLine($"Comment: {comment}");
        // return RedirectToAction("Form is filled");
        return View("Results");
    }



}