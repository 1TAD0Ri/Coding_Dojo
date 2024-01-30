using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModel.Models;
public class User
{
    [Required(ErrorMessage = "Please enter the Name.")]
    [MinLength(2)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the Location.")]
    public string Location { get; set; }

    [Required(ErrorMessage = "Please enter the favorite language.")]
    public string FavLang { get; set; }

    [Required(ErrorMessage = "The comment should be more than 20 characters.")]
    [MinLength(21)]
    public string Comment { get; set; }
}
