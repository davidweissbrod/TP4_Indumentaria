
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
      return View("Index");
    }
     
     public IActionResult SelectIndumentaria()
    {
      ViewBag.listaEquipos = Equipos.listaEquipos;
      ViewBag.listaMedias = Equipos.listaMedias;
      ViewBag.listaPantalones = Equipos.listaPantalones;
      ViewBag.listaRemera = Equipos.listaRemera;
      return View("SelectIndumentaria");
    }

     public IActionResult GuardarIndumentaria(int equipo, int pantalon, int media, int remera)
    {
      Indumentaria nuevo = new Indumentaria(medias, pantalon, remera);
      Equipos.IngresarIndumentaria(equipo, nuevo);
      return View("Index");
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
