using learning_dotnet_web.Repositories;

namespace learning_dotnet_web.Services;

public class GenericService<T> where T : class
{
    private readonly GenericRepository<T> _repository;

    protected GenericService(GenericRepository<T> repository)
    {
        _repository = repository;
    }
    
    public T? Save(T entity)
    {
        _repository.Save(entity);
        return entity;
    }
    
    public T? GetById(int id)
    {
        return _repository.GetById(id);
    }
    
    public T? Update(T entity)
    {
        return _repository.Update(entity);
    }
    
    public void Delete(int id)
    {
        _repository.Delete(id);
    }
    
    public List<T> GetAll()
    {
        return _repository.GetAll();
    }
}