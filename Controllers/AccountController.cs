using Microsoft.AspNetCore.Mvc;
using tp9.Models;
namespace tp9.Controllers;

public class Account : Controller
{
    public IActionResult Registro(Usuario us)
    {
        BD.CrearUsuario(us);
        return RedirectToAction("Bienvenido","Home");
    }

    [HttpPost]
    public IActionResult Login(string username, string contraseña)
    {
        string contra;
        contra=BD.GetContraseñaPorUsername(username);
        if(contra==contraseña){
            return RedirectToAction("Bienvenido","Home");
        }else
        {
            return RedirectToAction("Index","Home");
        }
    }

    public IActionResult CambiarContraseña(string username, string nuevaContraseña)
    {
        BD.CambiarContraseña(username,nuevaContraseña);
        return RedirectToAction("Bienvenido","Home");
    }
}
