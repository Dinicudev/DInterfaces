using System;

namespace DinicuSafari.Entities
{
    // Clase base abstracta que representa un "ser" en el safari. 
    // Los seres pueden ser animales o plantas, y esta clase contiene los atributos y métodos comunes para todos ellos.
    public abstract class Ser
    {
        public string Nombre { get; set; } // Nombre único del ser, utilizado para identificarlo.
        public int PosX { get; set; }      // Posición X en el tablero, es decir, su ubicación horizontal en el safari.
        public int PosY { get; set; }      // Posición Y en el tablero, es decir, su ubicación vertical en el safari.
        public int Edad { get; set; }      // Edad en turnos, que indica cuántos turnos ha vivido el ser.
        protected Safari Safari { get; set; } // Referencia al safari en el que se encuentra el ser.

        // Constructor que inicializa los valores del ser: nombre, posición, edad (empieza en 0) y safari.
        public Ser(string nombre, int posX, int posY, Safari safari)
        {
            Nombre = nombre;      // Asigna el nombre al ser.
            PosX = posX;          // Asigna la posición X en el tablero.
            PosY = posY;          // Asigna la posición Y en el tablero.
            Edad = 0;             // Inicializa la edad a 0, ya que acaba de nacer.
            Safari = safari;      // Establece la referencia al safari al que pertenece el ser.
        }

        // Método ToString() que proporciona una representación en forma de cadena del ser.
        // Devuelve una cadena con el nombre, tipo de ser (animal, planta, etc.), su posición y su edad.
        public override string ToString()
        {
            return $"{Nombre} ({GetType().Name}) en ({PosX}, {PosY}), Edad: {Edad}";
        }
    }
}
