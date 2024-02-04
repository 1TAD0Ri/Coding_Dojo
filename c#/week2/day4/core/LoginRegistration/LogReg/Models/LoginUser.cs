#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace LogReg.Models;

public class LoginUser
{
    //Email
    [Required(ErrorMessage ="Please enter your email")]
    [EmailAddress(ErrorMessage ="Please enter a vali Email")]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    //password
    [Required(ErrorMessage ="Please enter your passwoord")]
    [MinLength(6,ErrorMessage ="Please enter a valid password")]
    [Display(Name ="Password")]
    [DataType(DataType.Password)]
    public string  LoginPassword { get; set; }
}