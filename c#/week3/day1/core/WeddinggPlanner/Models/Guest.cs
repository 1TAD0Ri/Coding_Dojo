using System.ComponentModel.DataAnnotations;

namespace WeddinggPlanner.Models;

public class Guest
{
    [Key]
    public int GuestId { get; set; }
    [Required]
    public int WeddingId { get; set; }
    [Required]
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

//Navigation Properties
    public User? User { get; set; }
    public Wedding? Wedding { get; set; }

    // public static explicit operator Guest(List<Guest> v)
    // {
    //     throw new NotImplementedException();
    // }
}