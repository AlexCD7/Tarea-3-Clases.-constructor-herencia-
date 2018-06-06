using System;
//HERENCIA
class Arbitro:Persona
    {
         
            string posicion="Central";
            //CONSTRUCTOR
            Arbitro(string nombre){
            this.nombre=nombre;
    }
            
            public void CumplirReglas()
            {
               Console.WriteLine("El futbolista está jugando");
                //TODO = Por hacer
            }
    }