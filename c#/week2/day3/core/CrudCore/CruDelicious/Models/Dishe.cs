#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CruDelicious.Models;
public class Dishe
{
    [Key]
    public int DisheId { get; set; }

    [Required(ErrorMessage = "Enter the Name of dishe")]
    [MinLength(5, ErrorMessage = "The dishe' s must  be more than 5 characters")]
    [Display(Name = "Name of the Dishe ")]

    public string Name { get; set; }
    [Required(ErrorMessage = "Enter the Name of dishe")]
    [MinLength(5, ErrorMessage = "The dishe' s  cheff must  be more than 5 characters")]
    [Display(Name = "Name of the chef ")]

    public string Chef { get; set; }
    [Required(ErrorMessage = "Enter how much Calories need te dishe")]
    [Range(0, 3000, ErrorMessage = "Calories must be between 0 and 3000 ")]
    [Display(Name = "Number Of Calories of dishes")]




    public int Calories { get; set; }
    [Required(ErrorMessage = "Enter the your Tastiness")]
    [Range(1, 5, ErrorMessage = "Your tastiness is between 1 and 5")]
    public int Tastiness { get; set; }

    [Required(ErrorMessage = "Enter Your Description for this dishe")]
    public string Description { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}