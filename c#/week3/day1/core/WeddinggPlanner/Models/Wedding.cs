using System.ComponentModel.DataAnnotations;

namespace WeddinggPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId { get; set; }
    // **************************************************************

    [Required]
    [MinLength(2)]
    [Display(Name ="Wedder One")]
    public string WedderOne{ get; set; }
    // **************************************************************

    [Required]
    [MinLength(2)]
    [Display(Name ="Wedder Two")]
    public string WedderTwo { get; set; }
    // **************************************************************

    [WeddingFuture]
    [Required]
    public DateTime Date { get; set; }
    // **************************************************************

    [Required]
    [MinLength(2)]
    public string Address { get; set; }
    // **************************************************************
    [Required]
    public int UserId { get; set; }
    // **************************************************************

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    // **************************************************************
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

//Navigation Properties
    public User? Owner { get; set; }
    public List<Guest> MyGuests { get; set; } = new();

//Custom Validation
    public class WeddingFutureAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((DateTime)value< DateTime.Now)
        {
            return new ValidationResult("Wedding Date should be in the future.");
        } else {
            return ValidationResult.Success;
        }
    }
}
}