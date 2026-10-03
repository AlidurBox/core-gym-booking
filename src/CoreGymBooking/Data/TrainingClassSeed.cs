using CoreGymBooking.Models;

namespace CoreGymBooking.Data;

public static class TrainingClassSeed
{
    public static IReadOnlyList<TrainingClass> GetUpcomingClasses()
    {
        var classes = new List<TrainingClass>
        {
            new()
            {
                Title = "Morgonstyrka",
                StartsAt = DateTime.Today.AddDays(1).AddHours(7),
                Location = "Sal 1",
                Instructor = "Sara Nilsson",
                MaxParticipants = 18,
                BookedParticipants = 11
            },
            new()
            {
                Title = "Core och balans",
                StartsAt = DateTime.Today.AddDays(2).AddHours(17).AddMinutes(30),
                Location = "Sal 2",
                Instructor = "Ahmed Hassan",
                MaxParticipants = 16,
                BookedParticipants = 9
            },
            new()
            {
                Title = "HIIT Express",
                StartsAt = DateTime.Today.AddDays(3).AddHours(18),
                Location = "Stora salen",
                Instructor = "Emma Andersson",
                MaxParticipants = 20,
                BookedParticipants = 17
            },
            new()
            {
                Title = "Rörlighet och stretch",
                StartsAt = DateTime.Today.AddDays(5).AddHours(10),
                Location = "Sal 2",
                Instructor = "Jonas Berg",
                MaxParticipants = 14,
                BookedParticipants = 6
            }
        };

        return classes
            .Where(trainingClass => trainingClass.StartsAt >= DateTime.Now)
            .OrderBy(trainingClass => trainingClass.StartsAt)
            .ToList();
    }
}
