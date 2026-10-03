namespace CoreGymBooking.Models;

public class TrainingClass
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public DateTime StartsAt { get; set; }

    public required string Location { get; set; }

    public required string Instructor { get; set; }

    public int MaxParticipants { get; set; }

    public int BookedParticipants { get; set; }

    public int AvailableSpots => Math.Max(0, MaxParticipants - BookedParticipants);
}
