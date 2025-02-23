using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase Carnivoro que hereda de la clase Animal.
    public class Carnivoro : Animal
    {
        // Constructor de la clase Carnivoro que recibe los parámetros necesarios.
        public Carnivoro(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Animal. 
            // Especifica que el tiempo de reproducción es 6 turnos para los carnívoros.
            : base(nombre, posX, posY, 6, safari) // Reproducción cada 6 turnos.
        {
            // No es necesario hacer nada más en el constructor, ya que 'Animal' ya inicializa todas las propiedades relevantes.
        }
    }
}
