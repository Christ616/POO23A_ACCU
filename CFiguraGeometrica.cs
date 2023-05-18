using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa una figura geometrica.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CFiguraGeometrica : CFigura
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        protected double Area;
        protected bool AreaCalculada;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CFiguraGeometrica(Color Color, string Nombre)
            :base(Color,Nombre)
        {
            Area = 0;
            AreaCalculada = false;
        }
        //-------------------------------------------------------------------------
        // Levanta la bandera.
        //-------------------------------------------------------------------------
        public double GetArea()
        {
            if (AreaCalculada)
            {
                return Area;
            }
            else
            {
                return -1; //Cuando no haya sido calculada.
            }
        }
        //-------------------------------------------------------------------------
        // Obtiene el Área de la figura geométrica.
        //-------------------------------------------------------------------------
        public virtual void CalculaArea()
        {
            AreaCalculada = true;
        }
    }
}
