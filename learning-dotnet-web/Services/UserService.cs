using learning_dotnet_web.Repositories;
using learning_dotnet_web.Data.Entities;

namespace learning_dotnet_web.Services;

public class UserService: GenericService<User>
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository) : base(userRepository)
    {
        _userRepository = userRepository;
    }
}