using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using study.Models;
using System.Linq;

namespace study.Controllers;

public class HomeController : Controller
{
    public ViewResult Index() {
        int hour =DateTime.Now.Hour;
        ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
        return View("MyView");
    }

    [HttpGet]
    public ViewResult RsvpForm() {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponce guestResponce) {
        Repository.AddResponse(guestResponce);
        return View("Thanks", guestResponce);
    }

    public ViewResult ListResponses() {
        return View(Repository.Responses.Where(r => r.WillAttend == true)); // Linq
    }
}
