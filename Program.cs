using System;

namespace myFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //INSTANCIA
            var jugador =new Persona();
            Console.WriteLine("Nombre de jugador:");
            Console.WriteLine(jugador.nombre="Leonel");

            var juez =new Persona();
            Console.WriteLine("Nombre de Arbitro:");
            Console.WriteLine(juez.nombre="Omar");

            Cancha Old = new Cancha();
            Old.Sostener();

            Camiseta Manchester = new Camiseta();
            Manchester.Vestir();

            Botines Nike = new Botines();
            Nike.Proteger();

            Console.WriteLine("Clase MyFutbol");
            Balon adidas = new Balon();
            adidas.Inflar();
        }
    }
}
