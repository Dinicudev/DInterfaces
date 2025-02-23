
namespace DinicuSafari
{
    partial class FormSafari
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelBotones = new Panel();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            funcionesPrincipalesToolStripMenuItem = new ToolStripMenuItem();
            stepToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            playToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pASOSToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelBotones.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(PanelBotones);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 468);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(766, 310);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(766, 310);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelBotones
            // 
            PanelBotones.BackColor = Color.FromArgb(0, 192, 192);
            PanelBotones.Controls.Add(groupBox2);
            PanelBotones.Controls.Add(groupBox1);
            PanelBotones.Dock = DockStyle.Top;
            PanelBotones.Location = new Point(0, 33);
            PanelBotones.Name = "PanelBotones";
            PanelBotones.Size = new Size(766, 125);
            PanelBotones.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadisticas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(639, 24);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 4;
            label5.Text = "Muertes: ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 24);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 3;
            label4.Text = "Reproducciones:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 24);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Carnivoros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Herviboros: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Plantas: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(665, 27);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 6;
            label6.Text = "Es de:";
            label6.Click += label6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(557, 18);
            button6.Name = "button6";
            button6.Size = new Size(104, 40);
            button6.TabIndex = 5;
            button6.Text = "10 PASOS";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(447, 18);
            button5.Name = "button5";
            button5.Size = new Size(104, 40);
            button5.TabIndex = 4;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(337, 18);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 3;
            button4.Text = "PAUSE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(227, 17);
            button3.Name = "button3";
            button3.Size = new Size(104, 41);
            button3.TabIndex = 2;
            button3.Text = "STEP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(117, 16);
            button2.Name = "button2";
            button2.Size = new Size(104, 42);
            button2.TabIndex = 1;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 16);
            button1.Name = "button1";
            button1.Size = new Size(104, 42);
            button1.TabIndex = 0;
            button1.Text = "PLAY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesPrincipalesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(766, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // funcionesPrincipalesToolStripMenuItem
            // 
            funcionesPrincipalesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stepToolStripMenuItem, resetToolStripMenuItem, pauseToolStripMenuItem, playToolStripMenuItem, stopToolStripMenuItem, exitToolStripMenuItem, pASOSToolStripMenuItem });
            funcionesPrincipalesToolStripMenuItem.Name = "funcionesPrincipalesToolStripMenuItem";
            funcionesPrincipalesToolStripMenuItem.Size = new Size(195, 29);
            funcionesPrincipalesToolStripMenuItem.Text = "Funciones Principales";
            // 
            // stepToolStripMenuItem
            // 
            stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            stepToolStripMenuItem.Size = new Size(189, 34);
            stepToolStripMenuItem.Text = "Play";
            stepToolStripMenuItem.Click += stepToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(189, 34);
            resetToolStripMenuItem.Text = "Pause";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(189, 34);
            pauseToolStripMenuItem.Text = "Step";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(189, 34);
            playToolStripMenuItem.Text = "Reset";
            playToolStripMenuItem.Click += playToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(189, 34);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(189, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // pASOSToolStripMenuItem
            // 
            pASOSToolStripMenuItem.Name = "pASOSToolStripMenuItem";
            pASOSToolStripMenuItem.Size = new Size(189, 34);
            pASOSToolStripMenuItem.Text = "10PASOS";
            pASOSToolStripMenuItem.Click += pASOSToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(79, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(191, 34);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(191, 34);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += AcercaDeToolStripMenuItem_Click;
            // 
            // FormSafari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 468);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "FormSafari";
            Text = "Panel Safari";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            PanelBotones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetenerAutoplay(); // Detiene el autoplay desde el menú.
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarAutoplay();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Solo permite avanzar manualmente si el autoplay está desactivado.
            if (!isAutoplay)
            {
                controlador.EjecutarTurno(); // Ejecuta un turno manualmente.
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Este programa ha sido creado por Noemí Dinicu Vararu.\n Para la práctica de Diseño de Interfaces.",
                "Acerca del Programa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionesPrincipalesToolStripMenuItem;
        private ToolStripMenuItem stepToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Panel PanelBotones;
        private GroupBox groupBox1;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Button button6;
        private ToolStripMenuItem pASOSToolStripMenuItem;
        private Label label6;
    }
}
