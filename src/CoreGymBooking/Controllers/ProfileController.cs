using System.Security.Claims;
using CoreGymBooking.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreGymBooking.Controllers;

[Authorize]
public class ProfileController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public ProfileController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var myBookings = await _dbContext.Bookings
            .Include(booking => booking.TrainingClass)
            .Where(booking => booking.UserId == userId
                && booking.TrainingClass!.StartsAt >= DateTime.Now)
            .OrderBy(booking => booking.TrainingClass!.StartsAt)
            .ToListAsync();

        return View(myBookings);
    }
}
