using System;
using System.Collections.Generic;
/*public class Program 
{
        public static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            string n, dep;
            Console.WriteLine("Ingrese nombre del jugador");
            n=Console.ReadLine();
            Console.WriteLine("Ingrese deporte que practica");
            dep=Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de triples encestados:");
            int tri=Convert.ToInt32(Console.ReadLine());
            jugadores.Add(new JugadorB(n,dep,tri));
            foreach(JugadorB a in jugadores){
                Console.WriteLine(a);
            }
            

        }
}*/


public class program{
    public static void Main(string[] args)
    {
        string nombre;
        int triples, tackles;
        List <Jugador> jugadores=new List<Jugador>();
        int seleccion=0;
        do{
            Console.WriteLine("INGRESE UNA OPCION \n1-Ingresar jugador. \n2-Ingresar jugador de basquet. \n3-Ingresar jugador de rugby. \n4-Mostrar jugadores ingresados. \n5-Salir");
            seleccion = Convert.ToInt32(Console.ReadLine());
        switch(seleccion)
            {
                case 1: Console.WriteLine("INGRESE NOMBRE DEL JUGADOR:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("INGRESE DEPORTE QUE PRACTICA:");
                        string dep= Console.ReadLine();
                        jugadores.Add(new Jugador(nombre, dep));
                        break;
                case 2: Console.WriteLine("INGRESE NOMBRE DEL JUGADOR DE BASQUET");
                        nombre=Console.ReadLine();
                        Console.WriteLine("INGRESE LA CANTIDAD DE TRIPLES ENCESTADOS");
                        triples=Convert.ToInt32(Console.ReadLine());
                        jugadores.Add(new JugadorB(nombre,"BASQUET", triples));
                        break;
                case 3: Console.WriteLine("INGRESE NOMBRE DEL JUGADOR DE RUGBY");
                        nombre=Console.ReadLine();
                        Console.WriteLine("INGRESE LA CANTIDAD DE TACKLES RECIBIDOS");
                        tackles=Convert.ToInt32(Console.ReadLine());
                        jugadores.Add(new JugadorR(nombre, "RUGBY", tackles));
                        break;
                case 4: foreach(Jugador a in jugadores){
                        Console.WriteLine(a);}
                        break;
                default:
                        break;
            }}while(seleccion!=5);
    
}
}