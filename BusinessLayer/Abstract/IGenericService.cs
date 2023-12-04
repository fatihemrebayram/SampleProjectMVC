using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void AddBl(T t);
        Task AddAsyncBl(T t);
        Task UpdateAsyncBl(T t);

        IQueryable<T> GetListQueryableBl();
        IQueryable<T> GetListQueryableBl(string filter);
        void DeleteBl(T t);
        Task DeleteAsyncBl(T t);
        T TGetById(int id);
        void UpdateBl(T t);
        public Task<T> GetByIdAsyncBl(int id);
    }
}