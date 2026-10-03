using CoreGymBooking.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreGymBooking.Controllers;

public class ClassesController : Controller
{
    public IActionResult Index()
    {
        var upcomingClasses = TrainingClassSeed.GetUpcomingClasses();

        return View(upcomingClasses);
    }

    public IActionResult Details(int id)
    {
        var trainingClass = TrainingClassSeed.GetUpcomingClassById(id);

        if (trainingClass is null)
        {
            return NotFound();
        }

        return View(trainingClass);
    }
}
