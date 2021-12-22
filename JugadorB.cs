class JugadorB: Jugador
{
    public int triples { get; set; }

    public JugadorB(string nombre, string deporte, int t): base(nombre, deporte)
    {
        triples = t;
    }

    public override string ToString()
        {
            return "Nombre del jugador : " + nombre + "\nDeporte que practica: BASQUET "+ "\nCantidad de triples encestados:" +triples+"\n";
        }
    
}
