using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramewok;

public class EFLogsDAL : GenericRepositories<Logs>, ILogDAL
{
    public EFLogsDAL(Context context) : base(context)
    {
    }
}