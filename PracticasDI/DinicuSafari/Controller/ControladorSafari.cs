using DinicuSafari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinicuSafari.Controller
{
    // Clase que actúa como controlador para la simulación del safari.
    // Conecta la lógica de negocio (modelos) con la interfaz de usuario (UI).
    public class ControladorSafari
    {
        private Safari safari;  // Instancia del safari, que contiene la simulación del ecosistema.
        private FormSafari form;  // Instancia del formulario, que representa la UI del safari.

        // Constructor que inicializa el controlador con el formulario.
        // Se encarga de inicializar la simulación.
        public ControladorSafari(FormSafari form)
        {
            this.form = form;  // Asocia el formulario con el controlador.
            InicializarSimulacion();  // Llama al método para configurar la simulación.
        }

        // Inicializa la simulación del safari, creando un safari de 10x10 y llenándolo con seres.
        public void InicializarSimulacion()
        {
            safari = new Safari(10, 10); // Crea un safari con un tablero de 10x10.
            LlenarSafariConSeres();  // Llena el safari con plantas, herbívoros y carnívoros.
            form.ActualizarTablero(safari.ObtenerEstado());  // Actualiza el tablero en la UI con el estado inicial.

            // Actualiza las estadísticas en la UI.
            form.ActualizarEstadisticas(
                safari.ContarPlantas(),
                safari.ContarHerviboros(),
                safari.ContarCarnivoros(),
                safari.ContarReproducciones(),
                safari.ContarMuertes()
            );
        }

        // Llenar el safari con seres aleatorios: plantas, herbívoros y carnívoros.
        private void LlenarSafariConSeres()
        {
            Random random = new Random();  // Crea un objeto para generar números aleatorios.
            int totalEspacios = 10 * 10;  // Calcula el total de espacios disponibles en el tablero (10x10).

            // Calcula la cantidad de plantas, herbívoros y carnívoros.
            int totalPlantas = (int)(totalEspacios * 0.6);  // 60% plantas.
            int totalHerviboros = (int)(totalEspacios * 0.3);  // 30% herbívoros.
            int totalCarnivoros = totalEspacios - totalPlantas - totalHerviboros;  // 10% carnívoros.

            // Creamos un tablero vacío para rastrear las posiciones ocupadas.
            bool[,] ocupado = new bool[10, 10];

            // Función para generar una posición aleatoria en el tablero.
            int x, y;
            void GenerarPosicion()
            {
                do
                {
                    x = random.Next(0, 10);  // Genera una coordenada X aleatoria entre 0 y 9.
                    y = random.Next(0, 10);  // Genera una coordenada Y aleatoria entre 0 y 9.
                } while (ocupado[x, y]);  // Repite hasta que encontremos una posición no ocupada.
                ocupado[x, y] = true;  // Marca la posición como ocupada.
            }

            // Agregar plantas al safari.
            for (int i = 0; i < totalPlantas; i++)
            {
                GenerarPosicion();  // Genera una posición aleatoria para la planta.
                safari.AgregarSer(new Planta($"Planta{i + 1}", x, y, safari));  // Crea una planta en esa posición.
            }

            // Agregar herbívoros al safari.
            for (int i = 0; i < totalHerviboros; i++)
            {
                GenerarPosicion();  // Genera una posición aleatoria para el herbívoro.
                safari.AgregarSer(new Gacela($"Gacela{i + 1}", x, y, safari));  // Crea un herbívoro (Gacela) en esa posición.
            }

            // Agregar carnívoros al safari.
            for (int i = 0; i < totalCarnivoros; i++)
            {
                GenerarPosicion();  // Genera una posición aleatoria para el carnívoro.
                safari.AgregarSer(new Leon($"Leon{i + 1}", x, y, safari));  // Crea un carnívoro (León) en esa posición.
            }
        }

        // Ejecuta un turno en la simulación y actualiza la interfaz.
        public void EjecutarTurno()
        {
            if (form.InvokeRequired)
            {
                // Si el método no está siendo ejecutado en el hilo principal (UI), usamos Invoke para ejecutarlo correctamente.
                form.Invoke(new Action(() => EjecutarTurno()));
                return;
            }

            // Ejecuta el turno en el modelo (actualiza el estado del safari).
            safari.EjecutarTurno();  // Este método gestiona el ciclo de vida de los seres en el safari.

            // Actualiza el estado del tablero en la UI.
            string[,] estadoTablero = safari.ObtenerEstado();
            form.ActualizarTablero(estadoTablero);

            // Actualiza las estadísticas en la UI.
            form.ActualizarEstadisticas(
                safari.ContarPlantas(),
                safari.ContarHerviboros(),
                safari.ContarCarnivoros(),
                safari.ContarReproducciones(),
                safari.ContarMuertes()
            );

            // Verifica si el juego ha terminado (game over).
            VerificarGameOver();
        }

        // Verifica si se han cumplido las condiciones de "Game Over".
        private void VerificarGameOver()
        {
            int plantas = safari.ContarPlantas();
            int herviboros = safari.ContarHerviboros();
            int carnivoros = safari.ContarCarnivoros();

            string mensaje = null;

            // Condición 1: No hay más herbívoros ni carnívoros, pero hay plantas.
            if (herviboros == 0 && carnivoros == 0 && plantas > 0)
            {
                mensaje = "GAME OVER -> Las plantas han gobernado.";
            }

            // Condición 2: Todos los seres han muerto.
            if (herviboros == 0 && carnivoros == 0 && plantas == 0)
            {
                mensaje = "GAME OVER -> Todos han muerto.";
            }

            // Si alguna condición de "Game Over" se cumple, mostramos el mensaje correspondiente.
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
