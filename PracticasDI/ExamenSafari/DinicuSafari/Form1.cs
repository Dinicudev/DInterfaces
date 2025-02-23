using DinicuSafari.Controller;
using DinicuSafari.Entities;

namespace DinicuSafari
{
    public partial class FormSafari : Form
    {
        private ControladorSafari controlador; // Este es el controlador que maneja toda la lógica del safari.
        private System.Windows.Forms.Timer temporizador; // Timer que podría usarse para temporizar la simulación, pero no está en uso actualmente.
        private bool isAutoplay = false; // Variable que indica si el autoplay está activado o no. Lo inicializamos en 'false' para que no inicie automáticamente.
        private Thread hiloAutoplay; // Hilo que se encargará de ejecutar el autoplay en segundo plano.

        public FormSafari()
        {
            InitializeComponent(); // Inicializa todos los componentes visuales del formulario (UI).

            controlador = new ControladorSafari(this); // Conecta el formulario con el controlador, para que el formulario pueda interactuar con la lógica del safari.

            InicializarTablero(); // Configura el tablero gráfico de la interfaz.
            controlador.InicializarSimulacion(); // Inicializa la simulación en el controlador (creación de seres en el safari).
        }

        /// <summary>
        /// Inicializa el tablero gráfico donde se muestran las entidades del safari.
        /// </summary>
        private void InicializarTablero()
        {
            // Limpiamos cualquier contenido previo en el tablero antes de volver a dibujarlo.
            tableLayoutPanel1.Controls.Clear();

            // Definimos las dimensiones del tablero (10x10 celdas).
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.ColumnCount = 10;

            // Aquí vamos a crear las celdas del tablero.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // Creamos una etiqueta para representar cada celda en el tablero.
                    var label = new Label
                    {
                        Text = "Vacío", // Inicialmente, las celdas estarán vacías.
                        TextAlign = ContentAlignment.MiddleCenter, // Alineamos el texto al centro de la celda.
                        BackColor = Color.White, // Color de fondo para celdas vacías.
                        Dock = DockStyle.Fill, // Hacemos que la etiqueta ocupe todo el espacio de la celda.
                        BorderStyle = BorderStyle.FixedSingle // Añadimos un borde a cada celda.
                    };

                    // Añadimos la etiqueta al tablero en la posición correspondiente (columna j, fila i).
                    tableLayoutPanel1.Controls.Add(label, j, i);
                }
            }
        }

        /// <summary>
        /// Inicia el autoplay, que ejecuta automáticamente los turnos del safari.
        /// </summary>
        private void IniciarAutoplay()
        {
            // Verificamos si ya no hay un hilo en ejecución o si el hilo actual está detenido.
            if (hiloAutoplay == null || !hiloAutoplay.IsAlive)
            {
                isAutoplay = true; // Activamos el autoplay.
                hiloAutoplay = new Thread(() =>
                {
                    while (isAutoplay) // El hilo sigue ejecutando mientras isAutoplay sea verdadero.
                    {
                        controlador.EjecutarTurno(); // Ejecutamos un turno de la simulación.
                        Thread.Sleep(3000); // Esperamos 3 segundos antes de ejecutar el siguiente turno.
                    }
                });

                hiloAutoplay.IsBackground = true; // El hilo se cerrará automáticamente cuando se cierre la aplicación.
                hiloAutoplay.Start(); // Iniciamos el hilo de autoplay.
                Console.WriteLine("Autoplay iniciado."); // Mensaje de depuración en consola para saber que el autoplay comenzó.
            }
        }

        /// <summary>
        /// Detiene el autoplay, deteniendo el hilo que ejecuta la simulación automáticamente.
        /// </summary>
        public void DetenerAutoplay()
        {
            // Verificamos si el hilo de autoplay está en ejecución.
            if (hiloAutoplay != null && hiloAutoplay.IsAlive)
            {
                isAutoplay = false; // Desactivamos el autoplay.
                hiloAutoplay.Join(10000); // Esperamos a que el hilo termine su ejecución.
                hiloAutoplay = null; // Limpiamos la referencia al hilo.
                Console.WriteLine("Autoplay detenido."); // Mensaje de depuración en consola para confirmar que el autoplay se detuvo.
            }
        }

        /// <summary>
        /// Actualiza el tablero gráfico con el estado actual de la simulación.
        /// </summary>
       /* public void ActualizarTablero(string[,] estado)
        {
            // Si no estamos en el hilo principal (UI), usamos Invoke para asegurarnos de que la UI se actualice correctamente.
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarTablero(estado)));
                return;
            }

            // Actualizamos cada celda del tablero con la información de la simulación.
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    var label = tableLayoutPanel1.GetControlFromPosition(j, i) as Label;

                    // Si encontramos una etiqueta en la posición correcta, la actualizamos según el estado del safari.
                    if (label != null)
                    {
                        string celda = estado[i, j];
                        switch (celda)
                        {
                            case "Planta":
                                label.Text = "Planta"; // Mostramos "Planta" en la celda.
                                label.BackColor = Color.Green; // Color verde para plantas.
                                break;

                            case "Gacela":
                                label.Text = "Gacela";
                                label.BackColor = Color.Brown;
                                break;

                            case "Elefante":
                                label.Text = "Elefante";
                                label.BackColor = Color.Blue;
                                break;

                            case "Carnivoro":
                                label.Text = "Leon"; // Mostramos "León" para los carnívoros.
                                label.BackColor = Color.Red; // Color rojo para carnívoros.
                                break;

                            default:
                                label.Text = "Vacío"; // Si no es planta, herbívoro o carnívoro, mostramos "Vacío".
                                label.BackColor = Color.White; // Color blanco para celdas vacías.
                                break;
                        }
                    }
                }
            }
        }*/

        //Examen3
        public void ActualizarTablero(string[,] estado)
        {
            // Mostrar si es día o noche.
            label6.Text = controlador != null && controlador.EsNoche ? "Es de Noche" : "Es de Día";

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    var label = tableLayoutPanel1.GetControlFromPosition(j, i) as Label;

                    if (label != null)
                    {
                        string celda = estado[i, j];
                        switch (celda)
                        {
                            case "Planta":
                                label.Text = "Planta";
                                label.BackColor = Color.Green;
                                break;

                            case "Gacela":
                                label.Text = "Gacela";
                                label.BackColor = Color.Brown;
                                break;

                            case "Elefante":
                                label.Text = "Elefante";
                                label.BackColor = Color.Blue;
                                break;

                            case "Carnivoro":
                                label.Text = "Leon";
                                label.BackColor = Color.Red;
                                break;

                            default:
                                label.Text = "Vacío";
                                label.BackColor = Color.White;
                                break;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Maneja el evento de clic en el botón PLAY: inicia el autoplay.
        /// </summary>
        private void button1_Click(object sender, EventArgs e) // PLAY
        {
            IniciarAutoplay(); // Llama a la función que inicia el autoplay.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón STOP: detiene el autoplay.
        /// </summary>
        private void button2_Click(object sender, EventArgs e) // STOP
        {
            DetenerAutoplay(); // Llama a la función que detiene el autoplay.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón RESET: reinicia la simulación.
        /// </summary>
        private void button5_Click(object sender, EventArgs e) // RESET
        {
            // Aquí reiniciamos las variables para empezar desde cero en la simulación.
            isAutoplay = false; // Desactivamos el autoplay.
            controlador = new ControladorSafari(this); // Creamos un nuevo controlador de simulación.
            InicializarTablero(); // Limpiamos y reiniciamos el tablero gráfico.
        }

        /// <summary>
        /// Actualiza las estadísticas mostradas en la interfaz gráfica.
        /// </summary>
        public void ActualizarEstadisticas(int plantas, int herviboros, int carnivoros, int reproducciones, int muertes)
        {
            label1.Text = $"Plantas: {plantas}";
            label2.Text = $"Hervíboros: {herviboros}";
            label3.Text = $"Carnívoros: {carnivoros}";
            label4.Text = $"Reproducciones: {reproducciones}";
            label5.Text = $"Muertes: {muertes}";
        }

        /// <summary>
        /// Maneja el evento de clic en el botón STEP: avanza un turno manualmente en la simulación.
        /// </summary>
        private void button3_Click_1(object sender, EventArgs e) // STEP
        {
            // Solo permite avanzar manualmente si el autoplay está desactivado.
            if (!isAutoplay)
            {
                controlador.EjecutarTurno(); // Ejecuta un turno manualmente.
            }
        }

        // Métodos adicionales relacionados con el menú (Play, Pause, Stop, Reset).

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAutoplay = false; // Reinicia el autoplay.
            controlador = new ControladorSafari(this); // Reinicia el controlador de la simulación.
            InicializarTablero(); // Reinicia el tablero gráfico.
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetenerAutoplay(); // Detiene el autoplay desde el menú.
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetenerAutoplay();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación al intentar salir de la aplicación.
            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Salir del programa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma, cierra la aplicación.
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Cierra la aplicación.
            }
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Muestra la ventana de ayuda con las reglas y controles del simulador.
            string mensajeAyuda = "Ayuda del Safari:\n\n" +
                                  "Objetivo:\n" +
                                  "Observa cómo interactúan los seres vivos en el ecosistema del safari.\n\n" +
                                  "Reglas:\n" +
                                  "- Plantas: Se reproducen cada 2 turnos.\n" +
                                  "- Gacelas: Comen plantas y se reproducen cada 4 turnos.\n" +
                                  "- Leones: Comen gacelas y se reproducen cada 6 turnos.\n" +
                                  "- Hambre: Si un animal no come en 3 turnos, muere.\n\n" +
                                  "Controles:\n" +
                                  "- Play: Inicia la simulación.\n" +
                                  "- Step: Avanza un turno.\n" +
                                  "- Stop: Detiene la simulación.\n" +
                                  "- Reset: Reinicia todo.\n\n" +
                                  "¡Disfruta del simulador!";

            MessageBox.Show(mensajeAyuda, "Ayuda del Safari", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)//10Pasos Examen2
        {
            DetenerAutoplay();
            controlador.Ejecutar10Pasos();

        }

        private void pASOSToolStripMenuItem_Click(object sender, EventArgs e) //10Pasos Examen2
        {
            DetenerAutoplay();
            controlador.Ejecutar10Pasos();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
