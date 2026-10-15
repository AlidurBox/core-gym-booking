using System.Security.Claims;
using CoreGymBooking.Data;
using CoreGymBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreGymBooking.Controllers;

public class ClassesController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public ClassesController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var upcomingClasses = await GetUpcomingClasses().ToListAsync();

        return View(upcomingClasses);
    }

    public async Task<IActionResult> Details(int id)
    {
        var trainingClass = await GetUpcomingClasses()
            .FirstOrDefaultAsync(upcomingClass => upcomingClass.Id == id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        return View(trainingClass);
    }

    public async Task<IActionResult> Schedule()
    {
        var upcomingClasses = await GetUpcomingClasses().ToListAsync();

        return View(upcomingClasses);
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Book(int id)
    {
        var trainingClass = await _dbContext.TrainingClasses
            .Include(upcomingClass => upcomingClass.Bookings)
            .FirstOrDefaultAsync(upcomingClass => upcomingClass.Id == id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
        {
            return Challenge();
        }

        if (trainingClass.Bookings.Any(booking => booking.UserId == userId))
        {
            TempData["Fel"] = "Du har redan bokat det här passet.";
        }
        else if (trainingClass.IsFull)
        {
            TempData["Fel"] = "Passet är fullbokat, så det finns inga lediga platser kvar.";
        }
        else
        {
            _dbContext.Bookings.Add(new Booking
            {
                UserId = userId,
                TrainingClassId = trainingClass.Id,
                CreatedAt = DateTime.Now
            });

            await _dbContext.SaveChangesAsync();

            TempData["Bekraftelse"] = $"Din bokning av {trainingClass.Title} är klar.";
        }

        return RedirectToAction(nameof(Details), new { id });
    }

    private IQueryable<TrainingClass> GetUpcomingClasses()
    {
        return _dbContext.TrainingClasses
            .Include(trainingClass => trainingClass.Bookings)
            .Where(trainingClass => trainingClass.StartsAt >= DateTime.Now)
            .OrderBy(trainingClass => trainingClass.StartsAt);
    }
}
