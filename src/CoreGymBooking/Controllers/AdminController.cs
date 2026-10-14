using CoreGymBooking.Data;
using CoreGymBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreGymBooking.Controllers;

[Authorize(Roles = IdentitySeed.AdminRole)]
public class AdminController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public AdminController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var allClasses = await _dbContext.TrainingClasses
            .Include(trainingClass => trainingClass.Bookings)
            .OrderBy(trainingClass => trainingClass.StartsAt)
            .ToListAsync();

        return View(allClasses);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new TrainingClassViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TrainingClassViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        _dbContext.TrainingClasses.Add(new TrainingClass
        {
            Title = model.Title,
            Description = model.Description,
            StartsAt = model.StartsAt,
            Location = model.Location,
            Instructor = model.Instructor,
            MaxParticipants = model.MaxParticipants
        });

        await _dbContext.SaveChangesAsync();

        TempData["Bekraftelse"] = $"Träningspasset {model.Title} har skapats.";

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var trainingClass = await _dbContext.TrainingClasses.FindAsync(id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        var model = new TrainingClassViewModel
        {
            Title = trainingClass.Title,
            Description = trainingClass.Description,
            StartsAt = trainingClass.StartsAt,
            Location = trainingClass.Location,
            Instructor = trainingClass.Instructor,
            MaxParticipants = trainingClass.MaxParticipants
        };

        ViewData["TrainingClassId"] = id;

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TrainingClassViewModel model)
    {
        var trainingClass = await _dbContext.TrainingClasses.FindAsync(id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            ViewData["TrainingClassId"] = id;

            return View(model);
        }

        trainingClass.Title = model.Title;
        trainingClass.Description = model.Description;
        trainingClass.StartsAt = model.StartsAt;
        trainingClass.Location = model.Location;
        trainingClass.Instructor = model.Instructor;
        trainingClass.MaxParticipants = model.MaxParticipants;

        await _dbContext.SaveChangesAsync();

        TempData["Bekraftelse"] = $"Träningspasset {trainingClass.Title} har uppdaterats.";

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var trainingClass = await _dbContext.TrainingClasses.FindAsync(id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        _dbContext.TrainingClasses.Remove(trainingClass);

        await _dbContext.SaveChangesAsync();

        TempData["Bekraftelse"] = $"Träningspasset {trainingClass.Title} har tagits bort.";

        return RedirectToAction(nameof(Index));
    }
}
