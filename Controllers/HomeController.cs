using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01.Models;

namespace TP01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.Integrantes = grupo.DevolverIntegrantes();
        return View();
    }
    IActionResult SelectIntegrante(int dni)
    {
        Grupo grupo = new Grupo();

    Integrante integrante = grupo.GetIntegrante(dni);

    ViewBag.Integrante = integrante;
    ViewBag.DNI = dni;

    return View("infoIntegrante");
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
