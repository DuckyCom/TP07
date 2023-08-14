using TP07.Models;
class Juego{
    private string _username{get;set;}
    private int _puntajeActual{get;set;}
    private int _cantidadPreguntasCorrectas{get;set;}
    private List<Pregunta> _preguntas{get;set;}
    private List<Respuesta> _respuestas{get;set;}
    public void InicializarJuego(){
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
        Random rnd = new Random();
        int num = rnd.Next(1, _preguntas.Count());
        return preguntarnd = _preguntas[num];

    }
    public void ObtenerProximasRespuestas(int idPregunta){
        Pregunta p = ObtenerProximaPregunta();
        int num = _preguntas.IndexOf(p);
        


    }
    public bool VerificarRespuesta(string Respuesta){
        bool Correcto = true;
        if (/* me acuerdo de como hacerlo con array que era con [i], como es con list */== Respuesta)
        {
            _puntajeActual++;
            _cantidadPreguntasCorrectas++;
            Correcto = true;
        }
        else
        {
            Correcto = false;
        }
        //falta eliminar por parametro la pregunta [se elimina independientemente del resultado]
        return Correcto;
    }
}