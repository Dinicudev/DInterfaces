using DinicuSafari.Controller;
using DinicuSafari.Entities;

namespace DinicuSafari
{
    public partial class FormSafari : Form
    {
        private ControladorSafari controlador; // Este es el controlador que maneja toda la l�gica del safari.
        private System.Windows.Forms.Timer temporizador; // Timer que podr�a usarse para temporizar la simulaci�n, pero no est� en uso actualmente.
        private bool isAutoplay = false; // Variable que indica si el autoplay est� activado o no. Lo inicializamos en 'false' para que no inicie autom�ticamente.
        private Thread hiloAutoplay; // Hilo que se encargar� de ejecutar el autoplay en segundo plano.

        public FormSafari()
        {
            InitializeComponent(); // Inicializa todos los componentes visuales del formulario (UI).

            controlador = new ControladorSafari(this); // Conecta el formulario con el controlador, para que el formulario pueda interactuar con la l�gica del safari.

            InicializarTablero(); // Configura el tablero gr�fico de la interfaz.
            controlador.InicializarSimulacion(); // Inicializa la simulaci�n en el controlador (creaci�n de seres en el safari).
        }

        /// <summary>
        /// Inicializa el tablero gr�fico donde se muestran las entidades del safari.
        /// </summary>
        private void InicializarTablero()
        {
            // Limpiamos cualquier contenido previo en el tablero antes de volver a dibujarlo.
            tableLayoutPanel1.Controls.Clear();

            // Definimos las dimensiones del tablero (10x10 celdas).
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.ColumnCount = 10;

            // Aqu� vamos a crear las celdas del tablero.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // Creamos una etiqueta para representar cada celda en el tablero.
                    var label = new Label
                    {
                        Text = "Vac�o", // Inicialmente, las celdas estar�n vac�as.
                        TextAlign = ContentAlignment.MiddleCenter, // Alineamos el texto al centro de la celda.
                        BackColor = Color.White, // Color de fondo para celdas vac�as.
                        Dock = DockStyle.Fill, // Hacemos que la etiqueta ocupe todo el espacio de la celda.
                        BorderStyle = BorderStyle.FixedSingle // A�adimos un borde a cada celda.
                    };

                    // A�adimos la etiqueta al tablero en la posici�n correspondiente (columna j, fila i).
                    tableLayoutPanel1.Controls.Add(label, j, i);
                }
            }
        }

        /// <summary>
        /// Inicia el autoplay, que ejecuta autom�ticamente los turnos del safari.
        /// </summary>
        private void IniciarAutoplay()
        {
            // Verificamos si ya no hay un hilo en ejecuci�n o si el hilo actual est� detenido.
            if (hiloAutoplay == null || !hiloAutoplay.IsAlive)
            {
                isAutoplay = true; // Activamos el autoplay.
                hiloAutoplay = new Thread(() =>
                {
                    while (isAutoplay) // El hilo sigue ejecutando mientras isAutoplay sea verdadero.
                    {
                        controlador.EjecutarTurno(); // Ejecutamos un turno de la simulaci�n.
                        Thread.Sleep(3000); // Esperamos 3 segundos antes de ejecutar el siguiente turno.
                    }
                });

                hiloAutoplay.IsBackground = true; // El hilo se cerrar� autom�ticamente cuando se cierre la aplicaci�n.
                hiloAutoplay.Start(); // Iniciamos el hilo de autoplay.
                Console.WriteLine("Autoplay iniciado."); // Mensaje de depuraci�n en consola para saber que el autoplay comenz�.
            }
        }

        /// <summary>
        /// Detiene el autoplay, deteniendo el hilo que ejecuta la simulaci�n autom�ticamente.
        /// </summary>
        public void DetenerAutoplay()
        {
            // Verificamos si el hilo de autoplay est� en ejecuci�n.
            if (hiloAutoplay != null && hiloAutoplay.IsAlive)
            {
                isAutoplay = false; // Desactivamos el autoplay.
                hiloAutoplay.Join(10000); // Esperamos a que el hilo termine su ejecuci�n.
                hiloAutoplay = null; // Limpiamos la referencia al hilo.
                Console.WriteLine("Autoplay detenido."); // Mensaje de depuraci�n en consola para confirmar que el autoplay se detuvo.
            }
        }

        /// <summary>
        /// Actualiza el tablero gr�fico con el estado actual de la simulaci�n.
        /// </summary>
       /* public void ActualizarTablero(string[,] estado)
        {
            // Si no estamos en el hilo principal (UI), usamos Invoke para asegurarnos de que la UI se actualice correctamente.
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarTablero(estado)));
                return;
            }

            // Actualizamos cada celda del tablero con la informaci�n de la simulaci�n.
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    var label = tableLayoutPanel1.GetControlFromPosition(j, i) as Label;

                    // Si encontramos una etiqueta en la posici�n correcta, la actualizamos seg�n el estado del safari.
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
                                label.Text = "Leon"; // Mostramos "Le�n" para los carn�voros.
                                label.BackColor = Color.Red; // Color rojo para carn�voros.
                                break;

                            default:
                                label.Text = "Vac�o"; // Si no es planta, herb�voro o carn�voro, mostramos "Vac�o".
                                label.BackColor = Color.White; // Color blanco para celdas vac�as.
                                break;
                        }
                    }
                }
            }
        }*/

        //Examen3
        public void ActualizarTablero(string[,] estado)
        {
            // Mostrar si es d�a o noche.
            label6.Text = controlador != null && controlador.EsNoche ? "Es de Noche" : "Es de D�a";

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
                                label.Text = "Vac�o";
                                label.BackColor = Color.White;
                                break;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Maneja el evento de clic en el bot�n PLAY: inicia el autoplay.
        /// </summary>
        private void button1_Click(object sender, EventArgs e) // PLAY
        {
            IniciarAutoplay(); // Llama a la funci�n que inicia el autoplay.
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n STOP: detiene el autoplay.
        /// </summary>
        private void button2_Click(object sender, EventArgs e) // STOP
        {
            DetenerAutoplay(); // Llama a la funci�n que detiene el autoplay.
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n RESET: reinicia la simulaci�n.
        /// </summary>
        private void button5_Click(object sender, EventArgs e) // RESET
        {
            // Aqu� reiniciamos las variables para empezar desde cero en la simulaci�n.
            isAutoplay = false; // Desactivamos el autoplay.
            controlador = new ControladorSafari(this); // Creamos un nuevo controlador de simulaci�n.
            InicializarTablero(); // Limpiamos y reiniciamos el tablero gr�fico.
        }

        /// <summary>
        /// Actualiza las estad�sticas mostradas en la interfaz gr�fica.
        /// </summary>
        public void ActualizarEstadisticas(int plantas, int herviboros, int carnivoros, int reproducciones, int muertes)
        {
            label1.Text = $"Plantas: {plantas}";
            label2.Text = $"Herv�boros: {herviboros}";
            label3.Text = $"Carn�voros: {carnivoros}";
            label4.Text = $"Reproducciones: {reproducciones}";
            label5.Text = $"Muertes: {muertes}";
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n STEP: avanza un turno manualmente en la simulaci�n.
        /// </summary>
        private void button3_Click_1(object sender, EventArgs e) // STEP
        {
            // Solo permite avanzar manualmente si el autoplay est� desactivado.
            if (!isAutoplay)
            {
                controlador.EjecutarTurno(); // Ejecuta un turno manualmente.
            }
        }

        // M�todos adicionales relacionados con el men� (Play, Pause, Stop, Reset).

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAutoplay = false; // Reinicia el autoplay.
            controlador = new ControladorSafari(this); // Reinicia el controlador de la simulaci�n.
            InicializarTablero(); // Reinicia el tablero gr�fico.
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetenerAutoplay(); // Detiene el autoplay desde el men�.
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetenerAutoplay();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmaci�n al intentar salir de la aplicaci�n.
            var confirmResult = MessageBox.Show(
                "�Est�s seguro de que deseas salir?",
                "Salir del programa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma, cierra la aplicaci�n.
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Cierra la aplicaci�n.
            }
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Muestra la ventana de ayuda con las reglas y controles del simulador.
            string mensajeAyuda = "Ayuda del Safari:\n\n" +
                                  "Objetivo:\n" +
                                  "Observa c�mo interact�an los seres vivos en el ecosistema del safari.\n\n" +
                                  "Reglas:\n" +
                                  "- Plantas: Se reproducen cada 2 turnos.\n" +
                                  "- Gacelas: Comen plantas y se reproducen cada 4 turnos.\n" +
                                  "- Leones: Comen gacelas y se reproducen cada 6 turnos.\n" +
                                  "- Hambre: Si un animal no come en 3 turnos, muere.\n\n" +
                                  "Controles:\n" +
                                  "- Play: Inicia la simulaci�n.\n" +
                                  "- Step: Avanza un turno.\n" +
                                  "- Stop: Detiene la simulaci�n.\n" +
                                  "- Reset: Reinicia todo.\n\n" +
                                  "�Disfruta del simulador!";

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
