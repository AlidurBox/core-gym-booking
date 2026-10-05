using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreGymBooking.Controllers;

[Authorize]
public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
