using System;
using System.Collections.Generic;
using System.Numerics; // Se usa generalmente para trabajar con vectores y números complejos, pero no se usa en este fragmento.
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase Herviboro que hereda de la clase Animal.
    public class Herviboro : Animal
    {
        // Constructor de la clase Herviboro que recibe los parámetros necesarios.
        public Herviboro(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Animal.
            // Especifica que el tiempo de reproducción es 4 turnos para los herbívoros.
            : base(nombre, posX, posY, 4, safari) // Reproducción cada 4 turnos.
        {
            // No es necesario hacer nada más en este constructor, ya que 'Animal' ya inicializa todas las propiedades relevantes.
        }
    }
}
