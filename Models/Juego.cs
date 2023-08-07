class Juego{
    public string _username{get;set;}
    public int _puntajeActual{get;set;}
    public int _cantidadPreguntasCorrectas{get;set;}
    public List<Pregunta> _preguntas{get;set;}
    public List<Respuesta> _respuestas{get;set;}
    public void InicializarJuego(){
        _username = null;
        _puntajeActual = 0;
        _cantidadPreguntasCorrectas = 0;
    }
    public List<Categoria> ObtenerCategorias(){
        List<Categoria> ListaCategorias = new List<Categoria>();
        return ListaCategorias;
    }
    public List<Dificultad> ObtenerDificultades(){
        List<Dificultad> ListaDificultades = new List<Dificultad>();
        return ListaDificultades;
    }
    public void CargarPartida(string username, int dificultad, int categoria){
        
    }
    public void ObtenerProximaPregunta(){
        
    }
    public void ObtenerProximasRespuestas(int idPregunta){

    }
    public void VerificarRespuesta(){
    }
}