using DinicuSafari.Controller;
using System;
using System.Collections.Generic;

namespace DinicuSafari.Entities
{
    // Clase principal que representa el safari. Aquí es donde se manejan todos los seres vivos en el ecosistema.
    public class Safari
    {
        private List<Ser> listaDeSeres; // Lista de todos los seres en el safari. Aquí guardamos todos los animales y plantas.
        private int tamanioX; // Ancho del tablero, que representa el tamaño en el eje X.
        private int tamanioY; // Alto del tablero, que representa el tamaño en el eje Y.

        private int reproducciones; // Contador para llevar un registro de cuántas reproducciones han ocurrido.
        private int muertes;        // Contador para llevar un registro de cuántas muertes han ocurrido.

        private Random random; // Generador de números aleatorios, se usa para mover a los animales o generar posiciones.

        // Constructor de la clase Safari. Recibe el tamaño del tablero (X y Y).
        public Safari(int tamanioX, int tamanioY)
        {
            this.tamanioX = tamanioX; // Inicializa el tamaño X del safari.
            this.tamanioY = tamanioY; // Inicializa el tamaño Y del safari.
            listaDeSeres = new List<Ser>(); // Inicializa la lista vacía para los seres.
            reproducciones = 0; // Comienza con 0 reproducciones.
            muertes = 0;        // Comienza con 0 muertes.
            random = new Random(); // Inicializa el generador aleatorio.
        }

        // Método para agregar un ser (animal o planta) al safari.
        public void AgregarSer(Ser ser)
        {
            listaDeSeres.Add(ser); // Simplemente agregamos el ser a la lista de seres en el safari.
        }

        // Método para remover un ser (cuando muere).
        public void RemoverSer(Ser ser)
        {
            listaDeSeres.Remove(ser); // Remueve el ser de la lista de seres.
            muertes++; // Incrementa el contador de muertes.
        }

        // Este método devuelve el estado actual del safari (el tablero) como una matriz 2D de strings.
        public string[,] ObtenerEstado()
        {
            string[,] tablero = new string[tamanioX, tamanioY]; // Creamos una matriz vacía para representar el tablero.

            // Inicializamos todo el tablero con "Vacío".
            for (int i = 0; i < tamanioX; i++)
            {
                for (int j = 0; j < tamanioY; j++)
                {
                    tablero[i, j] = "Vacío"; // Esto representa que en todas las posiciones inicialmente no hay nada.
                }
            }

            // Ahora llenamos el tablero con los seres que están en sus respectivas posiciones.
            foreach (var ser in listaDeSeres)
            {
                if (ser is Planta)
                    tablero[ser.PosX, ser.PosY] = "Planta"; // Si el ser es una planta, lo marcamos en el tablero.
                else if (ser is Herviboro)
                    tablero[ser.PosX, ser.PosY] = "Herviboro"; // Si es un herbívoro, lo marcamos.
                else if (ser is Carnivoro)
                    tablero[ser.PosX, ser.PosY] = "Carnivoro"; // Si es un carnívoro, lo marcamos.
            }

            return tablero; // Devolvemos el estado actual del tablero.
        }

        // Este método se llama al final de cada turno para ejecutar las acciones correspondientes.
        public void EjecutarTurno()
        {
            Console.WriteLine("---- Nuevo Turno ----");

            // Hacemos una copia de la lista de seres para evitar modificar la lista mientras iteramos.
            foreach (var ser in new List<Ser>(listaDeSeres))
            {
                ser.Edad++; // Incrementamos la edad de todos los seres (todos envejecen al mismo tiempo).

                // Si el ser es un animal, tratamos de moverlo y verificar si puede reproducirse o morir.
                if (ser is Animal animal)
                {
                    Console.WriteLine($"{animal.Nombre} (Edad: {animal.Edad}) está en ({animal.PosX}, {animal.PosY}).");
                    MoverAnimal(animal); // Movemos al animal.

                    // Si el animal lleva 3 pasos sin comer, muere de hambre.
                    if (animal.PasosSinComer >= 3)
                    {
                        Console.WriteLine($"{animal.Nombre} murió de hambre.");
                        RemoverSer(animal); // Removemos al animal muerto.
                        continue; // Pasamos al siguiente ser.
                    }

                    // Intentamos reproducir al animal si ha llegado al turno adecuado.
                    if (animal.Edad % animal.TurnosParaReproducirse == 0)
                    {
                        ReproducirAnimal(animal); // Intentamos reproducir al animal.
                        Console.WriteLine($"{animal.Nombre} ha reproducido.");
                    }
                }
                else if (ser is Planta planta)
                {
                    // Si el ser es una planta, intentamos reproducirla si ha llegado al turno adecuado.
                    Console.WriteLine($"{planta.Nombre} está en ({planta.PosX}, {planta.PosY}).");
                    if (planta.Edad % 2 == 0) // Las plantas se reproducen cada 2 turnos.
                    {
                        ReproducirPlanta(planta); // Intentamos reproducir la planta.
                        Console.WriteLine($"{planta.Nombre} se ha reproducido.");
                    }
                }
            }
            Console.WriteLine("---- Fin del Turno ----");
        }

        // Método para mover un animal en el tablero. Busca comida y si la encuentra, mueve al animal hacia allí.
        private void MoverAnimal(Animal animal)
        {
            var comida = BuscarComida(animal); // Busca comida para el animal.
            if (comida != null)
            {
                animal.PosX = comida.PosX; // Mueve al animal a la posición de la comida.
                animal.PosY = comida.PosY;
                animal.PasosSinComer = 0; // Resetea el contador de hambre.
                RemoverSer(comida); // Remueve la comida del safari.
                Console.WriteLine($"{animal.Nombre} comió a {comida.Nombre}."); // Muestra en consola que el animal ha comido.
            }
            else
            {
                // Si no hay comida, el animal se mueve aleatoriamente.
                var nuevaPos = GenerarPosicionAdyacente(animal.PosX, animal.PosY);
                if (nuevaPos != null)
                {
                    animal.PosX = nuevaPos.Value.Item1;
                    animal.PosY = nuevaPos.Value.Item2;
                }
                animal.PasosSinComer++; // Aumentamos el contador de pasos sin comer.
                Console.WriteLine($"{animal.Nombre} se movió a otro sitio.");
            }
        }

        // Este método maneja la reproducción de un animal, creando una cría en una nueva posición adyacente.
        private void ReproducirAnimal(Animal animal)
        {
            var nuevaPos = GenerarPosicionAdyacente(animal.PosX, animal.PosY); // Genera una posición adyacente para la cría.
            if (nuevaPos != null)
            {
                // Creamos la cría usando el mismo tipo que el animal (ej. si es un león, la cría será un león).
                var cria = Activator.CreateInstance(animal.GetType(), $"{animal.Nombre} Jr", nuevaPos.Value.Item1, nuevaPos.Value.Item2, this) as Animal;
                if (cria != null)
                {
                    AgregarSer(cria); // Agregamos la cría al safari.
                    reproducciones++; // Incrementamos el contador de reproducciones.
                    Console.WriteLine($"{animal.Nombre} creó una cría en ({nuevaPos.Value.Item1}, {nuevaPos.Value.Item2}).");
                }
            }
        }

        // Este método maneja la reproducción de una planta en una nueva posición adyacente.
        private void ReproducirPlanta(Planta planta)
        {
            var nuevaPos = GenerarPosicionAdyacente(planta.PosX, planta.PosY); // Genera una posición adyacente para la nueva planta.
            if (nuevaPos != null)
            {
                // Creamos una nueva planta en la posición adyacente.
                var nuevaPlanta = new Planta($"Planta{reproducciones}", nuevaPos.Value.Item1, nuevaPos.Value.Item2, this);
                AgregarSer(nuevaPlanta); // Agregamos la nueva planta al safari.
                reproducciones++; // Incrementamos el contador de reproducciones.
                Console.WriteLine($"La planta {planta.Nombre} creó una nueva planta.");
            }
        }

        // Busca comida para un animal en el safari. Retorna el ser que puede ser comida si está cerca.
        private Ser BuscarComida(Animal animal)
        {
            foreach (var ser in listaDeSeres)
            {
                if (EsAdyacente(animal, ser)) // Verifica si el ser está adyacente al animal.
                {
                    // Si el animal es carnívoro y el ser es herbívoro, o si el animal es herbívoro y el ser es una planta, es comida.
                    if (animal is Carnivoro && ser is Herviboro) return ser;
                    if (animal is Herviboro && ser is Planta) return ser;
                }
            }
            return null; // Si no encuentra comida, retorna null.
        }

        // Genera una posición adyacente válida para un ser (animal o planta).
        private (int, int)? GenerarPosicionAdyacente(int x, int y)
        {
            var posicionesAdyacentes = new List<(int, int)>
            {
                (x - 1, y), (x + 1, y), (x, y - 1), (x, y + 1)
            };

            // Verifica si alguna posición adyacente es válida y está vacía.
            foreach (var posicion in posicionesAdyacentes)
            {
                if (EsPosicionValida(posicion.Item1, posicion.Item2) && EsEspacioVacio(posicion.Item1, posicion.Item2))
                {
                    return posicion; // Retorna la primera posición adyacente válida.
                }
            }
            return null; // Si no hay posiciones válidas, retorna null.
        }

        // Verifica si dos seres están en posiciones adyacentes.
        private bool EsAdyacente(Ser ser1, Ser ser2)
        {
            int dx = Math.Abs(ser1.PosX - ser2.PosX); // Distancia en el eje X.
            int dy = Math.Abs(ser1.PosY - ser2.PosY); // Distancia en el eje Y.
            return dx <= 1 && dy <= 1; // Si la distancia es menor o igual a 1 en ambos ejes, están adyacentes.
        }

        // Verifica si una posición (x, y) está dentro de los límites del safari.
        private bool EsPosicionValida(int x, int y)
        {
            return x >= 0 && x < tamanioX && y >= 0 && y < tamanioY; // Debe estar dentro de los límites del safari.
        }

        // Verifica si una posición (x, y) está vacía (sin seres).
        public bool EsEspacioVacio(int x, int y)
        {
            foreach (var ser in listaDeSeres)
            {
                if (ser.PosX == x && ser.PosY == y) // Si ya hay un ser en esa posición, no está vacía.
                {
                    return false;
                }
            }
            return true; // Si no hay seres en la posición, está vacía.
        }

        // Métodos para contar cuántas plantas, herbívoros, carnívoros, reproducciones y muertes hay en el safari.
        public int ContarPlantas() => listaDeSeres.Count(ser => ser is Planta);
        public int ContarHerviboros() => listaDeSeres.Count(ser => ser is Herviboro);
        public int ContarCarnivoros() => listaDeSeres.Count(ser => ser is Carnivoro);
        public int ContarReproducciones() => reproducciones;
        public int ContarMuertes() => muertes;
    }
}
