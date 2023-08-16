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
   
    public Pregunta ObtenerProximaPregunta(List<Pregunta> listaPreguntas){
    Pregunta preguntarnd;
    //Hacer un numero que se guarde para saber el orden de lista
    return preguntarnd = preguntasAleatorias[0];
     

    }

    public Respuesta ObtenerProximasRespuestas(int idPregunta){
        Pregunta p = ObtenerProximaPregunta();
        idPregunta = _preguntas.IndexOf(p);
        Respuesta respuestarnd;
        return respuestarnd = _respuestas[idPregunta];
    }
    public bool VerificarRespuesta(string Respuesta){
        bool Correcto = true;
        if ( == Respuesta)
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

    public List<Pregunta> aleatorizarList(List<Pregunta> _preguntas){
           Random rnd = new Random();
           List<Pregunta> randomized = _preguntas.OrderBy(item => rnd.Next()).ToList();
           return randomized;
    }
}