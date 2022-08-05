using learning_dotnet_web.Data;
using learning_dotnet_web.Data.Entities;

namespace learning_dotnet_web.Repositories;

public class UserRepository: GenericRepository<User>
{
    public UserRepository(LearningContext context) : base(context)
    {
    }
}