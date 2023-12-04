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
    public class LogManager : ILogService
    {
        private ILogDAL _logService;

        public LogManager(ILogDAL logService)
        {
            _logService = logService;
        }

     

     
     
        public void AddBl(Logs t)
        {
           _logService.AddDal(t);
        }

        public Task AddAsyncBl(Logs t)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsyncBl(Logs t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Logs> GetListQueryableBl()
        {
            return _logService.ListQueryableDal();
        }

        public IQueryable<Logs> GetListQueryableBl(string filter)
        {
            return _logService.ListQueryableDal(x => x.MessageTemplate.Contains(filter) ||
                                                     x.Level.Contains(filter) ||
                                                     x.Message.Contains(filter) ||
                                                     x.TimeStamp.ToString().Contains(filter) ||
                                                     x.UserDomainNamePC.Contains(filter) ||
                                                     x.Username.Contains(filter) ||
                                                     x.UserNamePC.Contains(filter));
        }

        public void DeleteBl(Logs t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsyncBl(Logs t)
        {
            throw new NotImplementedException();
        }

        public Logs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBl(Logs t)
        {
            throw new NotImplementedException();
        }

        public Task<Logs> GetByIdAsyncBl(int id)
        {
            throw new NotImplementedException();
        }
    }
}