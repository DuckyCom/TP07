class Juego{
    public string _username{get;set;}
    public int _puntajeActual{get;set;}
    public int _cantidadPreguntasCorrectas{get;set;}
    public List<Pregunta> _preguntas{get;set;}
    public List<Respuesta> _respuestas{get;set;}
    public void InicializarJuego(){

    }
    public void ObtenerCategorias(){}
    public void ObtenerDificultades(){}
    public void CargarPartida(string username, int dificultad, int categoria){}
    public void ObtenerProximaPregunta(){
    }
    public void ObtenerProximasRespuestas(int idPregunta){}
    public void VerificarRespuesta(){
    }
}