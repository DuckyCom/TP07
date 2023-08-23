using TP07.Models;
class Juego{
    private string _username{get;set;}
    private int _puntajeActual{get;set;}
    private int _cantidadPreguntasCorrectas{get;set;}
    private List<Pregunta> _preguntas{get;set;}
    private List<Respuesta> _respuestas{get;set;}
    public void InicializarJuego(){
        Juego configurar;
        _username = null;
        _puntajeActual = 0;
        _cantidadPreguntasCorrectas = 0;
    }
    public List<Categoria> ObtenerCategorias(){
        return BD.ObtenerCategorias();
    }
    public List<Dificultad> ObtenerDificultades(){
        return BD.ObtenerDificultades();
    }
    public void CargarPartida(string username, int dificultad, int categoria){
        ObtenerDificultades();
        ObtenerCategorias();
        _preguntas = BD.ObtenerPreguntas(dificultad,categoria);
        _respuestas = BD.ObtenerRespuestas(_preguntas);
    }
   
    public Pregunta ObtenerProximaPregunta(){
        Pregunta preguntarnd;
        return preguntarnd = _preguntas[0];
    }
    public List<Respuesta> ObtenerProximasRespuestas(int idPregunta){
        List<Respuesta> respuestas = new List<Respuesta>{};
        foreach (var item in _respuestas)
        {
            if (item.IdPregunta == idPregunta)
            {
                respuestas.Add(item);
            }
        }
        return respuestas;
    }
    public bool VerificarRespuesta(int idPregunta, Respuesta respuesta){
        bool v;
        if(respuesta.Correcta){
            _puntajeActual+=5;
            _preguntas.RemoveAt(0);
            v = true;
        }
        else{
            v = false;
        }
        return v;
    }
}

