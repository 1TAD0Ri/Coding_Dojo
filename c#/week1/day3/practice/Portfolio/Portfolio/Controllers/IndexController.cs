using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;

public class IndexController : Controller
{
    [HttpGet("")]
    public ViewResult Aboutme()
    {
        ViewBag.Name = "SwordMan";
        ViewBag.Description = "Revenge To my Father";
        return View();
    }

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        ViewBag.DesProject = "Find the 6 magic swords";
        ViewBag.DesProjectt = "Eliminate The Zenin Club";
        ViewBag.DesProjecttt = "Kill Sukuna";
        return View("Projects");
    }
      [HttpGet("contact")]
    public ViewResult Contact()
    {
        return  View("Contact") ;
    }

}