using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un zombie.
    // ACCU. 12/05/2023.
    //-------------------------------------------------------------------------
    public class CZombie: PictureBox
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        
        //Atributos de nacimiento.
        protected int XNac;
        protected int YNac;

        protected SoundPlayer Grunido1;
        protected SoundPlayer Morido;
        private Bitmap ZombieTipo;

        //Atributo de movimiento.

        protected Control AreaDesplazamiento;
        protected bool Norte;
        protected bool Sur;
        protected bool Este;
        protected bool Oeste;
        protected int Velocidad;

        //Atributos de control:

        protected bool Nacido;
        protected bool Muerto;
        //private bool Regreso;
        
        //Atributos de ejecución.

        protected Thread ProcesoVida;

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CZombie(Control AreaDesplazamiento) : base()
        {
            Grunido1 = new SoundPlayer(Properties.Resources.grunido_1);
            Morido = new SoundPlayer(Properties.Resources.gunido_muerte);
                        
            Random Aleatorio;

            Aleatorio = new Random();
            XNac = Aleatorio.Next(0, AreaDesplazamiento.Width - 50);
            YNac = Aleatorio.Next(AreaDesplazamiento.Height/2, AreaDesplazamiento.Height - 75);

            //Inicializa atributos del área de vuelo.

            this.AreaDesplazamiento = AreaDesplazamiento;
            this.AreaDesplazamiento.Controls.Add(this);

            //Construye zombie.

            Location = new Point(XNac, YNac);
            BackColor = Color.DarkOliveGreen;
            Name = "Zombie";
            Size = new Size(60, 85);
            ZombieTipo = null;

            BringToFront();

            //Inicializa atributos.

            Nacido = false;
            Muerto = false;
            //Regreso = false;

            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 0;

            ProcesoVida = null;

            //Método manejador del click y mouse enter.

            Click += new EventHandler (Identificar);
            MouseEnter += new EventHandler(Grunido);
        }
        //-------------------------------------------------------------------------
        // Identifica al Zombie.
        //-------------------------------------------------------------------------
        public void Identificar(object sender, EventArgs e)
        {
            int[] Localizacion;

            Localizacion = GetAreaLacolizacion();

            DialogResult result;
            result = MessageBox.Show(Name + " (" + Localizacion[0] + ", " 
                + Localizacion[1] + ", " + Localizacion[2] + ", " + Localizacion[3] + ")." + 
                " Su velocidad es: " + Velocidad + "\n¿Deseas matar al zombie?",
                "Identificación y muerte del zombie", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Morir();
            }
            else
            {
                return;
            }
        }
        public void Grunido(object sender, EventArgs e)
        {
            Grunido1.Play();
        }
        //-------------------------------------------------------------------------
        // Desplazamiento al Zombie.
        //-------------------------------------------------------------------------
        public void Desplazar(int Velocidad)
        {
            int X;
            int Y;

            this.Velocidad = Velocidad;

            //Desplaza el zombie por un tiempo indefinido.
            //Nota: se utiliza un hilo de ejecución el cual deberá
            //      ser finalizado al término del programa.

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {

                    if (Nacido)
                    {
                        //Coordenada de origen.

                        X = Location.X;
                        Y = Location.Y;

                        //Calcula desplazamiento.

                        if (Norte)
                        {
                            Y -= 2;
                        }

                        if (Sur)
                        {
                            Y += 2;
                        }

                        if (Este)
                        {
                            X += 1;
                        }

                        if (Oeste)
                        {
                            X -= 1;
                        }

                        //Procesa el rebote.

                        if (X <= 5)
                        {
                            Oeste = false;
                            Este = true;
                            //ZombieTipo.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }

                        if (Y <= AreaDesplazamiento.Height/2)
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if (X >= AreaDesplazamiento.Width - Width)
                        {
                            Oeste = true;
                            Este = false;
                            //ZombieTipo.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }

                        if (Y >= AreaDesplazamiento.Height - Height)
                        {
                            Norte = true;
                            Sur = false;
                        }

                        // Posición final

                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }
        //-------------------------------------------------------------------------
        // Da vida al Zombie después de un momento.
        //-------------------------------------------------------------------------
        public void Nacer()
        {
            //Thread ProcesoEjecucion;

            //ZombieTipo = this.TNacimiento();
            ///*Color ColorSeleccionado;
            ////Random Aleatorio;
            //Color ColorAleatorio;
            //int R, G, B;

            //Aleatorio = new Random();
            //R = Aleatorio.Next(0, 255);
            //G = Aleatorio.Next(0, 255);
            //B = Aleatorio.Next(0, 255);

            //ColorAleatorio = Color.FromArgb(R, G, B);*/

            //ProcesoEjecucion = new Thread(() =>
            //{
            //    Thread.Sleep(1500);
            //    //BackColor = ColorAleatorio;
            //    BackColor = Color.Transparent;
            //    Image = ZombieTipo;
            //    SizeMode = PictureBoxSizeMode.StretchImage;
            //    Nacido = true;
            //});

            //ProcesoEjecucion.Start();
            ZombieTipo = this.TNacimiento();
            BackColor = Color.Transparent;
            Image = ZombieTipo;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Nacido = true;

            Task.Delay(1500).ContinueWith(_ =>
            {
                // Código adicional a ejecutar después del retraso (si es necesario)
            });
        }
        //-------------------------------------------------------------------------
        // Le da una nueva apariencia al zombie segun su tipo.
        //-------------------------------------------------------------------------
        protected virtual Bitmap TNacimiento()
        {
            return new Bitmap(Properties.Resources.Zombie1_2);
        }
        //-------------------------------------------------------------------------
        // Mata al Zombie y lo remueve de la pantalla.
        //-------------------------------------------------------------------------
        public void Morir()
        {
            Thread ProcesoMuerte;

            ProcesoMuerte = new Thread(() =>
            {
                Muerto = true;
                Morido.Play();
                Thread.Sleep(500);
                Visible = false;
                AreaDesplazamiento.Controls.Remove(this);
                AreaDesplazamiento.Invalidate();
            });

            ProcesoMuerte.Start();
        }
        //-------------------------------------------------------------------------
        // Mata a los zombies y detiene los hilos de ejecución.
        //-------------------------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            Muerto = true;
            base.Dispose(disposing);
        }
        //-------------------------------------------------------------------------
        // Obtiene el área de localización de un zombie.
        //-------------------------------------------------------------------------
        public int[] GetAreaLacolizacion()
        {
            int[] Localizacion;

            Localizacion = new int[4];

            Localizacion[0] = Location.X;
            Localizacion[1] = Location.Y;
            Localizacion[2] = Location.X + 60;
            Localizacion[3] = Location.Y + 85;

            return Localizacion;
        }
        public int Vida { get; set; }
    }
}
/* Portada
 * Cita de todos los libros en cada parrafo APA
 * indice + indice de figuras.
 * Conceptos
 * Referencias
 * Capitulo 1 - Generalidades
 * * Objeto
 * * Estado del objeto
 * * Comportamiento de un objeto
 * Capitulo 2 - Conceptos básicos
 * * Clase
 * * Instacia
 * * Atributos
 * * Métodos
 * * Eventos
 * * Generalización
 * * Especialización
 * * Mensajes
 * * Constructor
 * Capitulos 3 - Pilares
 * * Encapsulación
 * * Abstracción
 * * Herencia
 * * Poliformismo
 */