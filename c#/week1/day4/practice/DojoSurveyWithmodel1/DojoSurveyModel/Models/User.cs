using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModel.Models;
public class User
{
    public string Name {get;set;}
    public string Location {get;set;}
    public string FavLang {get;set;}
    public string? Comment {get;set;}
}