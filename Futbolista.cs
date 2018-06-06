using System;
//HERENCUA
class Futbolista:Persona
    {
         
            string posicion ="Delantero";
            

    //CONSTRUCTOR
    Futbolista(string nombre){
        this.nombre=nombre;
    }
            
            public void Jugar()
            {
               Console.WriteLine("El futbolista está jugando");
                //TODO = Por hacer
            }
    }