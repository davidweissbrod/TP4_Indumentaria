
using Microsoft.AspNetCore.Mvc;


namespace Indumentaria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(dictionary equiposIndumentaria)
    {
      ViewBag.equiposIndumentaria = Equipos.IngresarIndumentaria();
      return View("index");
    }
     
     public IActionResult SelectIndumentaria()
    {
      ViewBag.ListaEquipos = Equipos.ListaEquipos;
      ViewBag.ListaMedias = Equipos.ListaMedias;
      ViewBag.ListaPantalones = Equipos.ListaPantalones;
      ViewBag.ListaRemera = Equipos.ListaRemera;
      return View(SelectIndumentaria());
    }

     public IActionResult GuardarIndumentaria(int equipo, int short, int media, int remera)
    {
      Equipos.Indumentaria(medias, pantalon, remera);
      Equipos.IngresarIndumentaria(equipoSeleccionado, Indumentaria item);
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
