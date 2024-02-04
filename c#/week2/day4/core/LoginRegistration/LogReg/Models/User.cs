#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models;


public class User
{
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "Please Enter A First Name")]
    [MinLength(3, ErrorMessage = "The First Name is too short")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }



    [Required(ErrorMessage = "Please Enter A Last Name")]
    [MinLength(3, ErrorMessage = "The Last Name is too short")]
    [Display(Name = "Last Name")]

    public string LastName { get; set; }





    [Required(ErrorMessage = "Please Enter Your Email")]
    [EmailAddress(ErrorMessage = "Please Enter a validated email")]
    
    public string Email { get; set; }





    [Required(ErrorMessage = "Please Enter A Password")]
    [MinLength(6, ErrorMessage = "The Password is not valid ")]
    [DataType(DataType.Password)]
    public string Password { get; set; }





    [NotMapped]
    [Required(ErrorMessage = "Please Enter A Password")]
    [MinLength(6, ErrorMessage = "The Password is not valid ")]
    [Compare("Password", ErrorMessage = "Passwords must match ")]
    [Display(Name = "PW Confirm")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


}

