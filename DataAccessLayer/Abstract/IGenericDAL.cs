using System.Linq.Expressions;

namespace DataAccessLayer.Abstract;

public interface IGenericDAL<T>
{
    void DeleteDal(T p);
    Task DeleteAsyncDal(T p);

    T GetByIdDal(int id);

    T GetDal(Expression<Func<T, bool>> filter);

    void AddDal(T p);
    Task AddAsyncDal(T p);

    IQueryable<T> ListQueryableDal();


    IQueryable<T> ListQueryableDal(Expression<Func<T, bool>> filter);

    void UpdateDal(T p);
    Task UpdateAsyncDal(T p);
    public Task<T> GetByIdAsyncDal(int id);
}