class JugadorR : Jugador
{
    public int tackles { get; set; }

    public JugadorR(string nombre, string deporte, int ta):base (nombre, deporte)
    {
        tackles=ta;
    }

    public override string ToString()
        {
            return "Nombre del jugador : " + nombre + "\nDeporte que practica: RUGBY "+ "\nCantidad de tackles recibidos:" +tackles+"\n";
        }
    
}