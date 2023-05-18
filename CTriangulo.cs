using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un triángulo.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CTriangulo : CPoligono
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        protected double Base;
        protected double Altura;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CTriangulo(Color Color, double Base, double Altura, string Nombre) 
            : base (Color, Nombre)
        {
            this.Base = Base;
            this.Altura = Altura;

            NumLados = 3;
        }
        //-------------------------------------------------------------------------
        // Obtiene el Área del Triángulo.
        //-------------------------------------------------------------------------
        public override void CalculaArea()
        {
            base.CalculaArea();
            Area = Base * Altura/2;
        }
    }
}
