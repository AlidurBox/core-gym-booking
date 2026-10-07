using System.ComponentModel.DataAnnotations;

namespace CoreGymBooking.Models;

public class ProfileViewModel
{
    public string? Email { get; set; }

    [Display(Name = "Namn")]
    [StringLength(100, ErrorMessage = "Namnet får vara högst 100 tecken.")]
    public string? Name { get; set; }

    [Display(Name = "Telefonnummer")]
    [StringLength(30, ErrorMessage = "Telefonnumret får vara högst 30 tecken.")]
    [Phone(ErrorMessage = "Ange ett giltigt telefonnummer.")]
    public string? PhoneNumber { get; set; }

    public IReadOnlyList<Booking> Bookings { get; set; } = Array.Empty<Booking>();
}
