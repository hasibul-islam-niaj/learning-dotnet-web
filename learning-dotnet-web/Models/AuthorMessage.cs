using System.ComponentModel.DataAnnotations;

namespace learning_dotnet_web.Models;

public class AuthorMessage
{
    private string? name;
    private string? message;

    [Required(ErrorMessage = "Name can not be empty.")]
    [MinLength(5, ErrorMessage = "Minimum length required 5.")]
    public string? Name
    {
        get => name;
        set => name = value;
    }

    [Required(ErrorMessage = "Message can not be empty.")]
    [MinLength(2, ErrorMessage = "Minimum length required 2.")]
    public string? Message
    {
        get => message;
        set => message = value;
    }
}