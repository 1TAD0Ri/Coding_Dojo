#pragma warning disable CSC868
using System.ComponentModel.DataAnnotations;

public class DateModel
{
    [Required(ErrorMessage = "Please enter a date.")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; }
}







public class PastDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is DateTime date)
        {
            return date < DateTime.Now;
        }

        return false;
    }
}
