using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramewok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace SampleProjectNoApi.Controllers;

[Authorize(Roles = "Admin")]
public class ViewLogsController : Controller
{
    private readonly ILogService _logService;

    public ViewLogsController(ILogService logService)
    {
        _logService = logService;
    }

    public IActionResult Index(int page = 1, string SearchFor = "")
    {
        var values = _logService
            .GetListQueryableBl(SearchFor)
            .OrderByDescending(y => y.TimeStamp)
            .ToPagedList(page, 10);

        return View(values);
    }

  
}