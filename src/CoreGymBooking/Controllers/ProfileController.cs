using System.Security.Claims;
using CoreGymBooking.Data;
using CoreGymBooking.Models;
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
        var userId = GetUserId();

        var profile = await _dbContext.UserProfiles
            .FirstOrDefaultAsync(userProfile => userProfile.UserId == userId);

        var model = new ProfileViewModel
        {
            Email = User.Identity?.Name,
            Name = profile?.Name,
            PhoneNumber = profile?.PhoneNumber,
            Bookings = await GetUpcomingBookings(userId)
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Save(ProfileViewModel model)
    {
        var userId = GetUserId();

        if (!ModelState.IsValid)
        {
            model.Email = User.Identity?.Name;
            model.Bookings = await GetUpcomingBookings(userId);

            return View(nameof(Index), model);
        }

        var profile = await _dbContext.UserProfiles
            .FirstOrDefaultAsync(userProfile => userProfile.UserId == userId);

        if (profile is null)
        {
            profile = new UserProfile { UserId = userId };
            _dbContext.UserProfiles.Add(profile);
        }

        profile.Name = model.Name;
        profile.PhoneNumber = model.PhoneNumber;

        await _dbContext.SaveChangesAsync();

        TempData["Bekraftelse"] = "Dina personuppgifter är sparade.";

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CancelBooking(int id)
    {
        var userId = GetUserId();

        // Bokningen hämtas med användarens id, så ingen kan avboka någon annans bokning.
        var booking = await _dbContext.Bookings
            .Include(bookingToCancel => bookingToCancel.TrainingClass)
            .FirstOrDefaultAsync(bookingToCancel => bookingToCancel.Id == id
                && bookingToCancel.UserId == userId);

        if (booking is null)
        {
            return NotFound();
        }

        _dbContext.Bookings.Remove(booking);

        await _dbContext.SaveChangesAsync();

        TempData["Bekraftelse"] = $"Din bokning av {booking.TrainingClass!.Title} har avbokats.";

        return RedirectToAction(nameof(Index));
    }

    private string GetUserId()
    {
        return User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
    }

    private async Task<IReadOnlyList<Booking>> GetUpcomingBookings(string userId)
    {
        return await _dbContext.Bookings
            .Include(booking => booking.TrainingClass)
            .Where(booking => booking.UserId == userId
                && booking.TrainingClass!.StartsAt >= DateTime.Now)
            .OrderBy(booking => booking.TrainingClass!.StartsAt)
            .ToListAsync();
    }
}
