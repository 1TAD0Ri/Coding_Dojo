using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using WeddinggPlanner.Models;

namespace WeddinggPlanner.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }

    [SessionCheck]
    public IActionResult CreateWedding()
    {
        return View();
    }

    [SessionCheck]
    public IActionResult Privacy()
    {
        int userId = (int)HttpContext.Session.GetInt32("userId");
        List<Wedding> weddings = _db.Weddings.Include(w => w.MyGuests).ToList();
        return View(weddings);
    }

    [HttpPost]
    public IActionResult Create(Wedding wedding)
    {
        if (ModelState.IsValid)
        {
            _db.Add(wedding);
            _db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        return View("CreateWedding");
    }

    //Delete Product
    [HttpPost]
    public IActionResult DeleteWedding(int id)
    {
        System.Console.WriteLine(id);
        var wedding = _db.Weddings.FirstOrDefault(w => w.WeddingId == id);


        if (wedding is not null)
        {
            Wedding weddingToDelete = wedding;
            _db.Weddings.Remove(weddingToDelete);
            _db.SaveChanges();
        }
        return RedirectToAction("Privacy"); // we can add the name of controller 
    }


    //---------------------------Guests------------------------------------------
    [HttpPost]
    public IActionResult RSVP(int weddingId)
    {
        int userId = (int)HttpContext.Session.GetInt32("userId");
        bool result = _db.Guests.Any(g => g.WeddingId == weddingId && g.UserId == userId);
        System.Console.WriteLine($"Wedding Id :{weddingId} ------ User Id : {userId} ------------");
        if (!result)
        {
            Guest guest = new Guest
            {
                WeddingId = weddingId,
                UserId = userId
            };
            _db.Add(guest);
            _db.SaveChanges();
        }

        return RedirectToAction("Privacy");
    }

    [HttpPost]
    public IActionResult UnRSVP(int weddingId)
    {
        int userId = (int)HttpContext.Session.GetInt32("userId");

        var guest = _db.Guests.FirstOrDefault(g => g.WeddingId == weddingId && g.UserId == userId);
        if (guest != null)
        {
            _db.Remove(guest);
            _db.SaveChanges();
        }

        return RedirectToAction("Privacy");
    }


    public IActionResult Guests(int weddingId)
    {
        var weddingWithGuests = _db.Weddings
            .Include(w => w.MyGuests)
            .ThenInclude(g => g.User)
            .FirstOrDefault(w => w.WeddingId == weddingId);

        if (weddingWithGuests == null)
        {
            return NotFound();
        }

        return View(weddingWithGuests.MyGuests);
    }





    [HttpPost]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            bool result = _db.Users.Any(u => u.Email == user.Email);
            if (result)
            {
                ModelState.AddModelError("Email", "Email already in use. Hope by you 🤡.");
                return View("Index");
            }
            else
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _db.Add(user);
                _db.SaveChanges();
                HttpContext.Session.SetInt32("userId", user.UserId);
                HttpContext.Session.SetString("username", user.Username);
                return RedirectToAction("Privacy");

            }
        }
        return View("Index");

    }

    [HttpPost]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid)
        {
            User? userFromDb = _db.Users.FirstOrDefault(x => x.Email == loginUser.LoginEmail);
            if (userFromDb is not null)
            {
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginUser, userFromDb.Password, loginUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Wrong Password.");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("userId", userFromDb.UserId);
                HttpContext.Session.SetString("username", userFromDb.Username);
                return RedirectToAction("Privacy");
            }
            ModelState.AddModelError("LoginEmail", "Email doesn't exist. Try to register.");
            return View("Index");
        }
        return View("Index");
    }

    [HttpPost]
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

    //  - Session check Filter class
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("userId");
            if (userId == null)
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
