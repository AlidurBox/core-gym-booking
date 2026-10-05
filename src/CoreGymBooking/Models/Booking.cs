namespace CoreGymBooking.Models;

public class Booking
{
    public int Id { get; set; }

    public required string UserId { get; set; }

    public int TrainingClassId { get; set; }

    public TrainingClass? TrainingClass { get; set; }

    public DateTime CreatedAt { get; set; }
}
