using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase Gacela que hereda de la clase Herviboro.
    public class Gacela : Herviboro
    {
        // Constructor de la clase Gacela que recibe los parámetros necesarios.
        public Gacela(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Herviboro.
            // Pasa los parámetros necesarios a la clase base.
            : base(nombre, posX, posY, safari)
        {
            // No es necesario hacer nada adicional en este constructor por ahora,
            // ya que Herviboro ya inicializa todas las propiedades relevantes.
        }
    }
}
