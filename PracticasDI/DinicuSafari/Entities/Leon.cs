using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Entities
{
    // Definición de la clase Leon que hereda de la clase Carnivoro.
    public class Leon : Carnivoro
    {
        // Constructor de la clase Leon que recibe los parámetros necesarios.
        public Leon(string nombre, int posX, int posY, Safari safari)
            // Llama al constructor de la clase base Carnivoro.
            // Pasa los parámetros necesarios a la clase base.
            : base(nombre, posX, posY, safari)
        {
            // No es necesario hacer nada más en este constructor,
            // ya que Carnivoro ya inicializa todas las propiedades relevantes.
        }
    }
}
