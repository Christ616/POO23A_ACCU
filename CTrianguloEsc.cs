using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un triángulo Escaleno.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CTrianguloEsc : CTriangulo
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CTrianguloEsc(Color Color, double Base, double Altura) 
            :base(Color, Base, Altura, "Triángulo Escaleno")
        {
            NumLados = 3;
        }
    }
}