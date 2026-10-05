using System.ComponentModel.DataAnnotations;

namespace CoreGymBooking.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Ange din e-postadress.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    [Display(Name = "E-post")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ange ett lösenord.")]
    [DataType(DataType.Password)]
    [Display(Name = "Lösenord")]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Display(Name = "Upprepa lösenord")]
    [Compare(nameof(Password), ErrorMessage = "Lösenorden stämmer inte överens.")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
