using learning_dotnet_web.Models;

namespace learning_dotnet_web.Services.Home;

public class AuthorService
{
    public AuthorInfo GetAuthorInfo()
    {
        AuthorInfo authorInfo = new AuthorInfo();
        authorInfo.Name = "Hasibul Islam";
        authorInfo.Position = "Software Engineer";
        authorInfo.Company = "Brain Station - 23 Ltd.";
        
        return authorInfo;
    }
}