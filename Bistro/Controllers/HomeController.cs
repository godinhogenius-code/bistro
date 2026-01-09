using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bistro.Models;
using Bistro.Data;

namespace Bistro.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var featuredItems = MenuData.GetAllItems().Take(4).ToList();
        return View(featuredItems);
    }

    public IActionResult Menu()
    {
        var menuItems = MenuData.GetGroupedByCategory();
        return View(menuItems);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
