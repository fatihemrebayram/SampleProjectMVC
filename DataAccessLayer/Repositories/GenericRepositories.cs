using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class GenericRepositories<T> : IGenericDAL<T> where T : class
{
    private readonly Context _context;

    public GenericRepositories(Context context)
    {
        _context = context;
    }


    public void DeleteDal(T p)
    {
        var deletedEntity = _context.Entry(p);
        deletedEntity.State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public T GetByIdDal(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public T GetDal(Expression<Func<T, bool>> filter)
    {
        return _context.Set<T>().SingleOrDefault(filter);
    }

    public void AddDal(T p)
    {
        var addedEntity = _context.Entry(p);
        addedEntity.State = EntityState.Added;
        _context.SaveChanges();
    }


    public IQueryable<T> ListQueryableDal()
    {
        return _context.Set<T>();
    }

    public IQueryable<T> ListQueryableDal(Expression<Func<T, bool>> filter)
    {
        return _context.Set<T>().Where(filter);
    }

    public void UpdateDal(T p)
    {
        var updatedEntity = _context.Entry(p);
        updatedEntity.State = EntityState.Modified;
        _context.SaveChanges();
    }

    public async Task UpdateAsyncDal(T p)
    {
        var updatedEntity = _context.Entry(p);
        updatedEntity.State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetByIdAsyncDal(int id)
    {
        return await _context.Set<T>().FindAsync(id);

    }

    public async Task DeleteAsyncDal(T p)
    {
        var deletedEntity = _context.Entry(p);
        deletedEntity.State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }

    public async Task AddAsyncDal(T p)
    {
        var addedEntity = _context.Entry(p);
        addedEntity.State = EntityState.Added;
        await _context.SaveChangesAsync();
    }
}