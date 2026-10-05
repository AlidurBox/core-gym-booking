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

    public List<Booking> Bookings { get; set; } = new();

    public int AvailableSpots => Math.Max(0, MaxParticipants - Bookings.Count);

    public bool IsFull => Bookings.Count >= MaxParticipants;
}
