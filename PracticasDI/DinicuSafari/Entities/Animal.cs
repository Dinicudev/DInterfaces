using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase abstracta Animal que hereda de la clase base Ser
    public abstract class Animal : Ser
    {
        // Propiedad que define el número de turnos (ciclos de tiempo) que necesita un animal para reproducirse.
        public int TurnosParaReproducirse { get; set; } // Tiempo necesario para reproducirse.

        // Propiedad que cuenta cuántos pasos ha dado el animal sin comer. Es un contador.
        public int PasosSinComer { get; set; }          // Contador de pasos sin comer.

        // Constructor de la clase Animal que recibe varios parámetros para inicializar el objeto.
        public Animal(string nombre, int posX, int posY, int turnosParaReproducirse, Safari safari)
            // Llama al constructor de la clase base (Ser) con los parámetros necesarios.
            : base(nombre, posX, posY, safari)
        {
            // Asigna el valor de 'turnosParaReproducirse' a la propiedad correspondiente.
            TurnosParaReproducirse = turnosParaReproducirse;

            // Inicializa PasosSinComer en 0, ya que un animal recién creado no ha dado ningún paso sin comer.
            PasosSinComer = 0;
        }
    }
}
