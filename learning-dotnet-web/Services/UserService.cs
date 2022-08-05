using learning_dotnet_web.Repositories;
using learning_dotnet_web.Data.Entities;

namespace learning_dotnet_web.Services;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User? Save(User user)
    {
        _userRepository.Save(user);
        return user;
    }

    public User? GetById(int id)
    {
        return _userRepository.GetById(id);
    }

    public User? Update(User user)
    {
        return _userRepository.Update(user);
    }

    public void Delete(int id)
    {
        _userRepository.Delete(id);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }
}