namespace learning_dotnet_web.Models;

public class AuthorInfo
{
    private String? name;
    private String? company;
    private String? position;

    public string? Name
    {
        get => name;
        set => name = value;
    }

    public string? Company
    {
        get => company;
        set => company = value;
    }

    public string? Position
    {
        get => position;
        set => position = value;
    }
}