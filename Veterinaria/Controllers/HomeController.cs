using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Servicios;
namespace Veterinaria.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioGato repositorioGato;

    public HomeController(ILogger<HomeController> logger, IRepositorioGato repositorioGato)
    {
        _logger = logger;
        this.repositorioGato = repositorioGato;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Adoptar()
    {
        var mascotas = repositorioGato.ObtenerGatos();

        return View(mascotas);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

