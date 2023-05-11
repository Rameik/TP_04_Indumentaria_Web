using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_04_Indumentaria_Web.Models;

namespace TP_04_Indumentaria_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        ViewBag.IndumentariaEquipos = Equipos.equiposIndumentaria;
        return View("Index");
    }

    public IActionResult BuscarIndumentaria(string busqueda)
    {
        ViewBag.busqueda = busqueda;
        ViewBag.IndumentariaEquipos = Equipos.equiposIndumentaria;
        return View("BuscarIndumentaria");
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.listaEquipos;
        ViewBag.ListaMedias = Equipos.listaMedias;
        ViewBag.ListaPantalones = Equipos.listaPantalones;
        ViewBag.ListaRemeras = Equipos.listaRemeras;
 
        return View("SelectIndumentaria");
    }
    public IActionResult GuardarIndumentaria(string equipo, string media, string pantalon, string remera)
    {
        if(equipo == null || media == null || pantalon == null || remera == null){
            ViewBag.Error = "Ha ocurrido un error. Alguno de los datos no fueron ingresados";
            ViewBag.ListaEquipos = Equipos.listaEquipos;
            ViewBag.ListaMedias = Equipos.listaMedias;
            ViewBag.ListaPantalones = Equipos.listaPantalones;
            ViewBag.ListaRemeras = Equipos.listaRemeras;
            return View("SelectIndumentaria");
        }
        else{
            Indumentaria unaIndumentaria = new Indumentaria(media, pantalon, remera);
            ViewBag.Existe = Equipos.ingresarIndumentaria(equipo, unaIndumentaria);
            if(ViewBag.Existe == true){
                ViewBag.ListaEquipos = Equipos.listaEquipos;
                ViewBag.ListaMedias = Equipos.listaMedias;
                ViewBag.ListaPantalones = Equipos.listaPantalones;
                ViewBag.ListaRemeras = Equipos.listaRemeras;
                return View("SelectIndumentaria");
            }
            else{
                ViewBag.IndumentariaEquipos = Equipos.equiposIndumentaria;
                return View("Index");
            }
        }
        
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}
