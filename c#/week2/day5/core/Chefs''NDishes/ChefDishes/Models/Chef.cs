#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;

public class Chef
{
    [Key]
    public int ChefId { get; set; }
    [Required(ErrorMessage = "Please Enter The First Name")]
    [MinLength(3, ErrorMessage = "The first Name is too short")]
    [Display(Name = "First Name:")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Please Enter The Last Name")]
    [MinLength(3, ErrorMessage = "The Last Name is too short")]
    [Display(Name = "Laste Name:")]

    public string LastName { get; set; }
    [Required(ErrorMessage = "Please enter his date of birth")]
    [Display(Name = "Dtae of Birth:")]

    public DateTime DtaeOfBirth { get; set; }

        // ! Navigation Property
        // MyfavoriteAlbums
    public List<Dish> ChefDishes { get; set; } = new();



}