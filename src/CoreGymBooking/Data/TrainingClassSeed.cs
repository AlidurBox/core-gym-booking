using CoreGymBooking.Models;

namespace CoreGymBooking.Data;

public static class TrainingClassSeed
{
    public static IReadOnlyList<TrainingClass> GetUpcomingClasses()
    {
        return CreateClasses()
            .Where(trainingClass => trainingClass.StartsAt >= DateTime.Now)
            .OrderBy(trainingClass => trainingClass.StartsAt)
            .ToList();
    }

    public static TrainingClass? GetUpcomingClassById(int id)
    {
        return GetUpcomingClasses()
            .FirstOrDefault(trainingClass => trainingClass.Id == id);
    }

    private static List<TrainingClass> CreateClasses()
    {
        return new List<TrainingClass>
        {
            new()
            {
                Id = 1,
                Title = "Morgonstyrka",
                Description = "Styrketräning med skivstång och hantlar för hela kroppen. "
                    + "Passet passar både nybörjare och vana, och instruktören visar "
                    + "lättare varianter av övningarna.",
                StartsAt = DateTime.Today.AddDays(1).AddHours(7),
                Location = "Sal 1",
                Instructor = "Sara Nilsson",
                MaxParticipants = 18,
                BookedParticipants = 11
            },
            new()
            {
                Id = 2,
                Title = "Core och balans",
                Description = "Ett lugnare pass med fokus på bålstyrka, hållning och balans. "
                    + "Vi arbetar med egen kroppsvikt, matta och balansplatta.",
                StartsAt = DateTime.Today.AddDays(2).AddHours(17).AddMinutes(30),
                Location = "Sal 2",
                Instructor = "Ahmed Hassan",
                MaxParticipants = 16,
                BookedParticipants = 9
            },
            new()
            {
                Id = 3,
                Title = "HIIT Express",
                Description = "Högintensiv intervallträning i 30 minuter. "
                    + "Korta arbetsintervaller med vila emellan, och du väljer själv tempo.",
                StartsAt = DateTime.Today.AddDays(3).AddHours(18),
                Location = "Stora salen",
                Instructor = "Emma Andersson",
                MaxParticipants = 20,
                BookedParticipants = 17
            },
            new()
            {
                Id = 4,
                Title = "Rörlighet och stretch",
                Description = "Mjuk träning där vi stretchar igenom kroppen och arbetar med "
                    + "rörlighet i höfter, rygg och axlar. Bra som återhämtning.",
                StartsAt = DateTime.Today.AddDays(5).AddHours(10),
                Location = "Sal 2",
                Instructor = "Jonas Berg",
                MaxParticipants = 14,
                BookedParticipants = 6
            }
        };
    }
}
