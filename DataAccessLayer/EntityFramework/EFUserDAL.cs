using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EFUserDAL : GenericRepositories<AppUser>, IUserDAL
{
    public EFUserDAL(Context context) : base(context)
    {
    }
}