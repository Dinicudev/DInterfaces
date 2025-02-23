using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase Planta que hereda de la clase Ser.
    public class Planta : Ser
    {
        // Constructor de la clase Planta que recibe los parámetros necesarios.
        public Planta(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Ser.
            // Pasa los parámetros necesarios a la clase base.
            : base(nombre, posX, posY, safari)
        {
            // No es necesario hacer nada más en este constructor,
            // ya que Ser ya inicializa todas las propiedades relevantes.
        }
    }
}
