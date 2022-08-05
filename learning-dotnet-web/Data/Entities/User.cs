using System.ComponentModel.DataAnnotations;

namespace learning_dotnet_web.Data.Entities;

public class User
{
    private int _id;
    private string? _name;
    private string? _email;
    private string? _phone;
    private string? _designation;

    [Key]
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    [Required]
    [MinLength(2, ErrorMessage = "Minimum 3 characters required.")]
    public string? UserName
    {
        get => _name;
        set => _name = value;
    }

    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [MinLength(3, ErrorMessage = "Minimum 3 characters required.")]
    [MaxLength(255, ErrorMessage = "Can be maximum 255 character.")]
    public string? Email
    {
        get => _email;
        set => _email = value;
    }

    [MinLength(6, ErrorMessage = "Minimum 6 digits required.")]
    [MaxLength(25, ErrorMessage = "Can be maximum 25 digit.")]
    public string? Phone
    {
        get => _phone;
        set => _phone = value;
    }

    [MinLength(3, ErrorMessage = "Minimum 3 characters required.")]
    [MaxLength(30, ErrorMessage = "Can be maximum 30 characters length.")]
    public string? Designation
    {
        get => _designation;
        set => _designation = value;
    }
}