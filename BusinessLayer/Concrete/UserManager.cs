using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void AddBl(AppUser t)
        {
            _userDAL.AddDal(t);
        }

        public Task AddAsyncBl(AppUser t)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsyncBl(AppUser t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AppUser> GetListQueryableBl()
        {
            return _userDAL.ListQueryableDal();
        }

        public IQueryable<AppUser> GetListQueryableBl(string filter)
        {
            throw new NotImplementedException();
        }

        public void DeleteBl(AppUser t)
        {
           _userDAL.DeleteDal(t);
        }

        public Task DeleteAsyncBl(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            return _userDAL.GetByIdDal(id);
        }

        public void UpdateBl(AppUser t)
        {
           _userDAL.UpdateDal(t);
        }

        public Task<AppUser> GetByIdAsyncBl(int id)
        {
            throw new NotImplementedException();
        }
    }
}