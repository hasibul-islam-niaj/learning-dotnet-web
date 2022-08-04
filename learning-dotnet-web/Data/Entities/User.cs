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

    public string? UserName
    {
        get => _name;
        set => _name = value;
    }

    public string? Email
    {
        get => _email;
        set => _email = value;
    }

    public string? Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public string? Designation
    {
        get => _designation;
        set => _designation = value;
    }
}