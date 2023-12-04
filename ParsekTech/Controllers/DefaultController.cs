using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SampleProjectNoApi.Controllers;

public class DefaultController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IUserService _userService;

    public DefaultController(UserManager<AppUser> userManager, IUserService userService)
    {
        _userManager = userManager;
        _userService = userService;
    }

    public IActionResult AccessDenied()
    {
        return PartialView();
    }

    public PartialViewResult AdminHeader()
    {
        return PartialView();
    }

    public PartialViewResult AdminSidebar()
    {
        return PartialView();
    }
}