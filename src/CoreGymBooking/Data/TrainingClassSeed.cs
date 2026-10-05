using CoreGymBooking.Models;

namespace CoreGymBooking.Data;

public static class TrainingClassSeed
{
    public static void SeedIfEmpty(ApplicationDbContext dbContext)
    {
        if (dbContext.TrainingClasses.Any())
        {
            return;
        }

        dbContext.TrainingClasses.AddRange(CreateClasses());
        dbContext.SaveChanges();
    }

    private static List<TrainingClass> CreateClasses()
    {
        return new List<TrainingClass>
        {
            new()
            {
                Title = "Morgonstyrka",
                Description = "Styrketräning med skivstång och hantlar för hela kroppen. "
                    + "Passet passar både nybörjare och vana, och instruktören visar "
                    + "lättare varianter av övningarna.",
                StartsAt = DateTime.Today.AddDays(1).AddHours(7),
                Location = "Sal 1",
                Instructor = "Sara Nilsson",
                MaxParticipants = 18
            },
            new()
            {
                Title = "Core och balans",
                Description = "Ett lugnare pass med fokus på bålstyrka, hållning och balans. "
                    + "Vi arbetar med egen kroppsvikt, matta och balansplatta.",
                StartsAt = DateTime.Today.AddDays(2).AddHours(17).AddMinutes(30),
                Location = "Sal 2",
                Instructor = "Ahmed Hassan",
                MaxParticipants = 16
            },
            new()
            {
                Title = "HIIT Express",
                Description = "Högintensiv intervallträning i 30 minuter. "
                    + "Korta arbetsintervaller med vila emellan, och du väljer själv tempo.",
                StartsAt = DateTime.Today.AddDays(3).AddHours(18),
                Location = "Stora salen",
                Instructor = "Emma Andersson",
                MaxParticipants = 20
            },
            new()
            {
                Title = "Rörlighet och stretch",
                Description = "Mjuk träning där vi stretchar igenom kroppen och arbetar med "
                    + "rörlighet i höfter, rygg och axlar. Bra som återhämtning.",
                StartsAt = DateTime.Today.AddDays(5).AddHours(10),
                Location = "Sal 2",
                Instructor = "Jonas Berg",
                MaxParticipants = 14
            }
        };
    }
}
