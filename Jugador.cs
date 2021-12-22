class Jugador
{
    public string nombre { get; set; }
    public string deporte { get; set; }
    
    public Jugador(string n, string dep)
    {
        nombre = n;
        deporte = dep;
    }
    public override string ToString()
        {
            return "Nombre del jugador : " + nombre + "\nDeporte que practica: " + deporte+"\n";
        }
    

}