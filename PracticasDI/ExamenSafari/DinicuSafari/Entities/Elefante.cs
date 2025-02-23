using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Examen 1 Creamos la clase del Elefante 
    public class Elefante : Herviboro
    {
        // Constructor de la clase Gacela que recibe los parámetros necesarios.
        public Elefante(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Herviboro.
            // Pasa los parámetros necesarios a la clase base.
            : base(nombre, posX, posY, safari)
        {
            // No es necesario hacer nada adicional en este constructor por ahora,
            // ya que Herviboro ya inicializa todas las propiedades relevantes.
        }
    }
}
