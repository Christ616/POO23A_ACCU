using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un zombie romero.
    // ACCU. 12/05/2023.
    //-------------------------------------------------------------------------
    public class CZombiePasivo : CZombie
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CZombiePasivo(Control AreaDesplazamiento) : base(AreaDesplazamiento)
        {
            int X;
            int Y;

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
                            Y -= 1;
                        }

                        if (Sur)
                        {
                            Y += 1;
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
                            Image = Properties.Resources.Zombie1_2;
                        }

                        if (Y <= AreaDesplazamiento.Height / 2)
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if (X >= AreaDesplazamiento.Width - Width)
                        {
                            Oeste = true;
                            Este = false;
                            Image = Properties.Resources.Zombie1_1;
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
        // Le da una nueva apariencia al zombie segun su tipo.
        //-------------------------------------------------------------------------
        protected override Bitmap TNacimiento()
        {
            return new Bitmap(Properties.Resources.Zombie1_2);
        }
    }
}
