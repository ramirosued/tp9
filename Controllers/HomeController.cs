using Microsoft.AspNetCore.Mvc;

namespace tp9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Bienvenido()
    {
        return View();
    }
    public IActionResult Registro()
    {
        return View();
    }
    public IActionResult CambiarContraseña()
    {
        return View();
    }
}
