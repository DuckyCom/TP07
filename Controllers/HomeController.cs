using Microsoft.AspNetCore.Mvc;
using TP07.Models;
namespace TP07.Controllers;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult ConfigurarJuego(){
        ViewBag.ConfigurarJuego = Juego.InicializarJuego();
       return View("Juego");
    }
    public IActionResult Comenzar(string username,int dificultad,int categoria){
        return View();
    }
    public IActionResult Jugar(){
        return View();
    }
    [HttpPost]public IActionResult VerificarRespuesta(int idPregunta,Respuesta respuesta){
        return View();
    }
    
}
