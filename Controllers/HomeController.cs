using Microsoft.AspNetCore.Mvc;

namespace TP07.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ConfigurarJuego(){
        return View();
    }
    public IActionResult Comenzar(string username,int dificultad,int categoria){
        return View();
    }
    public IActionResult Jugar(){
        return View();
    }
    [HttpPost]public IActionResult VerificarRespuesta(int idPregunta,int idRespuesta){
        return View();
    }
    
}
