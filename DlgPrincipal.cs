using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Diálogo principal de proyecto de prácticas de POO23A.
    // ACCU. 24/01/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private int Altura;
        private int Ancho;
        private SoundPlayer Entrada;

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            Altura = 700;
            Ancho = 1350;
            Text = "Christian Ulises Alvarez Contreras";
            Entrada = new SoundPlayer(Properties.Resources.KbdSwipeGesture);
        }
        //-------------------------------------------------------------------------
        // Maximiza el diálogo a partir de los atributos.
        //-------------------------------------------------------------------------
        private void Maximizar()
        {
            Height = Altura;
            Width = Ancho;
            Text = "Maximizada.";
            CenterToScreen();
        }
        //-------------------------------------------------------------------------
        // Al dar click a boton maximiza el dialogo.
        //-------------------------------------------------------------------------
        private void BtnPruebas1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esto rompera todo, ¿estas " +
                "seguro de aceptar el riesgo?", "Advertencia", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Maximizar();
                DialogResult result1 = MessageBox.Show("¿Ahora que hacemos? :(","¡Te lo dije!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(result1 == DialogResult.Retry)
                {
                    Altura = 710;
                    Ancho = 445;
                    Height = Altura;
                    Width = Ancho;
                    CenterToScreen();
                    BtnPruebas1.Visible = false;
                }
            }
        }
        //-------------------------------------------------------------------------
        // Al dar click abre Practica 1.
        //-------------------------------------------------------------------------
        private void PbxPractica1_Click(object sender, EventArgs e)
        {
            DlgPractica1 DlgPractica1;

            DlgPractica1 = new DlgPractica1();
            DlgPractica1.Show();
        }
        //-------------------------------------------------------------------------
        // Al dar click cierra el programa.
        //-------------------------------------------------------------------------
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres salir del programa?";
            string title = "Sistema de Prácticas POO23A";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        //-------------------------------------------------------------------------
        // Al posicionar el cursor sobre el botón.
        //-------------------------------------------------------------------------
        private void PbxPractica1_MouseEnter(object sender, EventArgs e)
        {
            // Empieza la animación
            Entrada.Play(); //Reproduce sonido.
            PbxPractica1.BackgroundImage = Properties.Resources.Libro4_4;
            PbxPractica1.Location = new Point(113, 104);
            PbxPractica1.Size = new Size(90, 120);
            LblSubTitulo.Text = "Práctica 1";
        }
        //-------------------------------------------------------------------------
        // Al quitar el cursor del botón.
        //-------------------------------------------------------------------------
        private void PbxPractica1_MouseLeave(object sender, EventArgs e)
        {
            // Detiene la animación
            Entrada.Stop(); //Detiene el sonido.
            PbxPractica1.BackgroundImage = Properties.Resources.Libro4_3;
            PbxPractica1.Location = new Point(113, 134);
            PbxPractica1.Size = new Size(17, 52);
            LblSubTitulo.Text = "";
        }
        //-------------------------------------------------------------------------
        // Al posicionar el cursor sobre el botón.
        //-------------------------------------------------------------------------
        private void PbxPractica2_MouseEnter(object sender, EventArgs e)
        {
            // Empieza la animación
            Entrada.Play(); //Reproduce sonido.
            PbxPractica2.BackgroundImage = Properties.Resources.Libro2_1;
            PbxPractica2.Location = new Point(261, 264);
            PbxPractica2.Size = new Size(90, 120);
            LblSubTitulo.Text = "Práctica 2";
        }
        //-------------------------------------------------------------------------
        // Al quitar el cursor del botón.
        //-------------------------------------------------------------------------
        private void PbxPractica2_MouseLeave(object sender, EventArgs e)
        {
            // Detiene la animación
            Entrada.Stop(); //Detiene el sonido.
            PbxPractica2.BackgroundImage = Properties.Resources.Libro2_3;
            PbxPractica2.Location = new Point(258, 290);
            PbxPractica2.Size = new Size(19, 52);
            LblSubTitulo.Text = "";
        }
        //-------------------------------------------------------------------------
        // Al posicionar el cursor sobre el botón.
        //-------------------------------------------------------------------------
        private void PbxPractica3_MouseEnter(object sender, EventArgs e)
        {
            // Empieza la animación
            Entrada.Play(); //Reproduce sonido.
            PbxPractica3.BackgroundImage = Properties.Resources.Libro1_1;
            PbxPractica3.Location = new Point(220, 348);
            PbxPractica3.Size = new Size(90, 120);
            LblSubTitulo.Text = "";
        }
        //-------------------------------------------------------------------------
        // Al quitar el cursor del botón.
        //-------------------------------------------------------------------------
        private void PbxPractica3_MouseLeave(object sender, EventArgs e)
        {
            // Detiene la animación
            Entrada.Stop(); //Detiene el sonido.
            PbxPractica3.BackgroundImage = Properties.Resources.Libro1_2;
            PbxPractica3.Location = new Point(218, 365);
            PbxPractica3.Size = new Size(19, 52);
            LblSubTitulo.Text = "";
        }
        //-------------------------------------------------------------------------
        // Cambia el texto al posicionar el cursor sobre el botón.
        //-------------------------------------------------------------------------
        private void BtnPruebas1_MouseEnter(object sender, EventArgs e)
        {
            Entrada.Play(); //Reproduce sonido.
            LblSubTitulo.Text = "Boton de Prueba";
        }
        //-------------------------------------------------------------------------
        // Cambia el texto al quitar el cursor del botón.
        //-------------------------------------------------------------------------
        private void BtnPruebas1_MouseLeave(object sender, EventArgs e)
        {
            Entrada.Stop(); //Detiene el sonido.
            LblSubTitulo.Text = "";
        }
        //-------------------------------------------------------------------------
        // Cambia el texto al posicionar el cursor sobre el botón.
        //-------------------------------------------------------------------------
        private void BtnCerrar_MouseEnter(object sender, EventArgs e)
        {
            Entrada.Play(); //Reproduce sonido.
            LblSubTitulo.Text = "Salir";
        }
        //-------------------------------------------------------------------------
        // Cambia el texto al quitar el cursor del botón.
        //-------------------------------------------------------------------------
        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            Entrada.Stop(); //Detiene el sonido.
            LblSubTitulo.Text = "";
        }

        private void PbxPractica2_Click(object sender, EventArgs e)
        {
            DlgPractica2 DlgPractica2;

            DlgPractica2 = new DlgPractica2();
            DlgPractica2.Show();
        }
    }
} // Fin de la clase.