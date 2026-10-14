using System.ComponentModel.DataAnnotations;

namespace CoreGymBooking.Models;

public class TrainingClassViewModel
{
    [Required(ErrorMessage = "Ange en titel.")]
    [StringLength(100, ErrorMessage = "Titeln får vara högst 100 tecken.")]
    [Display(Name = "Titel")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ange en beskrivning.")]
    [StringLength(1000, ErrorMessage = "Beskrivningen får vara högst 1000 tecken.")]
    [Display(Name = "Beskrivning")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ange datum och tid.")]
    [DataType(DataType.DateTime)]
    [Display(Name = "Datum och tid")]
    public DateTime StartsAt { get; set; } = DateTime.Today.AddDays(1).AddHours(18);

    [Required(ErrorMessage = "Ange en plats.")]
    [StringLength(100, ErrorMessage = "Platsen får vara högst 100 tecken.")]
    [Display(Name = "Plats")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ange en instruktör.")]
    [StringLength(100, ErrorMessage = "Instruktörens namn får vara högst 100 tecken.")]
    [Display(Name = "Instruktör")]
    public string Instructor { get; set; } = string.Empty;

    [Range(1, 200, ErrorMessage = "Max antal deltagare måste vara mellan 1 och 200.")]
    [Display(Name = "Max antal deltagare")]
    public int MaxParticipants { get; set; } = 15;
}
