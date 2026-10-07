namespace CoreGymBooking.Models;

public class UserProfile
{
    public int Id { get; set; }

    public required string UserId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }
}
