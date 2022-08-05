using learning_dotnet_web.Data;
using Microsoft.EntityFrameworkCore;

namespace learning_dotnet_web.Repositories;

public class GenericRepository<T> where T : class
{
    private readonly LearningContext _context;
    private readonly DbSet<T> _table;

    protected GenericRepository(LearningContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }
    
    public T? Save(T? entity)
    {
        if (entity == null) 
            return entity;
        
        _table.Add(entity);
        _context.SaveChanges();
        return entity;
    }
    
    public T? GetById(int id)
    {
        T? entity = _table.Find(id);
        return entity;
    }
    
    public T Update(T entity)
    {
        _table.Update(entity);
        _context.SaveChanges();
        return entity;
    }
    
    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }
    }
    
    public List<T> GetAll()
    {
        return _table.ToList();
    }
}