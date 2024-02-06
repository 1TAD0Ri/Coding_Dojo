#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;
public class Dish
{
    [Key]
    public int DisheId { get; set; }

    [Required(ErrorMessage = "Enter the Name of dishe")]
    [MinLength(5, ErrorMessage = "The dishe' s must  be more than 5 characters")]
    [Display(Name = "Name of the Dish ")]

    public string Name { get; set; }
    [Required(ErrorMessage = "Enter the sum of calories  of the dish")]
    [Range(0,3000, ErrorMessage = "enter the calories")]
    [Display(Name = "Number of calories ")]




    public int Calories { get; set; }
    [Required(ErrorMessage = "Enter the your Tastiness")]
    [Range(1, 5, ErrorMessage = "Your tastiness is between 1 and 5")]
    public int Tastiness { get; set; }

    // [Required(ErrorMessage = "Enter Your Description for this dishe")]
    // public string Description { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // ! RelationShip : One User can have many Dishes and One Chef can belong to only one single user (OTM)
    public int ChefId { get; set; }
    // Navigation property
    public Chef? Chef { get; set; }

}