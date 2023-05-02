using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Indumentaria.Models;

namespace Indumentaria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
      string induemtaria = ViewBag.EquiposIndumentaria;
      return View("index");
    }

     public IActionResult SelectIndumentaria()
    {
      for(int i = 0; i < 4; i++){
        
      }
      return View("index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
